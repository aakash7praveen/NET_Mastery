using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;

class Program
{
    static async Task Main(string[] args)
    {
        string apiUrl = "https://jsonplaceholder.typicode.com/posts";
        string localFilePath = "posts.json";

        Stopwatch stopwatch = new Stopwatch();
        try
        {
            stopwatch.Start();

            Console.WriteLine("Fetching and Writing...");
            await FetchAndSaveApiDataAsync(apiUrl, localFilePath);

            Console.WriteLine("Reading the file...");
            string fileContent = await ReadFileAsync(localFilePath);

            stopwatch.Stop();

            Console.WriteLine("File content read from saved API response:\n");
            Console.WriteLine(fileContent.Substring(0, 500));
            Console.WriteLine();
            Console.WriteLine($"\nTime taken: {stopwatch.ElapsedMilliseconds} ms");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            stopwatch.Stop(); 
        }
    }

    static async Task<string> ReadFileAsync(string filePath)
    {
        return await File.ReadAllTextAsync(filePath);
    }

    static async Task FetchAndSaveApiDataAsync(string url, string savePath)
    {
        using HttpClient client = new HttpClient();
        string response = await client.GetStringAsync(url);

        await File.WriteAllTextAsync(savePath, response);
    }
}
