using ISP;

class Program
{
    static void Main(string[] args)
    {
        IPrinter old = new OldPrinter();
        old.Print();

        Console.WriteLine();

        ModernPrinter modern = new ModernPrinter();
        modern.Print();
        modern.Scan();
        modern.Fax();
    }
}
