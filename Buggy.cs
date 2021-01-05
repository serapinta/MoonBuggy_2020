using System;
using CoreGameEngine;

namespace MoonBuggy_2020
{
  /// <summary>
  ///   A script which controls the player, implemented as a component
  /// </summary>
    public class Buggy : Component
    {
        private KeyObserver keyObserver;
        private Position position;

        private float jumpCounter = 6;
        private bool isJumping;
        private bool isFalling;

        private char[,] buggySprite =
            {
                { ' ','\''},
                { '_','-'},
                { '-','='},
                { '´','0'},
                { '-','='},
                { '´','0'},
                { '-','='},
                { '.','\''}

            };

        public ConsoleSprite BuggySprite { get; private set; }

        public Buggy()
        {
            BuggySprite = new ConsoleSprite(buggySprite, ConsoleColor.White, ConsoleColor.DarkGray);
        }

        // Initialize player
        public override void Start()
        {
            keyObserver = ParentGameObject.GetComponent<KeyObserver>();
            position = ParentGameObject.GetComponent<Position>();
        }

        // Update Buggy in the current frame
        public override void Update()
        {
            // Get player position
            float y = position.Pos.Y;

            // Check what keys were pressed and update position accordingly
            foreach (ConsoleKey key in keyObserver.GetCurrentKeys())
            {
                switch (key)
                {
                    case ConsoleKey.Spacebar:
                        if (!isFalling && !isJumping)
                        {
                            isJumping = true;
                            DoJump(ref y);
                        }
                        break;
                }
            }

            if (isJumping || isFalling) DoJump(ref y);

            // Update player position
            position.Pos = new Vector3(position.Pos.X, y, position.Pos.Z);
        }

        private void DoJump(ref float y)
        {
            if (jumpCounter != 0 && isJumping)
            {
                y--;
                jumpCounter--;
            }
            else if (jumpCounter != 6 && isFalling)
            {
                y+=0.5f;
                jumpCounter+=0.5f;
            }

            if (jumpCounter <= 0)
            {
                isJumping = false;
                isFalling = true;
            }
            else if (jumpCounter >= 6)
            {
                isFalling = false;
            }
        }


       public void Die()
        {
            ParentScene.Terminate();
        } 
    }
}