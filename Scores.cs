using System;
using System.IO;
using System.Linq;

namespace MoonBuggy_2020
 {
     /// <summary>
     /// Method for loading the file
     /// </summary>
    class Scores
    {
        private Menu menu;

        public Scores(Menu menu)
        {
            this.menu = menu;
        }

        public struct HighScore
        {
            public string name;
            public long score;
        }

        /// <summary>
        /// Loads a file.
        /// </summary>
        /// <param name="path">The relative path of the file.</param>
        /// <returns>Returns the content of the file as a string.</returns>
        public string Load(string path)
        {
            StreamReader text = new StreamReader(path, System.Text.Encoding.UTF8);
            string Text = text.ReadToEnd();
            text.Close();
            return Text;
        }

        /// <summary>
        /// Used to save the leaderboard.
        /// </summary>
        /// <param name="list">The list to be saved.</param>
        public void SaveLeaderboard(HighScore[] list)
        {
            StreamWriter text = new StreamWriter("Highscore.txt");
            text.Write("");
            foreach (HighScore x in list)
            {
                string storage = "";
                storage += x.name + ";" + x.score;
                text.WriteLine(storage);
            }
            text.Close();
        }

        //Checks. whether a new high score was achieved.
        public void CheckHighScore()
        {
            HighScore[] highScores = new HighScore[10];
            for (int h = 0; h < 10; h++)
            {
                highScores[h].name = " ";
            }
            try
            {
                string[] cache = Load("Highscore.txt").Split('\n');
                string[] cache2 = new string[cache.Length * 2];
                int i = 0;
                foreach (string a in cache)
                {
                    if (a.Split(';').Length < 3)
                    {
                        cache2[i] = a.Split(';')[0];
                        i++;
                        cache2[i] = a.Split(';')[1];
                        i++;
                        if (i == 20) { break; }
                    }
                    else
                    {
                        cache2[i] = " ";
                        i++;
                        cache2[i] = "0";
                        i++;
                        if (i == 20) { break; }
                    }
                }
                i = 0;
                for (int x = 0; x < cache2.Length - 1; x++)
                {
                    highScores[i].name = cache2[x];
                    x++;
                    highScores[i].score = Convert.ToInt64(cache2[x]);
                    i++;
                }
            }
            catch
            {

            }
            highScores = SortBy(highScores);
            Console.Clear();
            int w = 1;
            for (int l = highScores.Length - 1; l >= 0; l--)
            {
                string storage = highScores[l].name;
                for (int n = 0; n < 20 - highScores[l].name.Length; n++)
                {
                    storage += " ";
                }
                Console.WriteLine(w + " " + storage + " " + highScores[l].score);
                w++;
            }

            if (menu.LastScore > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Your score: " + menu.LastScore);
                Console.ReadKey(true);
                Console.WriteLine();
                if (highScores.Any(f => f.score < menu.LastScore))
                {
                    string name = "";
                    do
                    {
                        Console.WriteLine("Please enter your name:");
                        name = Console.ReadLine();
                    } while (name == "");
                    highScores[0].name = name;
                    highScores[0].score = menu.LastScore;
                    highScores = SortBy(highScores);
                    SaveLeaderboard(highScores);
                }
            }
            else
            {
                Console.ReadKey();
            }
        }

        private HighScore[] SortBy(HighScore[] highScores)
        {
            bool sortedPair;
            //as long as not all pairs in each run are sorted, repeat alg.
            //->Proceed with the bubble sort
            do
            {
                sortedPair = true;
                for (int i = 0; i < highScores.Length - 1; i++)
                {
                    if (highScores[i].score > highScores[i + 1].score)
                    {
                        //exchange numbers (only one pair)
                        HighScore temp = highScores[i];
                        highScores[i] = highScores[i + 1];
                        highScores[i + 1] = temp;
                        //not sorted
                        sortedPair = false;
                    }
                }
            } while (!sortedPair);
            return highScores;
        }
    }
 }