using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[AttributeUsage(AttributeTargets.Property)]
public class DisplayLabelAttribute : Attribute
{
    public string Label { get; }

    public DisplayLabelAttribute(string label)
    {
        Label = label;
    }
}
