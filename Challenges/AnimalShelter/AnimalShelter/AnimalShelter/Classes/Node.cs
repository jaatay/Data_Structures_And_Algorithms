using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace AnimalShelter
{
	public class Node
	{
		/// <summary>
		/// gets and sets value property of a node
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// gets and sets the next property of a node
		/// </summary>
		public Node Next { get; set; }

		/// <summary>
		/// sets the valute of a node
		/// </summary>
		/// <param name="value">integer to use as node value</param>
		public Node(string value)
		{
			Value = value;
		}
	}
}