using System;
using System.Collections.Generic;

namespace Collections
{
  class Program
  {
    static void Main(string[] args)
    {
      //List<T> is a generic type, a type that requires me to tell it what type of stuff it does/uses. 
      // The paramter that a list takes is a type paramater used to tell the List<T> how to work. <T> is a generic type in most use cases, we provide one type. 
     var e14Names = new List<string>();

      //Add a single item, works like push to append at end of list. 
      e14Names.Add("Casey");
      e14Names.Add("Dave");

      e14Names.Insert(1, "Juan");

      //Collection initializer. Pretty useful
      var teacherNames = new List<string> { "Nathan", "Jameka", "Dylan" };

      //You can add one list to another, as long as the TYPE being passed in is IEnumerable/collection
      e14Names.AddRange(teacherNames);

      //Remove uses a thing called reference equality. 
      e14Names.Remove("Dave");

      //Remove at index
      e14Names.RemoveAt(1);

      //Remove by expression
      e14Names.RemoveAll(name => name.StartsWith("D"));

      //loop 
      foreach (var name in e14Names)
      {
        Console.WriteLine($"{name} is in E14!");
      }
    }
  }
}
