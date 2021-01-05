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
                Console.WriteLine("\n");
                Console.WriteLine("  W       W  EEEEEEE L        CCCCC     OOOOO   MM     MM  EEEEEEE");
                Console.WriteLine("  W   W   W  E       L       C         O     O  M M   M M  E ");
                Console.WriteLine("  W  W W  W  EEEEE   L      C         O       O M  M M  M  EEEEE");
                Console.WriteLine("  W W   W W  E       L       C         O     O  M   M   M  E");
                Console.WriteLine("  WW     WW  EEEEEEE LLLLLLL  CCCCC     OOOOO   M       M  EEEEEEE");
                Console.WriteLine();
                Console.WriteLine("\tTTTTTTT    OOOOO");
                Console.WriteLine("\t   T      O     O");
                Console.WriteLine("\t   T     O       O");
                Console.WriteLine("\t   T      O     O");
                Console.WriteLine("\t   T       OOOOO");
                Console.WriteLine();
                Console.WriteLine("\t\tMM     MM    OOOOO     OOOOO    NN     N");
                Console.WriteLine("\t\tM M   M M   O     O   O     O   N N    N");
                Console.WriteLine("\t\tM  M M  M  O       O O       O  N  N   N");
                Console.WriteLine("\t\tM   M   M   O     O   O     O   N    N N");
                Console.WriteLine("\t\tM       M    OOOOO     OOOOO    N     NN");
                Console.WriteLine();
                Console.WriteLine("\t\t\tBBBBBBBB   U     U    GGGGG    GGGGG  Y      Y");
                Console.WriteLine("\t\t\t  B     B  U     U   G     G  G     G  Y    Y");
                Console.WriteLine("\t\t\t  BBBBBB   U     U  G        G          Y Y");
                Console.WriteLine("\t\t\t  B     B  U     U   G   GGG  G   GGG    Y");
                Console.WriteLine("\t\t\t  BBBBBB    UUUUU     GGGGG    GGGGG   YY");
                Console.WriteLine("\n");
                Console.WriteLine("\t\t\t\tPress Enter");
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
            DrawMenu();
        }
        /// <summary>
        /// Method to draw the Menu
        /// </summary>
        private void DrawMenu()
        {
            Console.Clear();
            Console.WriteLine(" ╔ ======== MENU ======== ╗");
            Console.WriteLine();
            Console.WriteLine("      1. START");
            Console.WriteLine("      2. INSTRUCTION");
            Console.WriteLine("      3. HIGHSCORE");
            Console.WriteLine("      4. CREDITS");
            Console.WriteLine("      5. EXIT");
            Console.WriteLine(" ╚ ====================== ╝");

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
                Console.WriteLine(" ╔ ================= INSTRUCTIONS =================== ╗");
                Console.WriteLine();
                Console.WriteLine("     The game objective is to make a good highscore");
                Console.WriteLine("    by jumping with the car.");
                Console.WriteLine("     Why jump? Well...The floor have spikes");
                Console.WriteLine("    so be carefull!");
                Console.WriteLine();
                Console.WriteLine("    -> To Jump press space");
                Console.WriteLine();
                Console.WriteLine("                RETURN (Press Enter)");
                Console.WriteLine(" ╚ ================================================== ╝");
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
                Console.WriteLine(" ╔ ======= HIGHSCORE ======= ╗");
                Console.WriteLine();
                Console.WriteLine("   ");
                Console.WriteLine("     RETURN (Press Enter)");
                Console.WriteLine(" ╚ ========================= ╝");
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
                Console.WriteLine(" ╔ ========= CREDITS ========= ╗");
                Console.WriteLine();
                Console.WriteLine("             MADE BY");
                Console.WriteLine();
                Console.WriteLine("        ♦ PEDRO OLIVEIRA ♦");
                Console.WriteLine("        ♦   SARA GAMA    ♦");
                Console.WriteLine();
                Console.WriteLine("      RETURN (Press Enter)");
                Console.WriteLine(" ╚ =========================== ╝");
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
        }

    }
}

/* // ╔ ═ ═ ╗
     // ╚  ═  ╝

   //CARRO ANDAR
   Console.WriteLine("  .-`---`-_   - - - ♦");
       Console.WriteLine("  '=0===0=-'");

       //CARRO PARADO
       Console.WriteLine("  .-`---`-_   - - -");
       Console.WriteLine("  '=O===O=-'");

       //CHAO / SPIKES
       Console.WriteLine(" ========▲▲▲===");
       Console.WriteLine(" ==============");

       //INIMIGO alt + pad4 ♦
       Console.WriteLine("♦");*/