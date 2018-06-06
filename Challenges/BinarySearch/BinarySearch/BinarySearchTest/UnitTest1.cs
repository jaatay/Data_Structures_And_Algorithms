using System;
using BinarySearch;
using Xunit;

namespace BinarySearchTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnFound()
        {
            int[] TestArray = { 4, 8, 15, 16, 23, 30, 42 };
            int TestKey = 23;
            Assert.Equal(4, Program.BinarySearch(TestArray, TestKey));
        }

        [Fact]
        public void CanReturnNotFound()
        {
            int[] TestArray = { 4, 8, 15, 16, 23, 30, 42 };
            int TestKey = 50;
            Assert.Equal(-1, Program.BinarySearch(TestArray, TestKey));
        }

        [Fact]
        public void CanReturnZero()
        {
            int[] TestArray = {0};
            int TestKey = 0;
            Assert.Equal(0, Program.BinarySearch(TestArray, TestKey));
        }

    }


}
