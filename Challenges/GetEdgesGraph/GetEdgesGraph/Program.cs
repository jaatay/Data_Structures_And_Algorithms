using System;

namespace GetEdgesGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			TestMethods();
        }

		//graph relationships
		//A->D->B
		//B->A->D->E->F->C
		//C->B->F
		//D->E->B->A
		//E->D->F->B
		//F->B->C->E

		/// <summary>
		/// method to instantiate graph, nodes, and test Graph class methods
		/// </summary>
		public static void TestMethods()
		{
			//graph
			Graph newGraph = new Graph();

			//edge list

			//nodes
			Node nodeA = new Node("Pandora");
			Node nodeB = new Node("Metroville");
			Node nodeC = new Node("Narnia");
			Node nodeD = new Node("Arendelle");
			Node nodeE = new Node("Monstropolis");
			Node nodeF = new Node("Naboo");

			//nodeA edges
			var EdgeAB = newGraph.GetEdge(nodeA, nodeB, 82);
			var EdgeAD = newGraph.GetEdge(nodeA, nodeD, 150);

			//nodeB edges
			var EdgeBA = newGraph.GetEdge(nodeB, nodeA, 82);
			var EdgeBD = newGraph.GetEdge(nodeB, nodeD, 99);
			var EdgeBE = newGraph.GetEdge(nodeB, nodeE, 105);
			var EdgeBF = newGraph.GetEdge(nodeB, nodeF, 26);
			var EdgeBC = newGraph.GetEdge(nodeB, nodeC, 37);

			//nodeC edges
			var EdgeCB = newGraph.GetEdge(nodeC, nodeB, 37);
			var EdgeCF = newGraph.GetEdge(nodeC, nodeF, 250);

			//nodeD edges
			var EdgeDE = newGraph.GetEdge(nodeD, nodeE, 105);
			var EdgeDB = newGraph.GetEdge(nodeD, nodeB, 26);
			var EdgeDA = newGraph.GetEdge(nodeD, nodeA, 37);

			//nodeE edges
			var EdgeED = newGraph.GetEdge(nodeE, nodeD, 105);
			var EdgeEF = newGraph.GetEdge(nodeE, nodeF, 26);
			var EdgeEB = newGraph.GetEdge(nodeE, nodeB, 37);

			//nodeF edges
			var EdgeFB = newGraph.GetEdge(nodeF, nodeB, 105);
			var EdgeFC = newGraph.GetEdge(nodeF, nodeC, 26);
			var EdgeFE = newGraph.GetEdge(nodeF, nodeE, 37);

			//add list edges to graph
			newGraph.ListEdges.Add(EdgeAB);
			newGraph.ListEdges.Add(EdgeAD);
			newGraph.ListEdges.Add(EdgeBA);
			newGraph.ListEdges.Add(EdgeBD);
			newGraph.ListEdges.Add(EdgeBE);
			newGraph.ListEdges.Add(EdgeBF);
			newGraph.ListEdges.Add(EdgeBC);
			newGraph.ListEdges.Add(EdgeCB);
			newGraph.ListEdges.Add(EdgeCF);
			newGraph.ListEdges.Add(EdgeDE);
			newGraph.ListEdges.Add(EdgeDB);
			newGraph.ListEdges.Add(EdgeDA);
			newGraph.ListEdges.Add(EdgeED);
			newGraph.ListEdges.Add(EdgeEF);
			newGraph.ListEdges.Add(EdgeEB);
			newGraph.ListEdges.Add(EdgeFB);
			newGraph.ListEdges.Add(EdgeFC);
			newGraph.ListEdges.Add(EdgeFE);

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
			var BNeighbors = newGraph.GetNeighbors(nodeB);
			var graphEdges = newGraph.ListEdges;
			newGraph.GetEdges(nodeA, nodeB, BNeighbors, graphEdges);
		}

	}
}
