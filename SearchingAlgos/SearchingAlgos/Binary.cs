using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgos
{
    public class Binary
    {


        public static int BinarySearchOfHURT(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                    return mid; // target found yipppee!!!!

                if (arr[mid] < target)
                    left = mid + 1;  // search right side
                else
                    right = mid - 1; // search left side
            }

            return -1; // not found it should return a -1 
        }












        public void CallingBinarySearch() 
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
            //Ringing up the search 
            int index = BinarySearchOfHURT(scores, target);

            if (index != -1)
                Console.WriteLine($"Found {target} at index {index}.");
            else
                Console.WriteLine($"{target} was not found in the list.");


        }


        #region 
        /**
         * function binary_search(A, n, T) is
    L := 0
    R := n − 1
    while L ≤ R do
        m := floor((L + R) / 2)
        if A[m] < T then
            L := m + 1
        else if A[m] > T then
            R := m − 1
        else:
            return m
    return unsuccessful
         * 
         * 
         * 
         * 
         * **/



        #endregion

    }
}
