using System;

namespace MoonBuggy_2020
{
    /// <summary>
    /// Class draws the Intro and the Menu of the game
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Method that draws the Intro of the game
        /// </summary>
        public void DrawIntro()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n");
                Console.WriteLine("\t\t\t\t\tW       W  EEEEEEE L        CCCCC   OOOOO   MM     MM  EEEEEEE");
                Console.WriteLine("\t\t\t\t\tW   W   W  E       L       C       O     O  M M   M M  E");
                Console.WriteLine("\t\t\t\t\tW  W W  W  EEEEE   L      C       O       O M  M M  M  EEEEE");
                Console.WriteLine("\t\t\t\t\tW W   W W  E       L       C       O     O  M   M   M  E");
                Console.WriteLine("\t\t\t\t\tWW     WW  EEEEEEE LLLLLLL  CCCCC   OOOOO   M       M  EEEEEEE");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\tTTTTTTT    OOOOO");
                Console.WriteLine("\t\t\t\t\t\t   T      O     O");
                Console.WriteLine("\t\t\t\t\t\t   T     O       O");
                Console.WriteLine("\t\t\t\t\t\t   T      O     O");
                Console.WriteLine("\t\t\t\t\t\t   T       OOOOO");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\t\tMM     MM    OOOOO     OOOOO    NN     N");
                Console.WriteLine("\t\t\t\t\t\t\tM M   M M   O     O   O     O   N N    N");
                Console.WriteLine("\t\t\t\t\t\t\tM  M M  M  O       O O       O  N  N   N");
                Console.WriteLine("\t\t\t\t\t\t\tM   M   M   O     O   O     O   N    N N");
                Console.WriteLine("\t\t\t\t\t\t\tM       M    OOOOO     OOOOO    N     NN");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\t\t\tBBBBBBBB   U     U    GGGGG    GGGGG   Y      Y");
                Console.WriteLine("\t\t\t\t\t\t\t\t  B     B  U     U   G     G  G     G   Y    Y");
                Console.WriteLine("\t\t\t\t\t\t\t\t  BBBBBB   U     U  G        G           Y Y");
                Console.WriteLine("\t\t\t\t\t\t\t\t  B     B  U     U   G   GGG  G   GGG    Y");
                Console.WriteLine("\t\t\t\t\t\t\t\t  BBBBBB    UUUUU     GGGGG    GGGGG   YY");
                Console.WriteLine("\n");
                Console.WriteLine("\t\t\t\t\t\t\t\t\tPress Enter");
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
            DrawMenu();
        }
        /// <summary>
        /// Method to draw the Menu
        /// </summary>
        private void DrawMenu()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t\t\t ╔ ========== MENU ========== ╗");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t\t       1. START");
            Console.WriteLine("\t\t\t\t\t\t\t       2. INSTRUCTION");
            Console.WriteLine("\t\t\t\t\t\t\t       3. HIGHSCORE");
            Console.WriteLine("\t\t\t\t\t\t\t       4. CREDITS");
            Console.WriteLine("\t\t\t\t\t\t\t       5. EXIT");
            Console.WriteLine("\t\t\t\t\t\t\t ╚ ========================== ╝");

            MenuInput(Console.ReadKey().Key);
        }

        /// <summary>
        /// Method to give the input for the DrawMenu method
        /// </summary>
        /// <param name="key">Input for the pressed keys</param>
        private void MenuInput(ConsoleKey key)
        {
            // Start the game
            if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
            {

            }
            else if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
            {
                Instructions();
            }
            else if (key == ConsoleKey.D3 || key == ConsoleKey.NumPad3)
            {
                Scores();
            }
            else if (key == ConsoleKey.D4 || key == ConsoleKey.NumPad4)
            {
                Credits();
            }
            else if (key == ConsoleKey.D5 || key == ConsoleKey.NumPad5)
            {
                Environment.Exit(0);
            }
            DrawMenu();
        }

        /// <summary>
        /// Method to give the information about the game
        /// </summary>
        private void Instructions()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("\t\t\t\t\t\t╔ =================== INSTRUCTIONS =================== ╗");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\t     The game objective is to make a good highscore");
                Console.WriteLine("\t\t\t\t\t\t     by jumping with the car.");
                Console.WriteLine("\t\t\t\t\t\t     Why jump? Well...The floor have spikes");
                Console.WriteLine("\t\t\t\t\t\t     so be carefull!");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\t    -> To Jump press space");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\t               - Press ENTER to RETURN - ");
                Console.WriteLine("\t\t\t\t\t\t╚ ==================================================== ╝");
            } while (Console.ReadKey().Key != ConsoleKey.Enter);

        }

        /// <summary>
        /// Method to give the best values of each game
        /// </summary>
        private void Scores()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("\t\t\t\t\t\t\t╔ ========== HIGHSCORE ========== ╗");
                Console.WriteLine();
                Console.WriteLine("   ");
                Console.WriteLine("\t\t\t\t\t\t\t      - Press ENTER to RETURN -");
                Console.WriteLine("\t\t\t\t\t\t\t╚ =============================== ╝");
            } while (Console.ReadKey().Key != ConsoleKey.Enter);


        }

        /// <summary>
        /// Method to give the information of who made the project
        /// </summary>
        private void Credits()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("\t\t\t\t\t\t\t╔ ========== CREDITS ========== ╗");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\t\t             MADE BY");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\t\t        ♦ PEDRO OLIVEIRA ♦");
                Console.WriteLine("\t\t\t\t\t\t\t        ♦   SARA GAMA    ♦");
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\t\t    - Press ENTER to RETURN -");
                Console.WriteLine("\t\t\t\t\t\t\t╚ ============================== ╝");
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
        }

    }
}