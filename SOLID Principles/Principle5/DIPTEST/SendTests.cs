using DIP;
using FluentAssertions;
using Xunit;
using System;
using System.IO;

namespace DIP.Tests
{
    public class EmailServiceTests
    {
        [Fact]
        public void Send_ShouldPrintCorrectMessage()
        {
            using var writer = new StringWriter();
            Console.SetOut(writer);

            var service = new EmailService();
            service.Send("alice@example.com", "bob@example.com");

            writer.ToString().Trim().Should().Be("Sending message from bob@example.com to alice@example.com");
        }

        [Fact]
        public void Send_WithAlternatePair()
        {
            using var writer = new StringWriter();
            Console.SetOut(writer);

            var service = new EmailService();
            service.Send("jack@company.com", "jill@company.com");

            writer.ToString().Trim().Should().Be("Sending message from jill@company.com to jack@company.com");
        }

        [Fact]
        public void Send_IncorrectExpectedOutput()
        {
            using var writer = new StringWriter();
            Console.SetOut(writer);

            var service = new EmailService();
            service.Send("wrong@user.com", "admin@site.com");

            writer.ToString().Trim().Should().Be("Invalid message", "This is a failure test case");
        }
    }
}
