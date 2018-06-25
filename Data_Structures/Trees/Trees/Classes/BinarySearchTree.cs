using System;
using System.Collections.Generic;
using System.Text;


namespace Trees
{
	public class BinarySearchTree
	{
		/// <summary>
		/// method to search for a node containing a specific value
		/// </summary>
		/// <param name="node">node type which establishes the root to begin the search from</param>
		/// <param name="value">integer value of the node being searched for</param>
		/// <returns>boolean value of whether a node is found or not</returns>
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

					if (front.Value == value)
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
			}
			catch (NullReferenceException)
			{
				Console.WriteLine("Value not found");
				return false;
			}
		}

		/// <summary>
		/// method to add nodes to a binary search tree
		/// </summary>
		/// <param name="root">the root node, will reflect the root of where the search begins, and the new root when called recursively</param>
		/// <param name="newNode">new node being added to the tree</param>
		/// <returns>returns a the node successfully added, or root if the node is added to a blank tree. method declared with a return type for testing purposes</returns>
		public Node Add(Node root, Node newNode)
		{
			if(root == null)
			{
				root = newNode;
				return newNode;
			}

			Console.WriteLine($"{root.Value}");
			Console.WriteLine("||");

				if (newNode.Value < root.Value)
				{
					if (root.LeftChild != null)
					{
						Console.WriteLine("<--");

						Add(root.LeftChild, newNode);
					}
					else
					{
						Console.WriteLine("<--");
						root.LeftChild = newNode;
						Console.WriteLine(newNode.Value);
						
					}
					return newNode;
				}

				if (newNode.Value > root.Value)
				{
					if (root.RightChild != null)
					{
						Console.WriteLine("-->");

						Add(root.RightChild, newNode);

					}
					else
					{
						Console.WriteLine("-->");
						root.RightChild = newNode;
						Console.WriteLine(newNode.Value);
						

					}
					return newNode;
				}

			return root;
		}
	}
}