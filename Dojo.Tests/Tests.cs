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
        public void ListContainingZerosShouldSumToZero()
        {
            Assert.True(Solution.CanAddUp(new[] {0,0}, 0));
        }
    }
}
