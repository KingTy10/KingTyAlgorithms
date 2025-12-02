using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgos
{
    public class Linear
    {

        public static int LinearSearchOfPain(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i; // return the index where the target was found
                }
            }

            return -1; // return -1 if not found
        }

        public void printTheLinear()
        {
            string filePath = @"U:\Algorithms\Sorting\scores.txt"; 

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: scores.txt not found.");
                return;
            }

           //setting up the file to be read through 
            int[] scores = File.ReadAllLines(filePath)
                               .Select(int.Parse)
                               .ToArray();

            Console.WriteLine("Scores: " + string.Join(", ", scores));

            
            Console.Write("Enter a number to search for: ");
            int target = int.Parse(Console.ReadLine());
            //Calling the search 
            int index = LinearSearchOfPain(scores, target);
            if (index != -1)
                Console.WriteLine($"Found {target} at index {index}.");
            else
                Console.WriteLine($"{target} was not found in the list.");
                Console.WriteLine($"{target} was not found in the list.");

        }
        //Pseudocode code of a linear algo 
        #region 
        /**
         * Begin
1) Set i = 0
2) If Li = T, go to line 4
3) Increase i by 1 and go to line 2
4) If n  greater then return iEnd
         * 
         * 
         * 
         * 
         **/
        #endregion
    }
}
