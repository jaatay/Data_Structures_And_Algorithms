using System;
using System.Collections.Generic;
using System.Text;


namespace FizzBuzzTree
{

	public class BinaryTree
	{
		

		/// <summary>
		/// method to traverse using Bread-First
		/// </summary>
		/// <param name="node">input node to set as root of traversal</param>
		public void FizzBuzzTree(Node node)
		{
			Queue<Node> bread = new Queue<Node>();
			bread.Enqueue(node);

			while (bread.TryPeek(out node))
			{
				Node front = bread.Dequeue();
				Console.Write(front.Value);

				//holds temp value of parsed node string
				int tempInt = Int32.Parse(front.Value);

				//conditionals to set value of node
				if (tempInt % 15 == 0)
				{
					front.Value = "FizzBuzz";
					Console.Write(front.Value);
				}
				else if (tempInt % 3 == 0)
				{
					front.Value = "Fizz";
					Console.Write(front.Value);
				}
				else if(tempInt % 5 == 0)
				{
					front.Value = "Buzz";
					Console.Write(front.Value);
				}
				
				//continue node traversal
				if (front.LeftChild != null)
				{
					bread.Enqueue(front.LeftChild);
				}

				if (front.RightChild != null)
				{
					bread.Enqueue(front.RightChild);
				}
				//extra line so node old and new values end up side by side
				Console.WriteLine();
			}
		}
	}
}