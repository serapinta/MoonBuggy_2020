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
            Menu menu = new Menu();
            menu.DrawIntro();
        }
    }
}