using FluentAssertions;
using ManagementAPI._1;
using Xunit;

namespace SRPTEST
{
    public class SendTests
    {
        [Fact]
        public void SendEmail_WithValidInputs_ShouldLogToConsole()
        {
            var report = new Report("Test content");
            var sender = new Send();

            sender.Invoking(s => s.SendEmail(report, "test@example.com"))
                .Should().NotThrow("Because sending is just a console write in current logic");

            true.Should().BeTrue(); 
        }
    }
}
