using System;

namespace project
{
    class program
    {


// Procedural Oriented vs Object Oriented

        //Define
        static int Add(int a, int b)
        {
            int c = a+b;
            Console.WriteLine(c);
            return c;
        }

        static int Add(int a, int b, int c)
        {
            int d = a+b+c;
            Console.WriteLine(d);
            return d;
        }


        static int subtract(int a, int b)
        {
            return a-b;
        }


        static void Main (string[]args)
        {

            // int result= Add(10, 20);
            
            // int sub = subtract(10, 20);

            // int result2 = Add(10,20, 30);

            // Console.WriteLine(sub);
            // Console.WriteLine(result2);

            //     Console.WriteLine ("hello world");


            for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                
                continue;           
                          // break;   // Skip this iteration when i is 3
            }

            Console.WriteLine("i = " + i);
        }


        }
    }
}