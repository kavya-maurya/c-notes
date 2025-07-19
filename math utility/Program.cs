using System;

public static class MathUtils
{
    // Static method to calculate the square of a number
    public static int Square(int number)
    {
        return number * number;
    }

    // Static method to check if a number is even
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // Static method to find the maximum of two numbers
    public static int Max(int a, int b)
    {
        return Math.Max(a,b);
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Square of 5: " + MathUtils.Square(5));
        Console.WriteLine("Is 8 even? " + MathUtils.IsEven(8));
        Console.WriteLine("Max of 10 and 20: " + MathUtils.Max(10,20));

    double x = 4;
    double y = 5;

    Console.WriteLine(Math.Sqrt(x));
    Console.WriteLine(Math.Pow(x,2));
    Console.WriteLine(Math.Round(x/y));
    Console.WriteLine(Math.Ceiling(y/x));   //rounds off to above value
    Console.WriteLine(Math.Floor(y/x));     //rounds off to lower value
    Console.WriteLine(Math.Max(y,x));   
    Console.WriteLine(Math.Min(y,x));

    



    }
}