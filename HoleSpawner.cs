using System;
using System.Collections.Generic;
using CoreGameEngine;


namespace MoonBuggy_2020
{
    class HoleSpawner : Component
    {
        Random holeChance = new Random();

        private Scene gameScene;

        private List<GameObject> holes;

        private int holeCounter;

        private int spawnDelay;
        private bool canSpawn;

        public HoleSpawner(Scene gameScene)
        {
            this.gameScene = gameScene;
        }

        public override void Start()
        {
            holes = new List<GameObject>();

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
                hole.AddComponent(new Hole());
                hole.AddComponent(hole.GetComponent<Hole>().HoleSprite);
                gameScene.AddGameObject(hole);
                holes.Add(hole);

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
            for (int i = holes.Count - 1; i >= 0; i--)
            {
                if (holes[i].GetComponent<Position>().Pos.X >= gameScene.xdim - 1)
                {
                    gameScene.Destroy(holes[i]);
                    holes.Remove(holes[i]);
                }
            }
        }
    }
}