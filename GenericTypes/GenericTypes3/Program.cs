using System;

namespace NewConstraintDemo
{
    public class MyFactory<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T();
        }
    }

    public class Product
    {
        public string Name { get; set; } = "Sample Product";
        public override string ToString() => $"Product: {Name}";
    }

    class Program
    {
        static void Main()
        {
            var factory = new MyFactory<Product>();
            var product = factory.CreateInstance();
            Console.WriteLine(product);
        }
    }
}
