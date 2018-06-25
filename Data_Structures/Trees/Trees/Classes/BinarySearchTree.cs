using System;
using System.Collections.Generic;
using System.Text;


namespace Trees
{
	public class BinarySearchTree
	{
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