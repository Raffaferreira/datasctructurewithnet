using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class No
    {
        public int Value { get; set; }
        public No? Left { get; set; }
        public No? Right { get; set; }

        public No(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public void AddNode(No root)
        {
            if (root == null)
            {
                Console.WriteLine("Could not call 'AddNode' because root was null");
                return;
            }
            else if (root.Value == Value)
            {
                Console.WriteLine("Duplicate values not allowed");
                return;
            }

            else if (Value < root.Value)
            {
                //go left
                if (root.Left != null)
                {
                    AddNode(root.Left);
                }
                else
                {
                    Console.WriteLine("Added " + Value + " to the left of " + root.Value);
                    root.Left = this;
                }
            }
            else if (Value > root.Left!.Value)
            {
                //go right
                if (root.Right != null)
                {
                    AddNode(root.Right);
                }
                else
                {
                    Console.WriteLine("Added " + Value + " to the right of " + root.Value);
                    root.Right = this;
                }
            }
        }
    }
}
