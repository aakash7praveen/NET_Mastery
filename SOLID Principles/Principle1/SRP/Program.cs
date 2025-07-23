using ManagementAPI._1;

class Program
{
    static void Main()
    {
        var report = new Report("This is the quarterly report.");

        var saver = new Saver();
        saver.SaveTofile("report.txt", report);

        var emailSender = new Send();
        emailSender.SendEmail(report, "admin@example.com");
    }
}