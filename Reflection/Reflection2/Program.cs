using System;
using System.Reflection;

public class DynamicPropertySetter
{
    public static void SetPropertyValue(object obj, string propertyName, object value)
    {
        if (obj == null || string.IsNullOrWhiteSpace(propertyName))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        var prop = obj.GetType().GetProperty(propertyName,
                     BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);

        if (prop == null || !prop.CanWrite)
        {
            Console.WriteLine($"Property '{propertyName}' not found or is read-only.");
            return;
        }

        var convertedValue = Convert.ChangeType(value, prop.PropertyType);
        prop.SetValue(obj, convertedValue);
    }
}

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        var user = new User();

        DynamicPropertySetter.SetPropertyValue(user, "Name", "DummyName");
        DynamicPropertySetter.SetPropertyValue(user, "Age", 25);

        Console.WriteLine($"Name: {user.Name}, Age: {user.Age}");
    }
}
