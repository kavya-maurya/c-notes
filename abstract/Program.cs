using System;

abstract class  Animal
{
    public abstract void speak();


    public abstract void eat();


    public void sleep()
    {
        Console.WriteLine("animal is sleeping");
    }


}


class dog : Animal 
{
     public override void speak()
    {
        Console.WriteLine("i bark");
    }
     
     public override void eat()
     {
        Console.WriteLine("i eat");
     }


}

class cat : Animal

{
     public override void speak()
    {
        Console.WriteLine("i speak");
    }
     
     public override void eat()
     {
        Console.WriteLine("i eat");
     }


}


class Program
{
    static void Main (string[]args)
    {


            Animal dog = new dog();
            Animal cat = new cat();

        dog.speak();
        dog.eat();
        dog.sleep();


        cat.speak();
        cat.eat();
        cat.sleep();
        

    }
}