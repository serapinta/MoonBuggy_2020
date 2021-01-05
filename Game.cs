
using System;
using System.Collections.Generic;
using CoreGameEngine;

namespace MoonBuggy_2020
{
   public class Game
    {
        // World dimensions
        int xdim = 200, ydim = 30;

        // Frame duration in miliseconds
        int frameLength = 100;

        // The (only) game scene
        private Scene gameScene;

        private int currentScore = 0;

        public Game()
        {
            // Create scene
            ConsoleKey[] quitKeys = new ConsoleKey[] { ConsoleKey.Escape };
            gameScene = new Scene(xdim, ydim,
                new InputHandler(quitKeys),
                new ConsoleRenderer(xdim, ydim, new ConsolePixel(' ')),
                new CollisionHandler(xdim, ydim));

            GameObject buggy = new GameObject("Buggy");
            KeyObserver playerKeyListener = new KeyObserver(new ConsoleKey[] {
                ConsoleKey.Spacebar});

            buggy.AddComponent(playerKeyListener);

            Position playerPos = new Position(150f, 26f, 0f);
            buggy.AddComponent(playerPos);
            buggy.AddComponent(new Buggy());
            buggy.AddComponent(buggy.GetComponent<Buggy>().BuggySprite);
            gameScene.AddGameObject(buggy);

            // Create walls
            GameObject ground = new GameObject("Ground");

            ConsolePixel wallPixel = new ConsolePixel(
                '#', ConsoleColor.DarkGray, ConsoleColor.White);
            Dictionary<Vector2, ConsolePixel> wallPixels =
                new Dictionary<Vector2, ConsolePixel>();

            for (int x = 0; x < xdim; x++)
                wallPixels[new Vector2(x, ydim - 1)] = wallPixel;

            for (int x = 0; x < xdim; x++)
                wallPixels[new Vector2(x, ydim - 2)] = wallPixel;

            ground.AddComponent(new ConsoleSprite(wallPixels));
            ground.AddComponent(new Position(0, 0, 1));
            gameScene.AddGameObject(ground);


            // Create Hole Spawner
            GameObject holeSpawner = new GameObject("HoleSpawner");
            holeSpawner.AddComponent(new HoleSpawner(gameScene));
            gameScene.AddGameObject(holeSpawner);



            GameObject score = new GameObject("Score");
            score.AddComponent(new Position(1, 1, 10));
            RenderableStringComponent rscPos = new RenderableStringComponent(
                () => $"Score: {currentScore}",
                i => new Vector2(i, 0),
                ConsoleColor.White, ConsoleColor.DarkGray);
            score.AddComponent(rscPos);
            score.AddComponent(new CalculateScore(this, holeSpawner.GetComponent<HoleSpawner>().Holes));
            gameScene.AddGameObject(score);

            // Create game object for showing position
            GameObject pos = new GameObject("Position");
            pos.AddComponent(new Position(1, 0, 10));
            RenderableStringComponent renderableStringComponentPos = new RenderableStringComponent(
                () => $"({playerPos.Pos.X}, {playerPos.Pos.Y})",
                i => new Vector2(i, 0),
                ConsoleColor.DarkMagenta, ConsoleColor.White);
            pos.AddComponent(renderableStringComponentPos);
            gameScene.AddGameObject(pos);
        }

        public void AddScore()
        {
            currentScore += 5;
        }


        public void Run()
        {
            // Start game loop
            gameScene.GameLoop(frameLength);
        }
    }

}