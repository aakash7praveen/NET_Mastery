public class Program
{
    public static void Main()
    {
        var source = new SourceClass
        {
            Id = 100,
            Name = "Aakash",
            ExtraProperty = "Extra"
        };

        var target = new TargetClass();

        PropertyCopier.CopyMatchingProperties(source, target);

        Console.WriteLine($"Id: {target.Id}");      
        Console.WriteLine($"Name: {target.Name}");  
        Console.WriteLine($"Description: {target.Description}");  
    }
}
