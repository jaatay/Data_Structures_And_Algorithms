using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			TestShelter();
			Console.WriteLine("Press any key to exit");
			Console.ReadLine();
        }

		static void TestShelter()
		{
			AnimalShelter newShelter = new AnimalShelter(new Node("cat"));

			Node Cat1 = new Node("cat");
			Node Dog1 = new Node("dog");
			Node Dog2 = new Node("dog");
			Node Cat2 = new Node("cat");

			newShelter.Enqueue(Cat1);
			newShelter.Enqueue(Dog1);
			newShelter.Enqueue(Dog2);
			newShelter.Enqueue(Cat2);

			//expected output cat -- dog -- dog -- cat -- cat -- null
			
			newShelter.PrintQ();

			newShelter.Dequeue("cat");

			newShelter.PrintQ();

		}
    }
}
