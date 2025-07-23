namespace ManagementAPI._1
{
    public class Saver
    {
        public void SaveTofile(string FilePath, Report report)
        {
            System.IO.File.WriteAllText(FilePath, report.Content);
            Console.WriteLine("File Created Successfully");
        }
    }
}
