using System.Diagnostics;
using Xunit;

namespace DotnetStarter.Logic.Tests
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class HelloWorldTest
    {
        [Fact]
        public void It_Should_Run() => Assert.Equal(1, 1);

        [Fact]
        public void Hello_ReturnsWorld()
        {
            Assert.Equal("Drink", "Drink");
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}