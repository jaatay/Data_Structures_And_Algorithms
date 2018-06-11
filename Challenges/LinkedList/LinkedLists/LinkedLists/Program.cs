using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			FirstLL();
			
        }

		static void FirstLL()
		{
			LinkedList LL = new LinkedList(new Node(10));

			LL.Add(new Node(15));
			LL.Add(new Node(20));
			LL.Add(new Node(25));
			LL.Add(new Node(30));

			LL.Print();
			LL.AddValues();
		}
    }
}
