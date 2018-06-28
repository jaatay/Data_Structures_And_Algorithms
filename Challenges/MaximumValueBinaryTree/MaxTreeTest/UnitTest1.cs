using System;
using Xunit;
using MaximumValueBinaryTree;

namespace MaxTreeTest
{
    public class TreeTest
    {
        [Fact]
        public void CanFindMax()
        {
			BinaryTree thisTree = new BinaryTree();

			Node node1 = new Node(20);
			Node node2 = new Node(5);
			Node node3 = new Node(4100);
			Node node4 = new Node(15);
			Node node5 = new Node(13);
			Node node6 = new Node(6);

			node1.LeftChild = node2;
			node1.RightChild = node3;
			node2.LeftChild = node4;
			node2.RightChild = node5;
			node5.LeftChild = node6;

			Assert.Equal(4100, thisTree.MaxTree(node1));
			
		}

		[Fact]
		public void CanReturnOne()
		{
			BinaryTree thisTree = new BinaryTree();

			Node node1 = new Node(0);
			Node node2 = new Node(0);
			Node node3 = new Node(0);
			Node node4 = new Node(1);
			Node node5 = new Node(0);
			Node node6 = new Node(0);

			node1.LeftChild = node2;
			node1.RightChild = node3;
			node2.LeftChild = node4;
			node2.RightChild = node5;
			node5.LeftChild = node6;

			Assert.True(thisTree.MaxTree(node1) == 1);
		}

		[Fact]
		public void CanTraverseAllNodes()
		{
			BinaryTree thisTree = new BinaryTree();

			Node node1 = new Node(0);
			Node node2 = new Node(0);
			Node node3 = new Node(0);
			Node node4 = new Node(0);
			Node node5 = new Node(0);
			Node node6 = new Node(1);

			node1.LeftChild = node2;
			node1.RightChild = node3;
			node2.LeftChild = node4;
			node2.RightChild = node5;
			node5.LeftChild = node6;

			Assert.Equal(1, thisTree.MaxTree(node1));
		}
	}
}
