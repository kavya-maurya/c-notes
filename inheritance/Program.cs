using System;
namespace Project
{

//Inheritance

public class Animal{

    public void Eat(){

        Console.WriteLine("I am Eating, I am form Animal Class");
    }
}


public class Dog : Animal{

    public void Bark(){
        Console.WriteLine("I am Barking");
    }

    
}

public class Cat :Animal{

    public void Meow(){
        Console.WriteLine("I am Meow");
    }
}


    class Program
    {
        static void Main(string[]args)
        {
            
            Dog d1 = new Dog();
            d1.Bark();
            d1.Eat(); 
            

            Cat c1 = new Cat();
            c1.Meow();
            c1.Eat();
            
 
        }
    }
}