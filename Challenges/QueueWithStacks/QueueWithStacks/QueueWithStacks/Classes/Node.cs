using System;
using System.Collections;
using System.Text;

namespace QueueWithStacks
{ 
	public class Node
	{
		/// <summary>
		/// gets and sets value property of a node
		/// </summary>
		public int Value { get; set; }

		/// <summary>
		/// gets and sets the next property of a node
		/// </summary>
		public Node Next { get; set; }

		public Node Temp { get; set; }

		/// <summary>
		/// sets the valute of a node
		/// </summary>
		/// <param name="value">integer to use as node value</param>
		public Node(int value)
		{
			Value = value;
		}
	}
}
