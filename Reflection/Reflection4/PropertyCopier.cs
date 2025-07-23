using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

public static class PropertyCopier
{
    public static void CopyMatchingProperties(object source, object target)
    {
        var sourceProps = source.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var targetProps = target.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var sourceProp in sourceProps)
        {
            var targetProp = Array.Find(targetProps, p =>
                p.Name == sourceProp.Name &&
                p.PropertyType == sourceProp.PropertyType &&
                p.CanWrite);

            if (targetProp != null)
            {
                var value = sourceProp.GetValue(source);
                targetProp.SetValue(target, value);
            }
        }
    }
}

