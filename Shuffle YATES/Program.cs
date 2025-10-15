using System;
using System.Collections.Generic;
using System.IO;

namespace FisherYatesShuffleApp
{
    class Program
    {
        static void Main()
        {
            // File path (make sure "data.txt" is in the same directory as the executable)
            string filePath = "data.txt";

            // Check if file exists before proceeding
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: The file 'data.txt' could not be found.");
                return;
            }

            // Read all lines from the file into a List<string>
            List<string> items = new List<string>(File.ReadAllLines(filePath));

            Console.WriteLine("Original Order:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            // Shuffle the list using our own Fisher–Yates method
            ShuffleList(items);

            Console.WriteLine("\nShuffled Order:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Performs the Fisher–Yates Shuffle on a generic list.
        /// This algorithm guarantees a uniform shuffle — every possible order
        /// has an equal chance of being produced.
        /// </summary>
        static void ShuffleList<T>(IList<T> list)
        {
            // We use a single Random instance to ensure true randomness.
            Random random = new Random();

            // Start from the end of the list and move backward.
            for (int i = list.Count - 1; i > 0; i--)
            {
                // Pick a random index between 0 and i (inclusive).
                int j = random.Next(i + 1);

                // Swap the elements at positions i and j.
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;

                // Comment: This swap ensures that the current element (i)
                // is placed in a random position. Because each element only
                // gets swapped once, the result is an unbiased permutation.
            }
        }
    }
}
