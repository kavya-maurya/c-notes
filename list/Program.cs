using System;
using System.Collections.Generic;
 
 class Program
 {
    static void Main (string[]args)
    {

    //  List<string> list = new List<string>();

//       list.Add("kavya");
//       list.Add("narayan");
//       list.Add("anchal");
//     list.Insert(2 ,"kavya3");
//     // list.Remove("kavya3");
//     // list.RemoveAt(1);
//    // list.Sort();
//      list.Reverse();
//      list.IndexOf("kavya3");


//      Console.WriteLine(list.Count);
//      Console.WriteLine(list.Contains("kavyajgjgj"));


//       foreach(string name in list)
    //   {
    //      Console.WriteLine(name);
    //   }

       Dictionary<string, string> dict = new Dictionary<string, string>();
       dict.Add("Hello", "Namaste");
       dict.Add("Hello1", "Namaste1");
       dict.Add("Hello2", "Namaste2");
       dict.Add("Age", "24");
       dict.Remove("Age");
      Console.WriteLine(dict.ContainsKey("Age"));
      Console.WriteLine(dict["Hello"]);

        foreach(KeyValuePair<string, string> pair in dict)
      {
         Console.Write(pair.Key);
         Console.Write(" -> ");
         Console.Write(pair.Value);
         Console.WriteLine("");
         

      }
    }


 
 }