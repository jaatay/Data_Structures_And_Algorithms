using System;
using System.Collections;



namespace Trees
{

	public class BinaryTree


	{
		public void PreOrder(Node node)
		{
			Console.WriteLine(node.Value);

			if(node.LeftChild != null)
			{
				PreOrder(node.Leftchild);
			}

			if(node.RightChild != null)
			{
				PreOrder(node.RightChild);
			}
		}

		public void InOrder(Node node)
		{
			if(node.LeftChild != null)
			{
				InOrder(node.LeftChild);
			}

			Console.WriteLine(node.Value);

			if(node.RightChild != null)
			{
				InOrder(node.RightChild);
			}

		}

		public void PostOrder(Node node)
		{
			if(node.LeftChild != null)
			{
				PostOrder(node.Leftchild);
			}

			if(node.RightChild != null)
			{
				PostOrder(node.RightChild);
			}

			Console.WriteLine(node.Value);
		}

		public void BreadthFirst(Node node)
		{
			Queue<Node> breadth = new Queue<Node><Node>();
			breadth.Enqueue(root);

		}

		public void Search(Node root, int value)
		{

		}
	}
}
