using System;

namespace MultipleConstraintsDemo
{
    public interface IIdentifiable
    {
        int Id { get; }
    }

    public class Employee : IIdentifiable
    {
        public int Id { get; set; } = 200;
        public override string ToString() => $"Employee with ID {Id}";
    }

    public class DataManager<T> where T : class, IIdentifiable, new()
    {
        public T CreateAndReturn()
        {
            T obj = new T();
            Console.WriteLine($"Created: {obj}");
            return obj;
        }
    }

    class Program
    {
        static void Main()
        {
            var manager = new DataManager<Employee>();
            var emp = manager.CreateAndReturn();
        }
    }
}

