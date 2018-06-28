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

			//temp int to hold max value
			int tempInt = 0;

			while (bread.TryPeek(out node))
			{
				
				Node front = bread.Dequeue();
				
				//condition comparing the temp value to the front node value
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
				
				
			}
			Console.WriteLine(tempInt);
			return tempInt;
		}
	}
}