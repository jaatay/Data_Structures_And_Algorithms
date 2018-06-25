using System;


namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			TestBinaryTree();
			TestBinarySearchTree();
        }


		public static void TestBinaryTree() {
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

		public static void TestBinarySearchTree()
		{
			BinarySearchTree searchTree = new BinarySearchTree();

			Node nodeA = new Node(8);
			Node nodeB = new Node(3);
			Node nodeC = new Node(5);
			Node nodeD = new Node(7);
			Node nodeE = new Node(9);

			Node nodeF = new Node(4);
			Node nodeG = new Node(10);

			searchTree.Add(nodeA, nodeB);
			searchTree.Add(nodeA, nodeC);
			searchTree.Add(nodeA, nodeD);
			searchTree.Add(nodeA, nodeE);

			Console.WriteLine("Adding Less node");
			searchTree.Add(nodeA, nodeF);

			Console.WriteLine("Adding More node");
			searchTree.Add(nodeA, nodeG);

			Console.WriteLine("Finding Node");
			searchTree.Search(nodeA, 7);
		}
    }

}
