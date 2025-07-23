namespace ManagementAPI._1
{
    public class Send
    {
        public void SendEmail(Report report, string recipientEmail)
        {
            Console.WriteLine($"'{report.Content}' send to {recipientEmail}");
        }  
    }
}
