using INCLASSGRAPHSAHHHPAIN;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a graph with 5 vertices
        Graph g = new Graph(5);

        // Add some edges
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(3, 4);
        g.AddEdge(1, 2);

        // Print graph structure
        Console.WriteLine(g.ToString());

        // Get the dets
        Console.WriteLine("Number of Vertices: " + g.V());
        Console.WriteLine("Number of Edges: " + g.E());
        Console.WriteLine("Max Degree: " + g.MaxDegree());
        Console.WriteLine("Average Degree: " + g.AverageDegree());
        Console.WriteLine("Number of Self Loops: " + g.NumberOfSelfLoops());

        
        Console.Write("Adjacency for vertex 0: ");
        foreach (int v in g.Adj(0))
        {
            Console.Write(v + " ");
        }
        Console.WriteLine();
    }
}

