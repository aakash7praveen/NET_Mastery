using DIP;

class Program
{
    static void Main(string[] args)
    {
        INotificationHandler notify = new EmailService();
        NotificationManager manage = new NotificationManager(notify);

        manage.SendNotifications("user@example.com", "admin@example.com");
    }
}