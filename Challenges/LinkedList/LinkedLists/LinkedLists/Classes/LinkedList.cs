﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
	public class LinkedList
	{
		public Node Head { get; set; }
		public Node Current { get; set; }

		public LinkedList(Node node)
		{
			Head = node;
			Current = node;
		}

		public void Add(Node node)
		{
			node.Next = Head;
			Head = node;
			Current = Head;
		}

		public void Print()
		{
			Current = Head;
			
			while(Current.Next != null){
				Console.Write($"{Current.Value} ==>");
				Current = Current.Next;
			}

			Console.Write($"{Current.Value} ==> NULL");
		}


		public Node Find(int value)
		{
			Current = Head;

			while(Current.Next != null)
			{
				if(Current.Value == value)
				{
					return Current;
				}
				Current = Current.Next;
			}
			return Current.Value == value ? Current : null;
		}
	}
}