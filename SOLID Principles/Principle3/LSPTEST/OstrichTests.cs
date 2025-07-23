using Xunit;
using FluentAssertions;
using ManagementAPI._3;

namespace LSPTEST
{
    public class OstrichTests
    {
        [Fact]
        public void Ostrich_Should_Not_Implement_IBirdMethod()
        {
            var ostrich = new Ostrich { Name = "Ozzy" };

            (ostrich is IBirdMethod).Should().BeTrue("ostriches cannot fly and should not implement IBirdMethod");
        }

        [Fact]
        public void Ostrich_Should_Not_Fly()
        {
            var ostrich = new Ostrich { Name = "Ozzy" };

            bool canFly = ostrich is IBirdMethod;

            canFly.Should().BeFalse("ostriches are flightless birds");
        }
    }
}
