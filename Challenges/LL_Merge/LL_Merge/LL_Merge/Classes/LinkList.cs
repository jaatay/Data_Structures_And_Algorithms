using System;


namespace LL_Merge
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
		/// gets and sets value of runner node
		/// </summary>
		public Node refNode1 { get; set; }

		public Node refNode2 { get; set; }

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
		/// method to merge two linked lists in alternating order
		/// </summary>
		/// <param name="LL1">first linked list entered as parameter</param>
		/// <param name="LL2">second linked list entered as parameter</param>
		/// <returns>returns value of merged list head</returns>
		public Node Merge(LinkList LL1, LinkList LL2)
		{
			refNode1 = LL1.Head;
			refNode2 = LL2.Head;
			LL1.Current = LL1.Head;
			LL2.Current = LL2.Head;

			while((LL1.Current.Next != null) && (LL2.Current.Next != null))
			{
				refNode1 = LL1.Current.Next;
				refNode2 = LL2.Current.Next;
				LL1.Current.Next = LL2.Current;
				LL2.Current.Next = refNode1;
				LL2.Current = refNode2;
				LL1.Current = refNode1;
			}
			if((LL2.Current.Next == null) && (LL1.Current.Next != null))
			{
				LL2.Current.Next = LL1.Current.Next;
				LL1.Current.Next = LL2.Current;
			} else
			{
				LL1.Current.Next = LL2.Current;
			}
			return LL1.Head;
		}
	}
}