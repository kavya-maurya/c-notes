using System;

class Program
{
    // Define a delegate
    public delegate void Greeting(string name);

    // Method to match delegate signature
    static void SayHello(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    static void Main()
    {
        Greeting kavya = SayHello;
        kavya("Alice");
    }
}
