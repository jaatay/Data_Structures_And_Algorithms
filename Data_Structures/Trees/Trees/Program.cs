using System;


namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			TestTree();
        }


		public static void TestTree() {
			BinaryTree newTree = new BinaryTree();

			Node nodeA = new Node(1);
			Node nodeB= new Node(2);
			Node nodeC = new Node(3);
			Node nodeD = new Node(4);
			Node nodeE = new Node(5);
			Node nodeF = new Node(6);

			nodeA.LeftChild = nodeB;
			nodeA.RightChild = nodeC;
			nodeB.LeftChild = nodeD;
			nodeB.RightChild = nodeE;
			nodeC.LeftChild = nodeF;

			Console.WriteLine("Preordered Binary Tree");
			newTree.PreOrder(nodeA);

			Console.WriteLine("Postordered Binary Tree");
			newTree.PostOrder(nodeA);

			Console.WriteLine("In-order Binary Tree");
			newTree.InOrder(nodeA);

			Console.WriteLine("Breadth First binary tree");
			Console.WriteLine("");
			newTree.BreadthFirst(nodeA);

			Console.WriteLine("");
			Console.WriteLine("Search Binary Tree");
			newTree.Search(nodeA, 6);
			newTree.Search(nodeA, 3);
			newTree.Search(nodeA, 10);
		}
    }
}
