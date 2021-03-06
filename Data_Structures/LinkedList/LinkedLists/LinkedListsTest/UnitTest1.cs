using System;
using Xunit;
using LinkedLists;

namespace LinkedListsTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNode()
        {
			//arrange
			LinkList testLL = new LinkList(new Node(4));
			Node node = new Node(8);
			Node node2 = new Node(15);

			//act
			testLL.Add(node);
			testLL.Add(node2);

			//assert
			Assert.Equal(testLL.Head.Value, node2.Value);
        }

		[Theory]
		[InlineData(8, 8)]
		[InlineData(16, 16)]
		[InlineData(15, 15)]
		public void CanFindNodeThatExists(int value, int expected)
		{
			//arrange
			LinkList testLL = new LinkList(new Node(4));
			Node node = new Node(8);
			Node node2 = new Node(15);
			Node node3 = new Node(16);

			//act
			testLL.Add(node);
			testLL.Add(node2);
			testLL.Add(node3);

			Node found = testLL.Find(8);
	
			//assert
			Assert.Equal(expected, value);
		}

		[Theory]
		[InlineData(42)]
		[InlineData(100)]
		public void ReturnsNullForNodeThatDoesNotExist(int value)
		{
			//arrange
			LinkList testLL = new LinkList(new Node(4));
			Node node = new Node(8);
			Node node2 = new Node(15);
			Node node3 = new Node(16);

			//act
			testLL.Add(node);
			testLL.Add(node2);
			testLL.Add(node3);

			Node found = testLL.Find(value);

			//assert
			Assert.Null(found);
		}

		[Fact]
		public void CanAddBefore()
		{
			//arrange
			LinkList testLL = new LinkList(new Node(4));
			Node node = new Node(8);
			Node node2 = new Node(15);
			Node node3 = new Node(1);

			//act
			testLL.Add(node);
			testLL.Add(node2);
			testLL.AddBefore(node3, node2);


			//assert
			Assert.Equal(testLL.Head.Value, node3.Value);
		}

		[Fact]
		public void CanAddAfter()
		{
			//arrange
			LinkList testLL = new LinkList(new Node(1));
			Node node = new Node(2);
			Node node2 = new Node(3);
			Node node3 = new Node(4);

			//act
			testLL.Add(node);
			testLL.Add(node2);
			testLL.AddAfter(node3, node2);


			//assert
			Assert.Equal(2, node2.Next.Value);
		}


	}
}
