using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Heap
    {
          static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;        
            int left = 2 * i + 1;     
            int right = 2 * i + 2;    

          
            if (left < n && arr[left] > arr[largest])
                largest = left;

            
            if (right < n && arr[right] > arr[largest])
                largest = right;

       
            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                Heapify(arr, n, largest); 
            }
        }
        static void HeapSort(int[] arr)
        {
            int n = arr.Length;

          
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

     
            for (int i = n - 1; i >= 0; i--)
            {
             
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

            
                Heapify(arr, i, 0);
            }
        }

        public void HeapingItToScreen() 
        {

            string text = File.ReadAllText(@"U:\Algorithms\Sorting\scores.txt");
            int[] arr = text
                 .Split(new[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray(); 

            Console.WriteLine("Start:  " + string.Join(", ", arr));

            HeapSort(arr);

            Console.WriteLine("Sorted: " + string.Join(", ", arr));
            Console.WriteLine("This is Heap Sort");



        }
    }
}