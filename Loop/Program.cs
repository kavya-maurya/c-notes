using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //While Loop
            // int i = 0;
            // while(i<5)
            // {
            //    Console.WriteLine("Hello World");
            //    //i=i+1;
            //    i++;
            // }

            //For Loop
            // for(int i=0; i<=5; i++)
            // {
            //     Console.WriteLine("Hello World");
            // }


            //Do While
            // int i =6;
            // do{
            //   Console.WriteLine("Hello World");
            //   i++;
            // }
            // while(i<5);

string name = "Kavya Morya";

string name1 = "K1";
string name2 = "K2";
string name3 = "K3";
string name4 = "K4";

string[] names = {"Narayan", "Ram", "Krishna", "Kavya"};
            //Foreach Loop
            string[] fruits = {"apple", "Orange", "Bnana"};

            foreach (var fruit in fruits)
            {
                Console.Write(fruit);
            }

        }
    }
}
