using System;
using System.Collections;
using System.Collections.Generic;

namespace Graphs
{

	public class Node
	{
		/// <summary>
		/// gets and sets value property of a node
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// gets and sets the next neighbor of a node
		/// </summary>
		public List<Node> Neighbor { get; set; }

		/// <summary>
		/// boolean value for if a node has been visited
		/// </summary>
		public bool Visited { get; set; } = false;

		/// <summary>
		/// sets the valute of a node
		/// </summary>
		/// <param name="value">integer to use as node value</param>
		public Node(string value)
		{
			Value = value;
			Neighbor = new List<Node>();
		}


	}
}
