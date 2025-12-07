using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\tyron\Downloads\SQLBS\Trees\scores.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: data file not found.");
                return;
            }

            // 1. Loading the data
            int[] numbers = File.ReadAllLines(filePath)
                                .Where(line => !string.IsNullOrWhiteSpace(line))
                                .Select(int.Parse)
                                .ToArray();

            Console.WriteLine("Raw Data:");
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();

           
            int[] sorted = numbers.OrderBy(n => n).ToArray();

            Console.WriteLine("Sorted Data:");
            Console.WriteLine(string.Join(", ", sorted));
            Console.WriteLine();

            BinarySearchTree bst = new BinarySearchTree();
            foreach (int value in sorted)
            {
                bst.Insert(value);
            }

            Console.WriteLine("Tree (In-Order Traversal):");
            bst.InOrderTraversal();
            Console.WriteLine();
        }
    }
}