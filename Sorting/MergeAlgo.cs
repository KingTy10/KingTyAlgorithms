using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class MergeAlgo
    {
        public void MergeSort(int[] array, int left, int right) 
        {
            if (left < right)
            {
                int middle =(left +right)/2;


                MergeSort(array, left, middle);

                MergeSort(array, middle + 1, right);
                
                Merge(array, left, middle, right);
            }
        }

        public void Merge(int[] array, int left, int middle, int right)
        {
            int subarray1 = middle - left + 1;
            int subarray2 = right - middle;

            int[] leftArray = new int[subarray1];

            int[] rightArray = new int[subarray2];

            for (int i = 0; i < subarray1; i++) 
            {
                leftArray[i] = array[left + 1]; 
            }
            for (int j = 0; j < subarray2; j++) 
            {
                rightArray[j] = array[middle + 1 + j];
            }

            int IndexLeft = 0, iR = 0, k = left;

            while (IndexLeft < subarray1 && iR < subarray2)
            {
                if (leftArray[IndexLeft] <= rightArray[iR])
                {
                    array[k] = leftArray[IndexLeft];
                    IndexLeft++;
                }
                else
                {
                    array[k] = rightArray[iR];
                    iR++;
                }
                k++;
            }

            while (IndexLeft < subarray1)
            {
                array[k] = leftArray[IndexLeft];
                IndexLeft++;
                k++;
            }

            while (iR < subarray2)
            {
                array[k] = rightArray[iR];
                iR++;
                k++;
            }
        }
        public void MergeAlgoPrint()
        {
            string filePath = @"U:\Algorithms\Sorting\scores.txt";
            

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: scores.txt not found.");
                return;
            }

            
            int[] scores = File.ReadAllLines(filePath)
                               .Select(int.Parse)
                               .ToArray();
         
            Console.WriteLine("Start: " + string.Join(", ", scores));

      
            MergeSort(scores, 0, scores.Length - 1);

            Console.WriteLine("Sorted: " + string.Join(", ", scores));
            Console.WriteLine("here is the merge sort");




        }

    }


}

