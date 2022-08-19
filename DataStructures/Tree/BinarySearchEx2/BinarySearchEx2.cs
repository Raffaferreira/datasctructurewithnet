using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree.BinarySearchEx2
{
    public class BinarySearchEx2
    {
        public void RunExample2()
        {
            Node? root = null;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int x = rnd.Next(0, 100);
                Node rootCreated = new Node(x);

                if (root == null)
                {
                    Console.WriteLine("Setting " + rootCreated.label + " to the root");
                    root = rootCreated;
                }
                else
                {
                    rootCreated.AddNode(root);
                }
            }
        }
    }

    public class Node
    {
        public int label;
        public Node? left;
        public Node? right;

        public Node(int data)
        {
            label = data;
            left = null;
            right = null;
        }

        public void AddNode(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("Could not call 'AddNode' because root was null");
                // root = rootCreated;
                return;
            }
            else if (root.label == label)
            {
                Console.WriteLine("Duplicate values not allowed");
                return;
            }
            else if (label < root.label)
            {
                //go left
                if (root.left != null)
                {
                    AddNode(root.left);
                }
                else
                {
                    Console.WriteLine("Added " + label + " to the left of " + root.label);
                    root.left = this;
                }
            }
            else if (label > root.label)
            {
                //go right
                if (root.right != null)
                {
                    AddNode(root.right);
                }
                else
                {
                    Console.WriteLine("Added " + label + " to the right of " + root.label);
                    root.right = this;
                }
            }
        }
    }
}
