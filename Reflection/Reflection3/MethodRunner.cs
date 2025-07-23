using System.Reflection;

public static class MethodRunner
{
    public static void RunMethod(object obj, string methodName, params object[] parameters)
    {
        if (obj == null || string.IsNullOrWhiteSpace(methodName))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        var method = obj.GetType().GetMethod(methodName,
            BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);

        if (method == null)
        {
            Console.WriteLine($"Method '{methodName}' not found.");
            return;
        }

        method.Invoke(obj, parameters);
    }
}
