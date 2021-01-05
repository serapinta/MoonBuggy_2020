/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 *
 * Author: Nuno Fachada
 * */

using System;
using System.Collections.Generic;
using CoreGameEngine;

namespace MoonBuggy_2020
{
    class Game
    {
        // World dimensions
        int xdim = 200, ydim = 30;

        // Frame duration in miliseconds
        int frameLength = 100;

        // The (only) game scene
        private Scene gameScene;


        public static void Main(string[] args)
        {
            // Create a new small game and run it
            Game moonBuggy = new Game();
            moonBuggy.Run();
        }

        private Game()
        {
            // Create scene
            ConsoleKey[] quitKeys = new ConsoleKey[] { ConsoleKey.Escape };
            gameScene = new Scene(xdim, ydim,
                new InputHandler(quitKeys),
                new ConsoleRenderer(xdim, ydim, new ConsolePixel(' ')),
                new CollisionHandler(xdim, ydim));

            GameObject buggy = new GameObject("Player");
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
            GameObject HoleSpawner = new GameObject("HoleSpawner");
            HoleSpawner.AddComponent(new HoleSpawner(gameScene));
            gameScene.AddGameObject(HoleSpawner);


            // Create game object for showing date and time
            GameObject dateGameObject = new GameObject("Time");

            dateGameObject.AddComponent(new Position(xdim / 2 + 1, 0, 10));

            RenderableStringComponent renderStringccomponentDate = new RenderableStringComponent(
                () => DateTime.Now.ToString("F"),
                i => new Vector2(i, 0),
                ConsoleColor.DarkMagenta, ConsoleColor.White);

            dateGameObject.AddComponent(renderStringccomponentDate);
            gameScene.AddGameObject(dateGameObject);

            // Create game object for showing position
            GameObject pos = new GameObject("Position");
            pos.AddComponent(new Position(1, 0, 10));
            RenderableStringComponent rscPos = new RenderableStringComponent(
                () => $"({playerPos.Pos.X}, {playerPos.Pos.Y})",
                i => new Vector2(i, 0),
                ConsoleColor.DarkMagenta, ConsoleColor.White);
            pos.AddComponent(rscPos);
            gameScene.AddGameObject(pos);
        }

        private void Run()
        {
            // Start game loop
            gameScene.GameLoop(frameLength);
        }
    }

}