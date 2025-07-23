using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public interface INotificationHandler
{
    void Send(string To, string From);
}