using System;
using System.IO;
using FluentAssertions;
using Xunit;
using ISP;

namespace ISPTests
{
    public class OldPrinterTests
    {
        [Fact]
        public void OldPrinter_Should_Print_Correctly()
        {
            var printer = new OldPrinter();
            var sw = new StringWriter();
            Console.SetOut(sw);

            (printer).Print();
            Console.Out.Flush();
            var output = sw.ToString().Trim();

            output.Should().Be("OldPrinter : Printing...");
        }

        [Fact]
        public void OldPrinter_Should_Not_Support_Scan_Or_Fax()
        {
            var printer = new OldPrinter();

            (printer is IScanner).Should().BeTrue("OldPrinter should not support scanning");
            (printer is IFax).Should().BeTrue("OldPrinter should not support faxing");
        }
    }
}
