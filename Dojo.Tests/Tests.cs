using Xunit;

namespace Dojo.Tests
{
    public class Tests
    {
        [Fact]
        public void StarterTest()
        {
            Assert.True(Solution.IsSetup);
        }

        [Fact]
        public void ListContainingZerosShouldReturnTrueWhenFindingZero()
        {
            Assert.True(Solution.CanAddUp(new[] {0,0}, 0));
        }
        [Fact]
        public void ListContainingSumShouldReturnTrueWhenFindingPositiveNumber()
        {
            Assert.True(Solution.CanAddUp(new[] {1,3}, 4));
        }

        [Fact]
        public void ListNotContainingSumShouldReturnFalse()
        {
            Assert.False(Solution.CanAddUp(new [] {0, 0}, 4));
        }
    }
}
