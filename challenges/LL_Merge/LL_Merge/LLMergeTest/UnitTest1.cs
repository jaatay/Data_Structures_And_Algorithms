using System;
using Xunit;

namespace LL_Merge
{
    public class UnitTest1
    {
        [Fact]
        public void CanMerge()
        {
			LinkList LL1 = new LinkList(new Node(1));

			LL1.Add(new Node(2));
			LL1.Add(new Node(3));
			LL1.Add(new Node(4));
			LL1.Add(new Node(5));

			LinkList LL2 = new LinkList(new Node(6));

			LL2.Add(new Node(7));
			LL2.Add(new Node(8));
			LL2.Add(new Node(9));
			LL2.Add(new Node(10));

			Assert.Equal(LL1.Head, LL1.Merge(LL1,  LL2));
		}

		[Fact]
		public void CanMergeUneven()
		{
			LinkList LL1 = new LinkList(new Node(1));

			LL1.Add(new Node(2));
			LL1.Add(new Node(3));
			LL1.Add(new Node(4));
			LL1.Add(new Node(5));

			LinkList LL2 = new LinkList(new Node(6));

			LL2.Add(new Node(7));
			LL2.Add(new Node(8));
			LL2.Add(new Node(9));
			LL2.Add(new Node(10));

			Assert.Equal(LL1.Head, LL1.Merge(LL1, LL2));
		}

		[Fact]
		public void CanMergeUnevenList2()
		{
			LinkList LL1 = new LinkList(new Node(1));

			LL1.Add(new Node(2));

			LinkList LL2 = new LinkList(new Node(6));

			LL2.Add(new Node(7));
			LL2.Add(new Node(8));
			LL2.Add(new Node(9));
			LL2.Add(new Node(10));

			Assert.Equal(LL1.Head, LL1.Merge(LL1, LL2));
		}
	}
}
