using System;

namespace InterfaceConstraintDemo
{
    public interface IIdentifiable
    {
        int Id { get; }
    }

    public class Student : IIdentifiable
    {
        public int Id { get; set; } = 123;
        public override string ToString() => $"Student ID: {Id}";
    }

    public class DataStore<T> where T : IIdentifiable
    {
        public void PrintId(T item)
        {
            Console.WriteLine($"ID is: {item.Id}");
        }
    }

    class Program
    {
        static void Main()
        {
            var student = new Student();
            var store = new DataStore<Student>();
            store.PrintId(student);
        }
    }
}
