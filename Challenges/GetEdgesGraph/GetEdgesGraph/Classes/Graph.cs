using System;
using System.Collections.Generic;
using System.Text;


namespace GetEdgesGraph
{
	public class Graph
	{
		/// <summary>
		/// sets root node for traversal
		/// </summary>
		public Node Root { get; set; }

		/// <summary>
		/// list of nodes used in other methods
		/// </summary>
		public List<Node> ListNodes { get; set; }

		public List<Decimal> ListEdges { get; set; }

		/// <summary>
		/// number of edge value between two nodes
		/// </summary>
		public decimal EdgeValue { get; set; }

		/// <summary>
		/// method to get an edge value between 2 nodes
		/// </summary>
		/// <param name="node1">starting node</param>
		/// <param name="node2">ending node</param>
		/// <param name="value">decimal value of edge</param>
		/// <returns></returns>
		public decimal GetEdge(Node node1, Node node2, decimal value)
		{

			EdgeValue = value;

			return EdgeValue;
		}

		/// <summary>
		/// method to add a neighbor node
		/// </summary>
		/// <param name="root">root node to add from</param>
		/// <param name="destination">destination node to add to</param>
		public void AddEdges(Node root, Node destination)
		{
			root.Neighbor.Add(destination);
			destination.Neighbor.Add(root);
		}

		/// <summary>
		/// method to determine if a trip is possible given a root node, destination node, and list of neighbors for destination
		/// </summary>
		/// <param name="root">root node to begin search from</param>
		/// <param name="destination">destination node trying to go to</param>
		/// <param name="neighbor">list of nodes that are neighbors of destination</param>
		/// <returns></returns>
		public string GetEdges(Node root, Node destination, List<Node> neighbor, List<decimal> edges)
		{

			bool isPossible = false;

			foreach(var item in neighbor)
			{
				if(item.Value == destination.Value)
				{
					isPossible = true;
				}
			}

			if(isPossible == false)
			{
				string noCan = "Cannot make trip.";
				return noCan;
			}

			string yesCan = "Can make trip.";
			return yesCan;
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