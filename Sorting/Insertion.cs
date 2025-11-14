using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Insertion
    {
       public void InsetSort(int[] a) 
       { 
        int n = a.Length;

            for (int i = 1; i < n; i++)
            { 
                int key = a[i];

                int j = i - 1;

                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j--;


                }
                a[ j +1] = key;



            }
            
            
        
        
       }


        public void RunSortAlgo() 
        {
            /* int[] arr = { 5, 2, 4, 6, 1, 3 };
             Console.WriteLine($"Start: {string.Join(", ", arr)}");
             InsetSort(arr);
             Console.WriteLine($"Sorted: {string.Join(", ", arr)}");*/
         
            string text = File.ReadAllText(@"U:\Algorithms\Sorting\scores.txt");

            int[] arr = text
            .Split(new[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
             Console.WriteLine($"Start: {string.Join(", ", arr)}");
             InsetSort(arr);
             Console.WriteLine($"Sorted: {string.Join(", ", arr)}");
            Console.WriteLine("This is insertion sort");
        }

    }
}
