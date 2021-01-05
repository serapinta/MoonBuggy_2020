using System;

namespace MoonBuggy_2020
{
    class Program
    {
        /// <summary>
        /// Method to enter the Intro og the game
        /// </summary>
        /// <param name="args">call parameters</param>
        static void Main(string[] args)
        {
            Console.WindowHeight = 30;
            Console.WindowWidth = 150;
            Menu menu = new Menu();
            menu.DrawIntro();
        }
    }
}