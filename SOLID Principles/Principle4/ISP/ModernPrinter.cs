using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class ModernPrinter : IPrinter, IScanner, IFax
    {
        public void Print()
        {
            Console.WriteLine("ModernPrinter : Printing...");
        }

        public void Scan()
        {
            Console.WriteLine("ModernPrinter : Scanning...");
        }

        public void Fax()
        {
            Console.WriteLine("ModernPrinter : Faxing...");
        }
    }
}
