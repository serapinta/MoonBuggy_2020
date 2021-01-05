
using System;
using CoreGameEngine;


namespace MoonBuggy_2020
{
    public class Hole : Component
    {

        private Position position;
        private GameObject buggy;

        public ConsoleSprite HoleSprite { get; private set; }

        private char[,] holeSprite =
            {
                {'^', '^'}

            };

        public Hole(GameObject buggy)
        {
            HoleSprite = new ConsoleSprite(holeSprite, ConsoleColor.White, ConsoleColor.DarkGray);
            this.buggy = buggy;
        }

        public override void Update()
        {
            position = ParentGameObject.GetComponent<Position>();
            KillPlayer();
            Animate();
        }

        public void Animate()
        {
            position.Pos = new Vector3(position.Pos.X + 1, position.Pos.Y, position.Pos.Z);
        }

        private void KillPlayer()
        {
            if (position.Pos.X >= buggy.GetComponent<Position>().Pos.X && position.Pos.X <= buggy.GetComponent<Position>().Pos.X + 7 && position.Pos.Y <= buggy.GetComponent<Position>().Pos.Y +1)
            {
                buggy.GetComponent<Buggy>().Die();
            }
        }

    }
}
