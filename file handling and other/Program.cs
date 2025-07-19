using System;
using System.IO;


namespace Project
{
    class Program
    {
        static void Main(string[]args)
        {

         string filePath = "k.pdf";
        string content = File.ReadAllText(filePath);            //used to read text from file and print on terminal
        Console.WriteLine("File Content:\n" + content);

         //  File.WriteAllText("kavya.pdf", "Hello, world!\nWelcome to C# file handling ..");

        File.WriteAllText("new.pdf", " hey!00");  // directly makes pdf



        }
    }
}