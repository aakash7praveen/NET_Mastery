using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class OldPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("OldPrinter : Printing...");
        }
    }
}
