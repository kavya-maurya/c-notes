using System;
using System.Collections.Generic;
 
 class Program
 {
    static void Main (string[]args)
    {

      // Stack<string> stck = new Stack<string>();

      // stck.Push("Narayan");
      // stck.Push("Kavya");
      // stck.Push("Ravi");

      // stck.Pop();
      // stck.Pop();


      // foreach(string name in stck)
      // {
      //    Console.WriteLine(name);
      // }


      Queue<string> que = new Queue<string>();
      que.Enqueue("Narayan");
      que.Enqueue("Kavya");
      que.Enqueue("Arun");
      que.Enqueue("Sachin");

      que.Dequeue();

        foreach(string name in que)
      {
         Console.WriteLine(name);
      }

        
    }
 }