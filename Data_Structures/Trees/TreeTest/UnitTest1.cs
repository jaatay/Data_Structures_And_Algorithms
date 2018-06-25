using System;
using Xunit;
using Trees;

namespace TreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNodeToBinarySearchTree()
        {
			BinarySearchTree searchTree = new BinarySearchTree();

			Node nodeA = new Node(8);
			Node nodeB = new Node(3);
			Node nodeC = new Node(5);
			Node nodeD = new Node(7);
			Node nodeE = new Node(9);

			Node nodeF = new Node(4);
			Node nodeG = new Node(10);

			searchTree.Add(nodeA, nodeB);
			searchTree.Add(nodeA, nodeC);
			searchTree.Add(nodeA, nodeD);
			searchTree.Add(nodeA, nodeE);

			Assert.Equal(nodeF, searchTree.Add(nodeA, nodeF));
		}

		[Fact]
		public void CanFindNodeInBinarySearchTree()
		{
			BinarySearchTree searchTree = new BinarySearchTree();

			Node nodeA = new Node(8);
			Node nodeB = new Node(3);
			Node nodeC = new Node(5);
			Node nodeD = new Node(7);
			Node nodeE = new Node(9);

			Node nodeF = new Node(4);
			Node nodeG = new Node(10);

			searchTree.Add(nodeA, nodeB);
			searchTree.Add(nodeA, nodeC);
			searchTree.Add(nodeA, nodeD);
			searchTree.Add(nodeA, nodeE);

			Assert.True(searchTree.Search(nodeA, 9));
		}

		[Fact]
		public void CanFindNodeInBinaryTree()
		{
			BinaryTree newTree = new BinaryTree();

			Node nodeA = new Node(1);
			Node nodeB = new Node(2);
			Node nodeC = new Node(3);
			Node nodeD = new Node(4);
			Node nodeE = new Node(5);
			Node nodeF = new Node(6);

			nodeA.LeftChild = nodeB;
			nodeA.RightChild = nodeC;
			nodeB.LeftChild = nodeD;
			nodeB.RightChild = nodeE;
			nodeC.LeftChild = nodeF;

			Assert.True(newTree.Search(nodeA, 3));
		}
	}
}
