using System;



namespace LL_Merge
{
    public class Program
    {
        static void Main(string[] args)
        {
			
			
			Merge();
        }

		/// <summary>
		/// method to creake a new linked list
		/// </summary>
		static void NewLL()
		{
			LinkList LL = new LinkList(new Node(1));

			LL.Add(new Node(2));
			LL.Add(new Node(3));
			LL.Add(new Node(4));
			LL.Add(new Node(5));


			LL.Print();

		}

		/// <summary>
		/// method used to create two new linked lists and return merged list
		/// </summary>
		static void Merge()
		{
			//instantiate new list
			LinkList LL1 = new LinkList(new Node(2));

			//add nodes to new list
			LL1.Add(new Node(4));
			LL1.Add(new Node(6));
			LL1.Add(new Node(8));
			LL1.Add(new Node(10));

			Console.WriteLine("L1");
			LL1.Print();
			
			//instantiate new list
			LinkList LL2 = new LinkList(new Node(1));

			//add nodes to second list
			LL2.Add(new Node(3));
			LL2.Add(new Node(5));
			LL2.Add(new Node(7));
			LL2.Add(new Node(9));

			Console.WriteLine("L2");
			LL2.Print();
			
			//merges list 1 with list 2
			LL1.Merge(LL1, LL2);

			//print off merged list
			Console.WriteLine("Merged List");
			LL1.Print();

		}
	}

}
