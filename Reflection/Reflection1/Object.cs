namespace ObjectInspectorTool.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public int Age { get; set; }

        public void Greet() => Console.WriteLine("Hello!");

        public string GetDetails() => $"{FirstName}, Age {Age}";
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public void ApplyDiscount(decimal percent)
        {
            Price -= Price * (percent / 100);
        }
    }
}
