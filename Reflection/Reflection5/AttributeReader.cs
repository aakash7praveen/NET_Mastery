using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

public static class AttributeReader
{
    public static void PrintDisplayLabels(object obj)
    {
        if (obj == null) return;

        var props = obj.GetType().GetProperties();

        foreach (var prop in props)
        {
            var attr = prop.GetCustomAttribute<DisplayLabelAttribute>();

            if (attr != null)
            {
                var value = prop.GetValue(obj);
                Console.WriteLine($"{attr.Label}: {value}");
            }
        }
    }
}

