
using System;
using CoreGameEngine;


namespace MoonBuggy_2020
{
    public class Hole : Component
    {

       private Position position;

        public ConsoleSprite HoleSprite { get; private set; }

        private char[,] holeSprite =
            {
                {'^', '^'}

            };

        public Hole()
        {
            HoleSprite = new ConsoleSprite(holeSprite, ConsoleColor.White, ConsoleColor.DarkGray);
            
        }

        public override void Update()
        {
            position = ParentGameObject.GetComponent<Position>();
            Animate();
        }

        public void Animate()
        {
            position.Pos = new Vector3(position.Pos.X + 1, position.Pos.Y, position.Pos.Z);
        }
    }
}
