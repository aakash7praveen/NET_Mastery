using System;
using System.IO;
using Xunit;
using FluentAssertions;
using ManagementAPI._3;

namespace LSPTEST
{
    public class SparrowTests
    {
        [Fact]
        public void Sparrow_Should_Fly()
        {
            var sparrow = new Sparrow { Name = "Jack" };
            var sw = new StringWriter();
            Console.SetOut(sw);

            ((IBirdMethod)sparrow).Fly();
            var output = sw.ToString().Trim();

            output.Should().Be("Jack the sparrow is flying!");
        }

        [Fact]
        public void Sparrow_Fly_Should_Not_Return_Wrong_Message()
        {
            var sparrow = new Sparrow { Name = "Jack" };
            var sw = new StringWriter();
            Console.SetOut(sw);

            ((IBirdMethod)sparrow).Fly();
            var output = sw.ToString().Trim();

            output.Should().Be("Jack the eagle is flying!");
        }
    }
}
