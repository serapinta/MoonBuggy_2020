using System;
using System.Collections.Generic;
using CoreGameEngine;


namespace MoonBuggy_2020
{
    class HoleSpawner : Component
    {
        /// <summary>
        /// Generates the holes
        /// </summary>
        /// <returns></returns>
        Random holeChance = new Random();

        private Scene gameScene;

        public List<GameObject> Holes { get; private set; }

        private int holeCounter;

        private int spawnDelay;
        private bool canSpawn;

        public HoleSpawner(Scene gameScene)
        {
            this.gameScene = gameScene; 
            Holes = new List<GameObject>();
        }

        public override void Start()
        {
           

            holeCounter = 0;
            spawnDelay = 0;
            canSpawn = true;
        }

        public override void Update()
        {
            TrySpawnHole();

            DelaySpawnUpdate();

            DestroyUnwantedHoles();
        }

        private void TrySpawnHole()
        {
            if (holeChance.Next(0, 101) > 80 && canSpawn)
            {
                GameObject hole = new GameObject($"Hole_{holeCounter}");
                Position holePos = new Position(0f, 27f, 1f);
                hole.AddComponent(holePos);
                hole.AddComponent(new Hole(gameScene.FindGameObjectByName("Buggy")));
                hole.AddComponent(hole.GetComponent<Hole>().HoleSprite);
                gameScene.AddGameObject(hole);
                Holes.Add(hole);

                holeCounter++;

                canSpawn = false;
            }
        }

        private void DelaySpawnUpdate()
        {
            if (!canSpawn)
            {
                spawnDelay++;
                if (spawnDelay >= 11)
                {
                    spawnDelay = 0;
                    canSpawn = true;
                }
            }
        }

        private void DestroyUnwantedHoles()
        {
            for (int i = Holes.Count - 1; i >= 0; i--)
            {
                if (Holes[i].GetComponent<Position>().Pos.X >= gameScene.xdim - 1)
                {
                    gameScene.Destroy(Holes[i]);
                    Holes.Remove(Holes[i]);
                }
            }
        }
    }
}