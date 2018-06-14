using System;



namespace LL_Merge
{
    public class Program
    {
        static void Main(string[] args)
        {
			
			
			Merge();
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

		static void Merge()
		{
			LinkList LL1 = new LinkList(new Node(2));

			LL1.Add(new Node(4));
			LL1.Add(new Node(6));
			LL1.Add(new Node(8));
			LL1.Add(new Node(10));

			Console.WriteLine("L1");
			LL1.Print();
			

			LinkList LL2 = new LinkList(new Node(1));

			LL2.Add(new Node(3));
			LL2.Add(new Node(5));
			LL2.Add(new Node(7));
			LL2.Add(new Node(9));

			Console.WriteLine("L2");
			LL2.Print();
			

			LL1.Merge(LL1, LL2);

			Console.WriteLine("Merged List");
			LL1.Print();

		}
	}

}
