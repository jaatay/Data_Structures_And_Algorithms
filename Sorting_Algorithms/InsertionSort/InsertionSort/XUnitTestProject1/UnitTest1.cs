using System;
using InsertionSort;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData((new int[] {9, -1, 10, 3 }), (new int[] {-1, 3, 9, 10}))]
        [InlineData((new int[] { 100, -5, 10, 3 }), (new int[] { -5, 3, 10, 100 }))]
        [InlineData((new int[] { -9, -1, 10, 3 }), (new int[] { -9, -1, 3, 10 }))]
        public void CanSort(int[] input, int[] expected)
        {
            

            Program.InsertionSort(input);

            Assert.Equal(input, expected);
        }
    }
}
