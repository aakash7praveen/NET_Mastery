using System;
using ObjectInspectorTool.Models;

namespace ObjectInspectorTool
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Alice",
                Age = 30
            };

            var product = new Product
            {
                Id = 101,
                Name = "Laptop",
                Price = 999.99m
            };

            Console.WriteLine("== Person Object ==");
            Inspector.InspectObject(person);

            Console.WriteLine("\n== Product Object ==");
            Inspector.InspectObject(product);
        }
    }
}
