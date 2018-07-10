using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

			TestMethods();
			TestMethodGetNodes();
			TestMethodBreadFirst();
			Console.WriteLine("Press any key to exit.");
			Console.ReadLine();
        }

		/// <summary>
		/// method to instantiate graph, nodes, and test Graph class methods
		/// </summary>
		public static void TestMethods()
		{
			Graph newGraph = new Graph();

			Node nodeA = new Node("A");
			
			Node nodeB = new Node("B");

			Node nodeC = new Node("C");

			Node nodeD = new Node("D");

			Node nodeE = new Node("E");

			Node nodeF = new Node("F");

			//add node A neighbors
			nodeA.Neighbor.Add(nodeB);
			nodeA.Neighbor.Add(nodeD);

			//add node B neighbors
			nodeB.Neighbor.Add(nodeA);
			nodeB.Neighbor.Add(nodeC);
			nodeB.Neighbor.Add(nodeE);

			//add node C neighbors
			nodeC.Neighbor.Add(nodeB);
			nodeC.Neighbor.Add(nodeF);

			//add node D neighbors
			nodeD.Neighbor.Add(nodeA);
			nodeD.Neighbor.Add(nodeE);

			//add node E neighbors
			nodeE.Neighbor.Add(nodeB);
			nodeE.Neighbor.Add(nodeD);
			nodeE.Neighbor.Add(nodeA);
			nodeE.Neighbor.Add(nodeF);

			//add node F neighbors
			nodeF.Neighbor.Add(nodeE);
			nodeF.Neighbor.Add(nodeC);

			//newGraph.ListNodes.Add(nodeB);

			//get neighbors
			Console.WriteLine("Get Neighbors");
			newGraph.GetNeighbors(nodeA);
			Console.WriteLine("------------");

			//get size
			Console.WriteLine("Get size");
			var myGraph = newGraph;
			myGraph.Size(newGraph.GetNodes(nodeA));
			Console.WriteLine("------------");
		}

		/// <summary>
		/// method to initiate new graph and run test methods. Since Bread-first traversal was used in graph methods the original graph nodes get dequeued and a new graph is necessary
		/// </summary>
		public static void TestMethodGetNodes()
		{
			Graph newGraph = new Graph();

			Node nodeA = new Node("A");

			Node nodeB = new Node("B");

			Node nodeC = new Node("C");

			Node nodeD = new Node("D");

			Node nodeE = new Node("E");

			Node nodeF = new Node("F");

			//add node A neighbors
			nodeA.Neighbor.Add(nodeB);
			nodeA.Neighbor.Add(nodeD);

			//add node B neighbors
			nodeB.Neighbor.Add(nodeA);
			nodeB.Neighbor.Add(nodeC);
			nodeB.Neighbor.Add(nodeE);

			//add node C neighbors
			nodeC.Neighbor.Add(nodeB);
			nodeC.Neighbor.Add(nodeF);

			//add node D neighbors
			nodeD.Neighbor.Add(nodeA);
			nodeD.Neighbor.Add(nodeE);

			//add node E neighbors
			nodeE.Neighbor.Add(nodeB);
			nodeE.Neighbor.Add(nodeD);
			nodeE.Neighbor.Add(nodeA);
			nodeE.Neighbor.Add(nodeF);

			//add node F neighbors
			nodeF.Neighbor.Add(nodeE);
			nodeF.Neighbor.Add(nodeC);
			//get nodes in graph
			Console.WriteLine("Get Nodes in graph");
			newGraph.GetNodes(nodeA);
			Console.WriteLine("------------");
		}

		/// <summary>
		/// method to instantiate new graph
		/// </summary>
		public static void TestMethodBreadFirst()
		{
			Graph newGraph = new Graph();

			Node nodeA = new Node("A");

			Node nodeB = new Node("B");

			Node nodeC = new Node("C");

			Node nodeD = new Node("D");

			Node nodeE = new Node("E");

			Node nodeF = new Node("F");

			Node nodeG = new Node("G");

			//before adding node A neighbors
			nodeA.Neighbor.Add(nodeB);
			nodeA.Neighbor.Add(nodeD);
			Console.WriteLine("Before adding a node");
			newGraph.GetNeighbors(nodeA);
			
			//add node A neighbors
			newGraph.AddEdges(nodeA, nodeB);
			Console.WriteLine("After adding a node");
			Console.WriteLine(newGraph.GetNeighbors(nodeA));
			
			//add node B neighbors
			nodeB.Neighbor.Add(nodeA);
			nodeB.Neighbor.Add(nodeC);
			nodeB.Neighbor.Add(nodeE);

			//add node C neighbors
			nodeC.Neighbor.Add(nodeB);
			nodeC.Neighbor.Add(nodeF);

			//add node D neighbors
			nodeD.Neighbor.Add(nodeA);
			nodeD.Neighbor.Add(nodeE);

			//add node E neighbors
			nodeE.Neighbor.Add(nodeB);
			nodeE.Neighbor.Add(nodeD);
			nodeE.Neighbor.Add(nodeA);
			nodeE.Neighbor.Add(nodeF);

			//add node F neighbors
			nodeF.Neighbor.Add(nodeE);
			nodeF.Neighbor.Add(nodeC);
			//bread-first traversal
			Console.WriteLine("Bread-first traversal");
			newGraph.BreadFirst(nodeA);
			Console.WriteLine("------------");
		}
	}
}
