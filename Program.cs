using System;
using System.Collections;

namespace practica4
{
  class Program
  {
    static void Main(string[] args)
    {
      Hashtable lookup = new Hashtable();

      lookup["0"] = "zero";
      lookup["1"] = "one";
      lookup["2"] = "two";
      lookup["3"] = "three";
      lookup["4"] = "four";
      lookup["5"] = "five";
      lookup["6"] = "six";
      lookup["7"] = "seven";
      lookup["8"] = "eight";
      lookup["9"] = "nine";

      string ourNumber = "888-555-1212";
      foreach (char c in ourNumber)
      {
        string digit = c.ToString();
        if (lookup.ContainsKey(digit))
        {
          Console.WriteLine(lookup[digit]);
        }
      }

    }
  }
}