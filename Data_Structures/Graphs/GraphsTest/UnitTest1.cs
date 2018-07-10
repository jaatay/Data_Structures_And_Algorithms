using System;
using System.Collections.Generic;
using Graphs;
using Xunit;

namespace GraphsTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetSize()
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

			var myGraph = newGraph;

			Assert.Equal(7, myGraph.Size(newGraph.GetNodes(nodeA)));
		}

		[Fact]
		public void CanGetNeighbors()
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

			List<Node> neighborList = new List<Node> { nodeB, nodeD };

			Assert.Equal(neighborList, newGraph.GetNeighbors(nodeA));
		}
    }
}
