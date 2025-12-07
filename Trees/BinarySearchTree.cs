using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinarySearchTree
    {
        public Node Root { get; private set; }

        public void Insert(int value)
        {
            Root = InsertRecursive(Root, value);
        }

        private Node InsertRecursive(Node current, int value)
        {
            if (current == null)
                return new Node(value);

            if (value < current.Value)
                current.Left = InsertRecursive(current.Left, value);
            else
                current.Right = InsertRecursive(current.Right, value);

            return current;
        }

        // In-order = Left → Node → Right (sorted output)
        public void InOrderTraversal()
        {
            TraverseInOrder(Root);
        }

        private void TraverseInOrder(Node node)
        {
            if (node == null) return;

            TraverseInOrder(node.Left);
            Console.Write(node.Value + " ");
            TraverseInOrder(node.Right);
        }
    }
}