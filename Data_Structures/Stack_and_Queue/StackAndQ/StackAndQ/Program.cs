using System;

namespace StackAndQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Stack");
			TestStack();
			Console.WriteLine("Test Queue");
			TestQ();
        }

		public static void TestStack()
		{
			Stack thisStack = new Stack(new Node(1));
			Node node2 = new Node(2);
			Node node3 = new Node(3);

			Console.Write("Stack start");
			thisStack.PrintStack();


			Console.WriteLine($"Stack push {node2.Value} and {node3.Value}");
			thisStack.Push(node2);
			thisStack.Push(node3);
			

			thisStack.PrintStack();

			Console.WriteLine("Peek value");
			thisStack.Peek();

			Console.WriteLine("Popped stack");
			thisStack.Pop();
			thisStack.PrintStack();

			
		}

		public static void TestQ()
		{
			Queue thisQ = new Queue(new Node(1));
			Node node2 = new Node(2);
			Node node3 = new Node(3);
			Node node4 = new Node(4);

			Console.WriteLine("Queue");
			thisQ.Add(node2);
			thisQ.Add(node3);
			thisQ.PrintQ();


			Console.WriteLine("Enqueue");
			thisQ.Enqueue(node4);
			thisQ.PrintQ();

			Console.WriteLine("Peek");
			thisQ.Peek();
			thisQ.PrintQ();

			Console.WriteLine("Dequeue");
			thisQ.Dequeue();
			thisQ.PrintQ();

		}
	}
}
