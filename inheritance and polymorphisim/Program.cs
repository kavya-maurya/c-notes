using System;
namespace Project
{
   class Animal
   {
    public virtual void Sound()
    {
        Console.WriteLine("we make sound!");
    }

    public  virtual void Move()
    {
        Console.WriteLine("we move around ");
    }


    public  virtual void Food()
    {
        Console.WriteLine("we love to eat");
    }

    public  virtual void introduction()
    {
        Console.WriteLine(" ");
    }

    public virtual void Color()
    {
        Console.WriteLine(" do u wonder what's my color?");
    }
    
    }

     class cat : Animal   {

    public override void introduction()
    {
        Console.WriteLine("that's how i look like ___         (=◉ᆽ◉=)  ");
    }


    public override void Sound()
    {
        Console.WriteLine("(=◉ᆽ◉=)    i meow!");
    }
    
    public override void Food()
    {
        Console.WriteLine("(=◉ᆽ◉=)    i drink milk!");
    }
      public  virtual void Move()
    {
        Console.WriteLine(" i move silently");
    }
    }

      class dog : Animal
   {
    public override void introduction()
    {
        Console.WriteLine("that's how i look like ___           ૮ ˙ ﻌ˙ ა");
    }


    public override void Sound()
    {
        Console.WriteLine("૮ ˙ ﻌ˙ ა   i bark!");
    }

    public override void Food()
    {
        Console.WriteLine("૮ ˙ ﻌ˙ ა   i eat biscuits");
    }

      public  virtual void Move()
    {
        Console.WriteLine("i run on four legs ");
    }
    
    }

  class cow : Animal
   {
     public override void introduction()
    {
        Console.WriteLine("that's how i look like ___           𓃓");
    }
    
    public override void Sound()
    {
        Console.WriteLine("𓃓  i moo!");
    }

    public override void Food()
    {
        Console.WriteLine("𓃓  i eat green grass");
    }
    
    public override void Color()
    {
        Console.WriteLine("𓃓  i'm white and black spotted");
    }

    
    }






  



    class Program
    {
        static void Main(string[]args)
        {

        Animal cat = new cat();
            Animal cow = new cow();
            Animal a = new Animal();
            Animal dog = new dog ();

 Console.WriteLine("let's Learn about animals!");


                
            for (int p = 1 ; p<=3 ; p++)         
{
            Console.WriteLine("which  animal you want to Learn about!");
            Console.WriteLine("1 - cat!");
            Console.WriteLine("2 - cow!");
            Console.WriteLine("3 - dog!");

            int choice = Convert.ToInt32(Console.ReadLine());

try{
                switch (choice)
              {

                  case 1 :  
                    cat.introduction();
                  cat.Sound();
                    cat.Food();
                    cat.Move();

                 break;
                    
                case 2:
                    cow.introduction();
                 cow.Sound();
                    cow.Food();
                    cow.Color();
                    
                break ;

                case 3:
                    dog.introduction();
                  dog.Sound();
                    dog.Food();
                    dog.Move();

                break;  
                   
                }
}
catch(Exception ex){
    Console.WriteLine(ex);
}
}


Console.WriteLine(" ");


                Animal[] animals = {cat,dog,cow};
            foreach (Animal animal in animals)
                { 

           

            animal.introduction();
                  animal.Sound();
                    animal.Food();

                }
           
                
               





        }
    }
}