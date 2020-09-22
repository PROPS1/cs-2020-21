using System;
using System.Collections;

namespace practica4
{
  class Program
  {

    static void Main(string[] args)
    {
      ArrayList myList = new ArrayList() { "first" };
      myList.Add("second");
      myList.Add("third");
      myList.Add("fourth");
      foreach (string item in myList)
      {
        Console.WriteLine("Unsorted: {0}", item);
      }
      myList.Sort();
      foreach (string item in myList)
      {
        Console.WriteLine("   Sorted: {0}", item);
      }

    }

  }
}