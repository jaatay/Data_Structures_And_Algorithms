using System;
using System.Collections;
using System.Text;


namespace QueueWithStacks
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			QueueWithStacks();
		}

		public static void QueueWithStacks()
		{

			Queue stack1 = new Queue(new Node(1));
			Node node1 = new Node(2);
			Node node2 = new Node(3);

			Node node5 = new Node(10);

			stack1.Push(node1);
			
			Queue stack2 = new Queue(new Node(4));
			Node node3 = new Node(5);
			Node node4 = new Node(6);

			Queue stack3 = new Queue(new Node(1));

			stack3.Enqueue(stack1, stack2, node5);
			stack3.PrintQ();

		}


    }
}
