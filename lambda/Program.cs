using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 1, 5, 10, 15, 20 };

        // Using lambda to filter even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Even Numbers:");
        foreach (int num in evenNumbers)
            Console.WriteLine(num);

        // Anonymous method example
        Action<string> greet = delegate (string name)
        {
            Console.WriteLine("Hi " + name);
        };

        greet("Bob");
    }
}

