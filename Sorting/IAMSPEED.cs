using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class IAMSPEED
    {
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                // Recursively sort elements before partition and after partition
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }


        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; // pivot
            int i = low - 1;       // index of smaller element

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    // swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (pivot)
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public void SPEEDONSCREEN() 
        {
            string text = File.ReadAllText(@"U:\Algorithms\Sorting\scores.txt");
            int[] arr = text
                 .Split(new[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            Console.WriteLine("Start:  " + string.Join(", ", arr));

            QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("Sorted: " + string.Join(", ", arr));
            Console.WriteLine("This is Quick Sort");


        }






    }
}
