using System;
using System.Collections.Generic;
using System.Text;


namespace MaximumValueBinaryTree
{

	public class BinaryTree
	{


		/// <summary>
		/// method to traverse using Bread-First
		/// </summary>
		/// <param name="node">input node to set as root of traversal</param>
		public int MaxTree(Node node)
		{
			Queue<Node> bread = new Queue<Node>();
			bread.Enqueue(node);
			int tempInt = 0;

			while (bread.TryPeek(out node))
			{
				Node front = bread.Dequeue();
				
				if (tempInt < front.Value)
				{
					tempInt = front.Value;
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
				
			}
			Console.WriteLine(tempInt);
			return tempInt;
		}
	}
}