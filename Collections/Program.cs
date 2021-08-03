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

      //Remove by expression. The fat arrow below is a predicate, returns a bool. 
      e14Names.RemoveAll(name => name.StartsWith("D"));

      //loop 
      foreach (var name in e14Names)
      {
        Console.WriteLine($"{name} is in E14!");
      }

      //List specific loop, .ForEach only available to List collection in C#. 
      //Optimized way to loop through a list. Actions don't return, essentially a void.
      e14Names.ForEach(name => Console.WriteLine($"{name} is a member of E14"));

      //Dictionary<TKey, TValue> -- Open Generic, has not specified what type of thing it is yet. 
      //like a physical dictionary, kinda. 
      //Keys have to be unique. 

      //Our dictionary is keyed by strings, and has string values 
      var dictionary = new Dictionary<string, string>(); //Closed generic, types have been defined. 

      dictionary.Add("Penultimate", "Second to last");
      dictionary.Add("Jib", "Triangular sail at the foremast of a sailing vessel");
      dictionary.Add("Arbitrary", "Someone who doesn't like Arby's");

      //Index on the TKey. 
      var definition = dictionary["Jib"];

      //Won't work : dictionary requires each key to be unique. 
      //dictionary.Add("Penultimate", "Things said too many times in the olympics");

      //Method to assist you, try will prevent an exception/error. 
      dictionary.TryAdd("Penultimate", "Things said too many times in the olympics");
      if (!dictionary.TryAdd("Penultimate", "Things said too many times in the olympics"))
      {
        Console.WriteLine("Its alreaded in the dictionary, I couldn't add it.");
      }

      if (dictionary.ContainsKey("Penultimate"))
      {
        dictionary["Penultimate"] = "Things said too many times in the Olympics.";
      }

      var allTheWords = dictionary.Keys;
      var allTheDefinitions = dictionary.Values;

      //looping in a dictionary
      foreach(var pair in dictionary)
      {
        Console.WriteLine($"{pair.Key} : {pair.Value}");
      }

      //destructure the key:value pair in a dictionary.
      foreach (var (word, def) in dictionary)
      {
        Console.WriteLine($"{word} definitions is {def}");
      }
    }
  }
}
