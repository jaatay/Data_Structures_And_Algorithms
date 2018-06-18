using System;

namespace StackAndQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			TestStack();
        }

		public static void TestStack()
		{
			Stack thisStack = new Stack(new Node(1));
			Node node2 = new Node(2);
			Node node3 = new Node(3);

			thisStack.Add(node2);
			thisStack.Add(node3);

			thisStack.PrintStack();

			thisStack.Peek();

			thisStack.Pop();
			thisStack.PrintStack();

		}
    }
}
