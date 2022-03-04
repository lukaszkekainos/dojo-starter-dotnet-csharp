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

         [Fact]
        public void ListNotContainingSumOf6and0ShouldReturnFalse()
        {
            Assert.False(Solution.CanAddUp(new [] {6, 0}, 4));
        }

        [Fact]
        public void ListNotContainingAnyValuesShouldReturnFalse()
        {
            Assert.False(Solution.CanAddUp(System.Array.Empty<int>(), 4));
        } 

        [Fact]
        public void ListContainingSumShouldReturnTrue()
        {
            Assert.True(Solution.CanAddUp(new [] {4, 0}, 4));
        } 
    }
}
