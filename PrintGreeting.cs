// Create a function that takes a name and prints a greeting.

using System;

public class PrintGreeting
{
     static void Greeting(string name)
     {
          Console.Write("Hello, " + name);
     }
     public static void Main(string[] args)
     {
          string name = Console.ReadLine();
          Greeting(name);
     }
}