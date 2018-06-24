using System;
using Xunit;
using MultiBracketValidation;

namespace MultiBracketTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindTrue()
        {
            Assert.True(Program.ValidateBrackets("{}()"));
        }

        [Fact]
        public void CanFindFalse()
        {
            Assert.False(Program.ValidateBrackets("{()"));
        }

        [Fact]
        public void CanEvaluateEmptyString()
        {
            Assert.False(Program.ValidateBrackets(""));
        }
    }
}
