using System;
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

		//adding node before O(1)
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
				

				if(Current.Next.Value == existingNode.Value)
				{
					newNode.Next = existingNode;
					Current.Next = newNode;
					return;
				}
				Current = Current.Next;
			}
		}

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

		public void AddLast(Node newNode)
		{
			Current = Head;
			while(Current.Next != null)
			{
				Current = Current.Next;
			}

			Current.Next = newNode;
		}

		//add AddAfter method
		
	}
}