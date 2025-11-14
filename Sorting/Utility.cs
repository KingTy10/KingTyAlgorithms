using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Utility : UTIL
    {

        public void Clearnextsort()
        {
            Console.WriteLine("Press enter to clear and go onto the next sort ");
            Console.Read();
            Console.Clear();
            Console.WriteLine("clear!");
            Console.Read();
            Console.Clear();


        }

        public void ParseText() 
        {

            string text = File.ReadAllText(@"U:\Algorithms\Sorting\scores.txt");
            int[] arr = text
                 .Split(new[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();



        }
    }
}
