using System;

namespace QueueWithStacks
{
	public class Stack
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
		public Stack(Node node)
		{
			Head = node;
			Current = node;
		}

		/// <summary>
		/// method to add new node in front of list, sets as head node
		/// </summary>
		/// <param name="node"></param>
		public void Push(Node node)
		{
			node.Next = Head;
			Head = node;
			Current = Head;
		}


		/// <summary>
		/// method to add node to end of list
		/// </summary>
		/// <param name="newNode">new node to add</param>
		public void Pop()
		{
			Current = Head;
			Head = Current.Next;

		}

		/// <summary>
		/// method to add node to end of list
		/// </summary>
		/// <param name="newNode">new node to add</param>
		public Node Peek()
		{

			try
			{
				Current = Head;
				while (Current.Next != null)
				{
					Current = Current.Next;
				}

				if (Head == null)
				{
					throw new IndexOutOfRangeException();
				}
				Console.WriteLine($"Found {Head.Value}");
				return Head;
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("Stack is empty.");
				return null;
			}
		}

		/// <summary>
		/// method to print linked list to console
		/// </summary>
		public void PrintStack()
		{
			Current = Head;

			while (Current.Next != null)
			{
				Console.Write($"{Current.Value} ==>");
				Current = Current.Next;
			}

			Console.Write($"{Current.Value} ==> NULL");
			Console.WriteLine("");
		}


	}
}