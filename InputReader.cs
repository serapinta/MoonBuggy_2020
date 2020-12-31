using System;
using System.Threading;
using System.Collections.Concurrent;

namespace MoonBuggy_2020
{
    /// <summary>
    /// It reader the input given by the input
    /// </summary>
    public class InputReader
    {
        // Collection for the input information
        private BlockingCollection<ConsoleKey> input;

        // Variable for thread1
        Thread thread1;

        /// <summary>
        /// Constructer for the input reader
        /// </summary>
        public InputReader()
        {
            thread1 = new Thread(ReadKeys);

            thread1.Start();

            thread1.Join();
        }
        /// <summary>
        /// Method to Read press key
        /// </summary>
        private void ReadKeys()
        {
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                input.Add(key);
            } while (true);
        }

        /// <summary>
        /// Return the console.Key from the collection
        /// </summary>
        /// <returns>console.Key from the collection</returns>
        public ConsoleKey GetKey() => input.Take();
    }
}