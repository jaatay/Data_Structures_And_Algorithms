using System;

namespace LL_Kth_From_End { 
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
	/// gets and sets value of runner node
	/// </summary>
	public Node Runner { get; set; }

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

		while (Current.Next != null)
		{
			Console.Write($"{Current.Value} ==>");
			Current = Current.Next;
		}

		Console.Write($"{Current.Value} ==> NULL");
		Console.WriteLine("");
	}

		/// <summary>
		/// method to find kth element in list
		/// </summary>
		/// <param name="k">integer of value to be found from the end of the list</param>
		/// <returns>returns value of node found, or throws index out of range exception if k is outside the list</returns>
		public Node KthElement(int k)
		{
			try
			{
				if(k < 0)
				{
					throw new IndexOutOfRangeException();
				}
				Current = Head;
				Runner = Head;
				int counter = 0;

				while (Runner.Next != null)
				{
					Runner = Runner.Next;
					counter++;
					
					if (counter > k)
					{
						Current = Current.Next;
					}

					
				}

				if (k > counter)
				{
					throw new IndexOutOfRangeException();
				}
				Console.WriteLine($"Found node {Current.Value} ");
				return Current;
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("Value not found");
				return null;
				
			}

			
		}
		

	

}

}