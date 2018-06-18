using System;
using Xunit;
using LL_Kth_From_End;

namespace LL_Kth_From_End
{
    public class UnitTest1
    {

		[Fact]
		public void CanFindNodeThatExists()
		{
			//arrange
			LinkList testLL = new LinkList(new Node(1));
			Node node = new Node(2);
			Node node2 = new Node(3);
			Node node3 = new Node(4);
			Node node4 = new Node(5);

			//act
			testLL.Add(node);
			testLL.Add(node2);
			testLL.Add(node3);
			testLL.Add(node4);

			//assert
			Assert.Equal(node, testLL.KthElement(1));
		}

		[Fact]
		public void CanReturnNull()
		{
			//arrange
			LinkList testLL = new LinkList(new Node(1));
			Node node = new Node(2);
			Node node2 = new Node(3);
			Node node3 = new Node(4);
			Node node4 = new Node(5);

			//act
			testLL.Add(node);
			testLL.Add(node2);
			testLL.Add(node3);
			testLL.Add(node4);

			//assert
			Assert.Null(testLL.KthElement(-1));
		}

		[Fact]
		public void CanReturnIndexOutOfRange()
		{
			//arrange
			LinkList testLL = new LinkList(new Node(1));
			Node node = new Node(2);
			Node node2 = new Node(3);
			Node node3 = new Node(4);
			Node node4 = new Node(5);

			//act
			testLL.Add(node);
			testLL.Add(node2);
			testLL.Add(node3);
			testLL.Add(node4);

			//assert
			Assert.Null(testLL.KthElement(6));
		}

	}
}
