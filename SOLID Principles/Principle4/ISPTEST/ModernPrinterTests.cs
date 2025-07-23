using System;
using System.IO;
using FluentAssertions;
using Xunit;
using ISP;

namespace ISPTests
{
    public class ModernPrinterTests
    {
        [Fact]
        public void ModernPrinter_Should_Print_Correctly()
        {
            var printer = new ModernPrinter();
            var sw = new StringWriter();
            Console.SetOut(sw);

            printer.Print();
            var output = sw.ToString().Trim();

            output.Should().Be("ModernPrinter : Printing...");
        }

        [Fact]
        public void ModernPrinter_Should_Scan_Correctly()
        {
            var printer = new ModernPrinter();
            var sw = new StringWriter();
            Console.SetOut(sw);

            printer.Scan();
            var output = sw.ToString().Trim();

            output.Should().Be("ModernPrinter : Scanning...");
        }

        [Fact]
        public void ModernPrinter_Should_Fax_Correctly()
        {
            var printer = new ModernPrinter();
            var sw = new StringWriter();
            Console.SetOut(sw);

            printer.Fax();
            var output = sw.ToString().Trim();

            output.Should().Be("ModernPrinter : Faxing...");
        }

        [Fact]
        public void ModernPrinter_Should_Implement_All_Interfaces()
        {
            var printer = new ModernPrinter();

            (printer is IPrinter).Should().BeTrue();
            (printer is IScanner).Should().BeTrue();
            (printer is IFax).Should().BeTrue();
        }
    }
}
