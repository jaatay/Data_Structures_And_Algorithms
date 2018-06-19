using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Test string");
			MakeLL();
			
        }

		/// <summary>
		/// method to make a linked list, print to screen, and find a selected value
		/// </summary>
		static void MakeLL()
		{
			LinkList LL = new LinkList(new Node(10));

			Node LL1 = new Node(15);
			Node LL2 = new Node(20);
			Node LL3 = new Node(25);

			LL.Add(LL1);
			LL.Add(LL2);
			LL.Add(LL3);
			

			Node addMeBefore = new Node(1);
			Node addMeAfter = new Node(2);
			
			LL.Find(25);

			LL.AddBefore(addMeBefore, LL3);
			LL.AddAfter(addMeAfter, LL2);

			LL.Print();


		}

		
    }
}
