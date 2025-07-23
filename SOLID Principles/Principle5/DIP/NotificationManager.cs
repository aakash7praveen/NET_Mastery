using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class NotificationManager
    {
        private readonly INotificationHandler _notificationHandler;

        public NotificationManager(INotificationHandler notificationHandler)
        {
            _notificationHandler = notificationHandler;
        }

        public void SendNotifications(string To, string From)
        {
            _notificationHandler.Send(To, From);
        }
    }
}
