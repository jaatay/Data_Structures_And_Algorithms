using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
	public class LinkList
	{
		/// <summary>
		/// gets and sets the value of head
		/// </summary>
		public Node Head { get; set; }

		/// <summary>
		/// gets and sets the value of current
		/// </summary>
		public Node Current { get; set; }

		/// <summary>
		/// method to identify a node
		/// </summary>
		/// <param name="node">input paramter of node to set as head and current</param>
		public LinkList(Node node)
		{
			Head = node;
			Current = node;
		}
		/// <summary>
		/// method to add new node in front of list, sets as head node
		/// </summary>
		/// <param name="node"></param>
		public void Add(Node node)
		{
			node.Next = Head;
			Head = node;
			Current = Head;
		}

		/// <summary>
		/// method to print linked list to console
		/// </summary>
		public void Print()
		{
			Current = Head;
			
			while(Current.Next != null){
				Console.Write($"{Current.Value} ==>");
				Current = Current.Next;
			}

			Console.Write($"{Current.Value} ==> NULL");
			Console.WriteLine("");
		}

		/// <summary>
		/// method to add sum of linked list values(not required part of lab, just did it out of curiosity)
		/// </summary>
		public void AddValues()
		{
			Current = Head;
			int valueCount = 0;

			while(Current.Next != null)
			{
				Current = Current.Next;
				valueCount += Current.Value;
			}

			Console.WriteLine($"The sum is: {valueCount}");
			Console.WriteLine("");
			
		}

		/// <summary>
		/// method to find the location of a node based on value
		/// </summary>
		/// <param name="value">value of node to find in list</param>
		/// <returns>returns value of found node as current, unless node is not found then returns null</returns>
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

		/// <summary>
		/// method to add node to end of list
		/// </summary>
		/// <param name="newNode">new node to add</param>
		public void AddLast(Node newNode)
		{
			Current = Head;
			while(Current.Next != null)
			{
				Current = Current.Next;
			}

			Current.Next = newNode;
		}

		/// <summary>
		/// method to add node after a currently existing node
		/// </summary>
		/// <param name="newNode">new node to add</param>
		/// <param name="existingNode">existing node to add new node after</param>
		public void AddAfter(Node newNode, Node existingNode)
		{
			Current = Head;

			if(Head.Value == existingNode.Value)
			{
				Add(newNode);
				return;
			}

			while(Current.Next != null)
			{
				if (Current.Next.Value == existingNode.Value)
				{
					newNode.Next = Current.Next;
					Current.Next = newNode;
				}
				Current = Current.Next;
			}
		}

		/// <summary>
		/// method to add new node before currently existing node
		/// </summary>
		/// <param name="newNode">new node to add</param>
		/// <param name="existingNode">node to add new node before</param>
		public void AddBefore(Node newNode, Node existingNode)
		{
			//reset current to beginning of LL
			Current = Head;

			if (Head.Value == existingNode.Value)
			{
				Add(newNode);
				return;
			}

			while (Current.Next != null)
			{
				if (Current.Next.Value == existingNode.Value)
				{
					newNode.Next = Current.Next;
					Current.Next = newNode;
					return;
				}
				Current = Current.Next;
			}
		}
	}
}