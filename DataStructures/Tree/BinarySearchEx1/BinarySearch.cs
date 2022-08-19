using System.Diagnostics;

namespace DataStructures.Tree.BinarySearchEx1
{
    /// <summary>
    /// 
    /// A Binary Search Tree is a binary tree with search properties where
    /// elements in the left sub-tree are less than to the root and elements
    /// in the right sub-tree are greater than to the root.
    /// 
    /// This <c>[Binary Search Tree]</c> is the first example of trees.
    /// 
    /// <example>
    ///  <code>
    ///    Tree bst = new();
    ///    int SIZE = 100;
    ///    int[] array = new int[SIZE];
    ///    
    ///    bst.AddNodeIntheTree(root);
    ///  </code>
    /// </example>
    /// 
    /// </summary>
    public class BinarySearch
    {
        public static void RunBinarySearchTree()
        {
            Node? root = null;
            Tree bst = new();
            int SIZE = 1000;
            int[] array = new int[SIZE];

            Console.WriteLine("Generating random array with {0} values...", SIZE);

            Random random = new Random();

            Stopwatch watch = Stopwatch.StartNew();

            for (int i = 0; i < SIZE; i++)
            {
                array[i] = random.Next(0, 10000);
            }

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();
            Console.WriteLine("Filling the tree with {0} nodes...", SIZE);

            watch = Stopwatch.StartNew();

            for (int i = 0; i < SIZE; i++)
            {
                root = bst.AddNode(root!, array[i]);
                bst.AddNodeIntheTree(root);
            }

            var obj = bst.MinimumElement(root!);

            Console.WriteLine($" Node value of {obj.Item1} founded and there was {obj.Item2} attempting until be discovered");

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();
            Console.WriteLine("Traversing all {0} nodes in tree...", SIZE);

            watch = Stopwatch.StartNew();

            bst.Traverse(root!);

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();

            Console.ReadKey();
        }
    }

    public class Tree
    {
        public int countSearches { get; set; }

        private List<Node> _nodes;
        public List<Node> Nodes
        {
            get { return _nodes; }
            set { _nodes = value; }
        }

        public Tree()
        {
            _nodes = new List<Node>();
        }

        public void AddNodeIntheTree(Node node)
        {
            _nodes!.Add(node);
        }

        public Node AddNode(Node root, int valueInputed)
        {
            if (root == null)
            {
                root = new Node();
                root.Value = valueInputed;
            }
            else if (root.Value == valueInputed)
            {
                Console.WriteLine("Duplicate values not allowed");
            }

            if (valueInputed < root.Value)
            {
                root.Left = AddNode(root.Left!, valueInputed);
                Console.WriteLine($"Added {valueInputed} to the left of {root.Value}");
            }
            else if (valueInputed > root.Value)
            {
                root.Right = AddNode(root.Right!, valueInputed);
                Console.WriteLine($"Added {valueInputed} to the right of {root.Value}");
            }

            return root;
        }

        public (object, int) MinimumElement(Node root)
        {
            var current = root;
            countSearches++;

            if (current.Left == null)
            {
                return (current.Value, countSearches);
            }

            return MinimumElement(current.Left);
        }

        public (object, int) MaximumElement(Node root)
        {
            var current = root;
            countSearches++;

            if (current.Right == null)
            {
                return (current.Value, countSearches);
            }

            return MaximumElement(current.Right);
        }

        public void Traverse(Node root)
        {
            if (root == null)
            {
                return;
            }

            Traverse(root.Left!);
            Traverse(root.Right!);
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }
    }
}
