using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter A Number 1-3");
            int number = Convert.ToInt32(Console.ReadLine());

            //Switch Statement
            switch(number)
            {
                case 1:
                Console.WriteLine("You entered 1 - Will be dropped on floor 1");
                break;

                case 2:
                Console.WriteLine("You entered 2 - Will be dropped on floor 2");
                break;

                case 3:
                Console.WriteLine("You entered 3 - Will be dropped on floor 3");
                break;

                default:
                Console.WriteLine("Please enter valid input, 1-3");
                break;
                

            }


          
        }
    }
}
