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
            int result = 1; 


            for(int i= 0; i< powNum; i++) 
            {
                result = result * baseNum;

            
            
            
            }


            return result;
        
        
        }
        //O(n) 
        bool HasDup(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j]) 
                    {
                        return true;// has dup 
                    }
                }
            }
            return false;// no dup 
        }
        //O(n^2) 
            
        int getfirstelement(int[] arr) 
        {
            return arr[0];
        }
        //O(1) 



    }
}
