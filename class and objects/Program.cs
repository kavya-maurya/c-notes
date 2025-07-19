using System;
using System.IO;

namespace Project
{
    class Remote : IDisposable
    {

      private FileStream fileStream;

     public Remote()
    {
        fileStream = new FileStream("example.txt", FileMode.OpenOrCreate);
        Console.WriteLine("Remote initialized and file opened.");
    }


        // Method to display a message
        public void ControlMe()
        {
            Console.WriteLine("You pressed me!!!");
        }

        // Method to add two numbers
        public int Add(int a, int b)
        {
            return a + b;
        }


        public static void PrintMe()
        {
          Console.WriteLine("I am printme");
        }

        public void Dispose()
    {
        if (fileStream != null)
        {
            fileStream.Close();
            fileStream.Dispose(); // Optional, just to be safe
            fileStream = null;
            Console.WriteLine("File stream closed.");
        }

        Console.WriteLine("Remote object is being disposed.");
    }
    }

    class Program
    {
        static void Main(string[] args)
        {
          Remote obj=null;
//catch helps to deaalocate the method so that it doesntcrash
          try{
               // Constructor 

                Remote.PrintMe();

                obj = new Remote();
               obj.ControlMe();
               int sum = obj.Add(10,20);
               int sum1 = obj.Add(50,70);

               Console.WriteLine(sum);
               Console.WriteLine(sum1);

               Remote obj1 = new Remote();

               //  int numerator = 1;
               //  int denominator = 0;

               //  // This will throw a DivideByZeroException
               //  int result = numerator / denominator;

               //  Console.WriteLine("Result: " + result);
          }

          catch(DivideByZeroException ex)
          {
               Console.WriteLine("Blley Blley, Divide To nAHI KRNE DUGA ...");
          }

          catch(Exception ex)
          {
                Console.WriteLine("An unexpected error occurred: ");
          }

          finally{
                if (obj != null)
    {
        obj.Dispose(); // Manual disposal
    }
          }
          
     
        }
    }
}
