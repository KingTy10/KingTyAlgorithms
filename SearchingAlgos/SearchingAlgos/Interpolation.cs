using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgos
{
    public class Interpolation
    {

        public static int InterpolationSearchOfHORRORS(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high && target >= arr[low] && target <= arr[high])
            {
                // Estimate the position of the target element 
                int pos = low + ((target - arr[low]) * (high - low)) /
                                 (arr[high] - arr[low]);

                Console.WriteLine($"Checking index {pos}, value {arr[pos]}");

                if (arr[pos] == target)
                    return pos;

                if (arr[pos] < target)
                    low = pos + 1;
                else
                    high = pos - 1;
            }

            return -1; // Not found
        }




















        public void PutInterpolationOnThePhone() 
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

            Array.Sort(scores);

            Console.WriteLine("Scores: " + string.Join(", ", scores));


            Console.Write("Enter a number to search for: ");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine($"Searching for: {target}");

            int index = InterpolationSearchOfHORRORS(scores, target);

            if (index != -1)
                Console.WriteLine($"Found {target} at index {index}");
            else
                Console.WriteLine($"{target} not found in array.");

        }
        #region 
        /**
         *FUNCTION LinearInterpolate(y1, y2, mu):
        // y1: the starting value
         // y2: the ending value
         // mu: the interpolation factor, between 0 and 1

            RETURN (y1 * (1 - mu)) + (y2 * mu)
            END FUNCTION
         *
         *
         *
         *
         ***/


        #endregion


    }
}
