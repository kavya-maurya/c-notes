using System;

class Program
{
    static void Main(string[]args)
    {
       // 1D Array 
       int[] numbers = new int[5];

       numbers[0] = 10;
       numbers[1] = 20;
       numbers[2] = 30;
       numbers[3] = 40;
       numbers[4] = 50;

       int[] nums = {1, 2, 3, 4, 5};

       string[] names= new string[5];

       names[0]="Nepali Kavya";
       names[1]="Japnese Kavya";
       names[2]="Chinese Kavya";

       Console.WriteLine(numbers[1]);
       Console.WriteLine(nums[2]);
       Console.WriteLine(names[2]);


       int[,]  matrix = new int[3, 2];

        matrix[0,0] = 1;
        matrix[0,1] = 20;
        matrix[1,0] =22;
        matrix[1,1] =21;
        matrix[2,0] =26;
        matrix[2,1] =22;

// Console.WriteLine(matrix[2,0]);

int[,] table = {
    {1, 2},
    {3, 4},
    {5, 6},
};

Console.WriteLine(table[1,0]);

        
    }


}
