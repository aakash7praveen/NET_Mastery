using System;
using System.Reflection;

public class Person
{
    private string secret = "Original Secret";

    public void ShowSecret()
    {
        Console.WriteLine($"Secret: {secret}");
    }
}

class Program
{
    static void Main()
    {
        var person = new Person();
        person.ShowSecret();
        

        Type type = typeof(Person);

        FieldInfo field = type.GetField("secret", BindingFlags.Instance | BindingFlags.NonPublic);

        if (field != null)
        {
            string originalValue = (string)field.GetValue(person);
            Console.WriteLine($"Read via reflection: {originalValue}");

            field.SetValue(person, "Hacked Secret");
        }

        person.ShowSecret();  
    }
}
