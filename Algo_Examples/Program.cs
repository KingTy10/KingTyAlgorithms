using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetPow(3, 2));
            Console.ReadLine();


        }
        static int GetPow(int baseNum, int powNum) 
        {
            int result = 1;  // O(1) → Constant time operation



            // This loop runs "powNum" times
            // Each iteration does a single multiplication (O(1))
            for (int i= 0; i< powNum; i++) 
            {
                result = result * baseNum;// O(1) per iteration




            }

            // Total time complexity:
            // Loop runs 'powNum' times → O(powNum)
            // Multiplication inside loop is O(1), so total = O(powNum)

            return result;
        
        
        }
        //O(n) 
        bool HasDup(int[] arr)
        {
            //for those in the back dup means duplicate 
            //out loop runs "arr.length" times which is O(n)
            for(int i = 0; i < arr.Length; i++)
            {
                // Inner loop runs fewer times each iteration, but in the worst case
                // it will can run up to "arr.Length - 1" times aka O(n)
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j]) 
                    {
                        return true;// has dup which would make it exit early 
                    }
                }
            }
            return false;// no dup 
        }
        //O(n^2) 



            
        int getfirstelement(int[] arr) 
        {
            // Accessing an element by index in an array is O(1) aka constant time
            return arr[0];
        }
        //O(1) getting a single element from an array does not depend on the array size so it take the same time regardless of how big it is. 



    }
}
