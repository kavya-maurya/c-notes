using System;
using System.IO;

class Program
{
    static void Main()
    {
        string folder = "data";
        string fileName = "info.txt";
        string fullPath = Path.Combine(folder, fileName);

        try
        {
            // Ensure directory exists
            Directory.CreateDirectory(folder);

            // Write to file
            File.WriteAllText(fullPath, "Learning file paths and exceptions!");

            // Read from file
            string content = File.ReadAllText(fullPath);
            Console.WriteLine("Read from file: " + content);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

