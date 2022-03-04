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
        public void T1ListContainingZerosShouldSumToZero()
        {
            Assert.True(Solution.CanAddUp(new[] {0,0}, 0));
        }
        [Fact]
        public void T2ListContainingnumShouldSumToNonZero()
        {
            Assert.True(Solution.CanAddUp(new[] {1,3}, 4));
        }
    }
}
