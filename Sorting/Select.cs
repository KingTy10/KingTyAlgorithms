using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sorting
{
    public class Select
    {

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;

                    if (minIndex != i)
                    {
                        int temp = arr[i];
                        arr[i] = arr[minIndex];
                        arr[minIndex] = temp;
                    }
                }

            }
        }


        public void SelectToScreen() 
        {
            string text = File.ReadAllText(@"U:\Algorithms\Sorting\scores.txt");
            int[] arr = text
                 .Split(new[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            Console.WriteLine($"Start: {string.Join(", ", arr)}");
            SelectionSort(arr);
            Console.WriteLine($"Start: {string.Join(", ", arr)}");
            Console.WriteLine("this is Selection sort");




        }
    }
}
