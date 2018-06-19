using System;
using Xunit;
using StackAndQ;

namespace StackAndQTest
{
    public class UnitTest1
    {
		[Fact]
		public void CanPushStack()
		{
			//arrange
			Stack testStack = new Stack(new Node(1));
			Node node2 = new Node(2);
			Node node3 = new Node(3);
			Node node4 = new Node(4);

			//act
			testStack.Push(node2);
			testStack.Push(node3);

			//assert
			Assert.Equal(testStack.Head.Value, node3.Value);
		}

		[Fact]
		public void CanPopStack()
		{
			//arrange
			Stack testStack = new Stack(new Node(1));
			Node node2 = new Node(2);
			Node node3 = new Node(3);
			Node node4 = new Node(4);

			//act
			testStack.Push(node2);
			testStack.Push(node3);
			testStack.Pop();

			//assert
			Assert.Equal(testStack.Head.Value, node2.Value);
		}

		[Fact]
		public void CanPeekStack()
		{
			//arrange
			Stack testStack = new Stack(new Node(1));
			Node node2 = new Node(2);
			Node node3 = new Node(3);
			Node node4 = new Node(4);

			//act
			testStack.Push(node2);
			testStack.Push(node3);


			//assert
			Assert.Equal(testStack.Head.Value, testStack.Peek().Value);
		}

		[Fact]
		public void CanEnqueueQ()
		{
			//arrange
			Queue testQ = new Queue(new Node(1));
			Node node2 = new Node(2);
			Node node3 = new Node(3);
			Node node4 = new Node(4);

			//act
			testQ.Enqueue(node2);
			testQ.Enqueue(node3);

			//assert
			Assert.Equal(testQ.Head.Value, node3.Value);
		}

		[Fact]
		public void CanDequeueQ()
		{
			//arrange
			Queue testQ = new Queue(new Node(1));
			Node node2 = new Node(2);
			Node node3 = new Node(3);
			Node node4 = new Node(4);

			//act
			testQ.Enqueue(node2);
			testQ.Enqueue(node3);
			testQ.Enqueue(node4);
			testQ.Dequeue();

			//assert
			Assert.Null(node2.Next);
		}

		[Fact]
		public void CanPeekQ()
		{
			//arrange
			Queue testQ = new Queue(new Node(1));
			Node node2 = new Node(2);
			Node node3 = new Node(3);
			Node node4 = new Node(4);

			//act
			testQ.Enqueue(node2);
			testQ.Enqueue(node3);
			testQ.Enqueue(node4);


			//assert
			Assert.Equal(1, testQ.Peek().Value);
		}
	
	}
}
