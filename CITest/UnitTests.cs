using Xunit;

namespace CITest
{
    public class UnitTests
    {
        [Fact(DisplayName = "Fail test")]
        public void Fail_Test()
        {
            Assert.True(false, "This test should fail");
        }

        [Fact(DisplayName = "Pass test")]
        public void Pass_Test()
        {
            Assert.True(true, "This test should not happen");
        }
    }
}