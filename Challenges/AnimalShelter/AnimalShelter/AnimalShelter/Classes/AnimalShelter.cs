using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace AnimalShelter
{
	public class AnimalShelter
	{

		/// <summary>
		/// gets and sets the value of head
		/// </summary>
		public Node Rear { get; set; }

		/// <summary>
		/// gets and sets the value of current
		/// </summary>
		public Node Current { get; set; }

		public Node Front { get; set; }

		public Node Temp { get; set; }

		/// <summary>
		/// method to identify a node
		/// </summary>
		/// <param name="node">input paramter of node to set as head and current</param>
		public AnimalShelter(Node node)
		{
			Rear = node;
			Current = node;
			if(Current.Next == null)
			{
				Front = Current;
			}
			
		}
		
		

		/// <summary>
		/// method to add node to end of list
		/// </summary>
		/// <param name="newNode">new node to add</param>
		public void Enqueue(Node animal)
		{
			try
			{
				if (animal.Value == "dog" || animal.Value == "cat")
				{
					animal.Next = Rear;
					Rear = animal;
					Current = Rear;

					while(Current.Next != null)
					{
						Current = Current.Next;
					}
					Front = Current;
				}
				else
				{
					throw new InvalidOperationException();
				}
			}
			catch (InvalidOperationException)
			{
				Console.WriteLine("We only take cats and dogs!");
			}
		}

		/// <summary>
		/// method to add node to end of list
		/// </summary>
		/// <param name="newNode">new node to add</param>
		public Node Dequeue(string pref)
		{
			Node Temp = Front;
			Node Runner = Front;
			if (pref == "cat")
			{
				if (Front.Value == "cat")
				{
					return Front;
				}
				else
				{
					Runner.Value = "cat";
					while (Runner.Next != null)
					{
						if (Runner.Next.Value == "cat")
						{
							Temp = Runner.Next;
							Runner.Next = Runner.Next.Next;
							Temp.Next = null;
							return Temp;
						}
					}
				}
			}
			else if (pref == "dog")
			{
				if (Front.Value == "dog")
				{
					return Front;
				}
				else
				{
					Runner.Value = "dog";
					 Temp = Front;
					 Runner = Front;
					while (Runner.Next != null)
					{
						if (Runner.Next.Value == "dog")
						{
							Temp = Runner.Next;
							Runner.Next = Runner.Next.Next;
							Temp.Next = null;
							return Temp;
						}
					}
				}
			}
			else
			{
				Temp = Front;
				Front = Front.Next;
				Temp.Next = null;

				return Temp;
			}

			return Temp;
		}

		/// <summary>
		/// method to print linked list to console
		/// </summary>
		public void PrintQ()
		{
			Current = Rear;

			while (Current.Next != null)
			{
				Console.Write($"{Current.Value}-->");
				Current = Current.Next;
			}

			Console.Write($"{Current.Value}--> NULL");
			Console.WriteLine("");
		}

	}
}
