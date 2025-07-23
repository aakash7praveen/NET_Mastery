using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class User
{
    [DisplayLabel("User Identifier")]
    public int Id { get; set; }

    [DisplayLabel("Full Name")]
    public string Name { get; set; }

    [DisplayLabel("Email Address")]
    public string Email { get; set; }
}
