using System;

namespace ReferenceTypeConstraintDemo
{
    public class Logger<T> where T : class
    {
        public void Log(T item)
        {
            Console.WriteLine($"Logging: {item}");
        }
    }

    class Program
    {
        static void Main()
        {
            var stringLogger = new Logger<string>();
            stringLogger.Log("Hello, Reference Type!");
        }
    }
}
