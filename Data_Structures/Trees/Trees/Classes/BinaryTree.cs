using System;
using System.Collections.Generic;
using System.Text;


namespace Trees
{

	public class BinaryTree
	{
		/// <summary>
		/// method to order a binary tree 
		/// </summary>
		/// <param name="node">parmeter to set the root node where the traversal begins</param>
		public void PreOrder(Node node)
		{
			Console.WriteLine(node.Value);

			if(node.LeftChild != null)
			{
				PreOrder(node.LeftChild);
			}

			if(node.RightChild != null)
			{
				PreOrder(node.RightChild);
			}
		}

		/// <summary>
		/// method to traverse a tree using the In Order technique
		/// </summary>
		/// <param name="node">input node to set as root of traversal</param>
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

		/// <summary>
		/// method to traverse using the post order technique
		/// </summary>
		/// <param name="node">input node to set as root of traversal</param>
		public void PostOrder(Node node)
		{
			if(node.LeftChild != null)
			{
				PostOrder(node.LeftChild);
			}

			if(node.RightChild != null)
			{
				PostOrder(node.RightChild);
			}

			Console.WriteLine(node.Value);
		}

		/// <summary>
		/// method to traverse using Bread-First
		/// </summary>
		/// <param name="node">input node to set as root of traversal</param>
		public void BreadthFirst(Node node)
		{
			Queue<Node> breadth = new Queue<Node>();
			breadth.Enqueue(node);

			while(breadth.TryPeek(out node))
			{
				Node front = breadth.Dequeue();
				Console.Write(front.Value);

				if(front.LeftChild != null)
				{
					breadth.Enqueue(front.LeftChild);
				}
				if(front.RightChild != null)
				{
					breadth.Enqueue(front.RightChild);
				}
			}

		}

		/// <summary>
		/// method to search for a node in a binary tree
		/// </summary>
		/// <param name="node">input node to set as root of traversal</param>
		/// <param name="value">input value of node being searched for</param>
		/// <returns>boolean value of true if node is found, false if not found</returns>
		public bool Search(Node node, int value)
		{
			Queue<Node> breadth = new Queue<Node>();
			breadth.Enqueue(node);
			Console.WriteLine($"Searching for node value: {value}");
			try
			{
				while (breadth.TryPeek(out node))
				{
					Node front = breadth.Dequeue();

					if (front.LeftChild.Value == value || front.RightChild.Value == value)
					{
						Console.WriteLine($"Found Node: {value}");
						return true;
					}
					if (front.LeftChild != null)
					{
						breadth.Enqueue(front.LeftChild);
					}
					if (front.RightChild != null)
					{
						breadth.Enqueue(front.RightChild);
					}
				}
				throw new NullReferenceException();
			} catch(NullReferenceException)
			{
				Console.WriteLine("Value not found");
				return false;
			}
		
		}
	}
}
