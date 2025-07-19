using System;

public interface IAnimal 
{
    void speak();
    

    void eat();
    

}

public class dog : IAnimal
{
    public void speak()
    {
        Console.WriteLine("i bark");
    }
     
     public void eat()
     {
        Console.WriteLine("i eat");
     }


}

public class cat : IAnimal
{
       public void speak()
    {
        Console.WriteLine("i speak");
    } 

    public void eat()
     {
        Console.WriteLine("i eat");
     }

}

class Program
{
    static void Main (string[]args)
    {

IAnimal dog = new dog() ;
IAnimal cat = new cat() ;

    dog.speak();
    cat.speak();






    }
}