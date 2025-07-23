using System;

namespace ValueTypeConstraintDemo
{
    public class MathOperations<T> where T : struct
    {
        public T Add(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }
    }

    class Program
    {
        static void Main()
        {
            var intOps = new MathOperations<int>();
            Console.WriteLine("10 + 20 = " + intOps.Add(10, 20));

            var doubleOps = new MathOperations<double>();
            Console.WriteLine("5.5 + 4.5 = " + doubleOps.Add(5.5, 4.5));
        }
    }
}
