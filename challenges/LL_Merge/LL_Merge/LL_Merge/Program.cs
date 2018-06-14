using System;
using System.Collections.Generic;


namespace LL_Merge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			NewLL();
        }

		static void NewLL()
		{
			LinkList LL = new LinkList(new Node(1));

			LL.Add(new Node(2));
			LL.Add(new Node(3));
			LL.Add(new Node(4));
			LL.Add(new Node(5));


			LL.Print();
			
		}
    }
}
