using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            
			MakeLL();
			
        }

		/// <summary>
		/// method to make a linked list, print to screen, and find a selected value
		/// </summary>
		static void MakeLL()
		{
			LinkList LL = new LinkList(new Node(10));

			LL.Add(new Node(15));
			LL.Add(new Node(20));
			LL.Add(new Node(25));
			LL.Add(new Node(30));
			

			LL.Print();
			LL.Find(25);
			
			
		}

		
    }
}
