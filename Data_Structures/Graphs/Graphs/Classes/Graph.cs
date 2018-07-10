using System;
using System.Collections.Generic;
using System.Text;


namespace Graphs
{
	public class Graph
	{


		public Node Root { get; set; }

		public List<Node> ListNodes { get; set; }

		/// <summary>
		/// method to add a neighbor node
		/// </summary>
		/// <param name="root">root node to add from</param>
		/// <param name="destination">destination node to add to</param>
		public void AddNeighbor(Node root, Node destination)
		{
			root.Neighbor.Add(destination);
			destination.Neighbor.Add(root);
		}

		/// <summary>
		/// method to get all nodes
		/// </summary>
		/// <param name="node">root node to execute request from</param>
		/// <returns>list of nodes gotten</returns>
		public List<Node> GetNodes(Node root)
		{
			List<Node> order = new List<Node>();
			Queue<Node> breadth = new Queue<Node>();
			breadth.Enqueue(root);

			while (breadth.TryPeek(out root))
			{
				Node front = breadth.Dequeue();
				order.Add(front);

				foreach (Node child in front.Neighbor)
				{
					if (!child.Visited)
					{
						child.Visited = true;
						breadth.Enqueue(child);
					}
				}

			}

			//print list
			foreach (var item in order)
			{
				Console.WriteLine(item.Value);
			}

			return order;
		}

		/// <summary>
		/// method to get neighbors in a graph
		/// </summary>
		/// <param name="root">root node to initiate method from</param>
		/// <returns>list of neighbors</returns>
		public List<Node> GetNeighbors(Node root)
		{
			List<Node> result = new List<Node>();

			for (var i = 0; i < root.Neighbor.Count; i++)
			{
				result.Add(root.Neighbor[i]);
			}

			Console.WriteLine($"Node {root.Value} neighbors = ");

			foreach (var item in result)
			{
				Console.WriteLine($"{item.Value}");
			}

			return result;
		}

		/// <summary>
		/// method to get the size of the list
		/// </summary>
		/// <param name="nodeList">list of nodes returned from traversal</param>
		/// <returns>integer of total amount of nodes/vertices</returns>
		public int Size(List<Node> nodeList)
		{
			int totalCount = 0;

			foreach (var item in nodeList)
			{
				totalCount++;
			}

			Console.WriteLine($"The total count is {totalCount}");
			return totalCount;
		}

		/// <summary>
		/// method to traverse bread-first
		/// </summary>
		/// <param name="node">root node to execute request from</param>
		/// <returns>list of nodes gotten</returns>
		public List<Node> BreadFirst(Node root)
		{
			List<Node> order = new List<Node>();
			Queue<Node> breadth = new Queue<Node>();
			breadth.Enqueue(root);

			while (breadth.TryPeek(out root))
			{
				Node front = breadth.Dequeue();
				order.Add(front);

				foreach (Node child in front.Neighbor)
				{
					if (!child.Visited)
					{
						child.Visited = true;
						breadth.Enqueue(child);
					}
				}

			}

			//print list
			foreach (var item in order)
			{
				Console.WriteLine(item.Value);
			}

			return order;
		}
	}
}