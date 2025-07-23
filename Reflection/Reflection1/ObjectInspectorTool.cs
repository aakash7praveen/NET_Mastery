using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInspectorTool
{
    public static class Inspector
    {
        public static void InspectObject(object obj)
        {
            if (obj == null)
            {
                Console.WriteLine("Object is null.");
                return;
            }

            Type type = obj.GetType();

            Console.WriteLine($"Class: {type.Name}");
            Console.WriteLine("\nProperties:");
            foreach (var prop in type.GetProperties())
            {
                var value = prop.GetValue(obj);
                Console.WriteLine($"- {prop.PropertyType.Name} {prop.Name} = {value}");
            }

            Console.WriteLine("\nMethods:");
            foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                string parameters = string.Join(", ",
                    method.GetParameters().Select(p => $"{p.ParameterType.Name} {p.Name}"));

                Console.WriteLine($"- {method.ReturnType.Name} {method.Name}({parameters})");
            }
        }
    }
}
