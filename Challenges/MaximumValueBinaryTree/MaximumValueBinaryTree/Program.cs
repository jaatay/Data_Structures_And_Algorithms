using System;

namespace MaximumValueBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The larget value in the tree is:");
			TestTree();
			Console.WriteLine("Press any key to exit");
			Console.ReadLine();
        }

		/// <summary>
		/// method to instantiate a tree and call the Max Value function
		/// </summary>
		public static void TestTree()
		{
			BinaryTree thisTree = new BinaryTree();

			Node node1 = new Node(20);
			Node node2 = new Node(5);
			Node node3 = new Node(4100);
			Node node4 = new Node(15);
			Node node5 = new Node(13);
			Node node6 = new Node(6);

			node1.LeftChild = node2;
			node1.RightChild = node3;
			node2.LeftChild = node4;
			node2.RightChild = node5;
			node5.LeftChild = node6;

			thisTree.MaxTree(node1);
		}
    }
}
