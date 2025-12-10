using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INCLASSGRAPHSAHHHPAIN
{
    internal class Graph
    {
        private readonly int _V;              
        private int _E;                       
        private bool[,] adjMatrix;            

        public Graph(int V)
        {
            _V = V;
            _E = 0;
            adjMatrix = new bool[V, V];
        }

     
        public int V()
        {
            return _V;
        }

    
        public int E()
        {
            return _E;
        }

  
        public void AddEdge(int v, int w)
        {
            if (!adjMatrix[v, w])
            {
                adjMatrix[v, w] = true;
                adjMatrix[w, v] = true;
                _E++;
            }
        }

      
        public IEnumerable<int> Adj(int v)
        {
            for (int i = 0; i < _V; i++)
            {
                if (adjMatrix[v, i])
                    yield return i;
            }
        }

     
        public int Degree(int v)
        {
            int count = 0;
            for (int i = 0; i < _V; i++)
            {
                if (adjMatrix[v, i])
                    count++;
            }
            return count;
        }

    
        public int MaxDegree()
        {
            int max = 0;
            for (int v = 0; v < _V; v++)
            {
                int d = Degree(v);
                if (d > max)
                    max = d;
            }
            return max;
        }

      
        public float AverageDegree()
        {
            return (float)(2.0 * _E) / _V;
        }

 
        public int NumberOfSelfLoops()
        {
            int count = 0;
            for (int v = 0; v < _V; v++)
            {
                if (adjMatrix[v, v])
                    count++;
            }
            return count;
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine($"{_V} vertices, {_E} edges");
            for (int v = 0; v < _V; v++)
            {
                sb.Append(v + ": ");
                foreach (int w in Adj(v))
                {
                    sb.Append(w + " ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
