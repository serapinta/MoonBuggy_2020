// using System.IO;

// namespace MoonBuggy_2020
// {
//     /// <summary>
//     /// Method for loading the file
//     /// </summary>
//     public class Scores
//     {
//         static public string Load(string path)
//         {
//             StreamReader text = new StreamReader(path, System.Text.Encoding.UTF8);
//             string text = text.ReadToEnd
//             text.Close();
//             return Text;
//         }

//         /// <summary>
//         /// Method to save the best leaderboard
//         /// </summary>
//         /// <param name="list">to be saved</param>
//         static public void SaveLeaderBoard(Level.HighScores[] list)
//         {
//             StreamWrite text = new StreamWriter("Highscores.txt")
//             text.Write("");
//             foreach (Level.HighScores x in list)
//             {
//                 string storage = "";
//                 storage += x.name + ";" + x.score;
//                 text.WriteLine(storage);
//             }
//             text.Close();
//         }
//     }
// }