// Generate a Random Number

using System;

public class RandomNumber
{
     public static void Main(string[] args)
     {
          Random rnd = new Random();

          double random = rnd.NextDouble();
          int randomInt = rnd.Next(20, 300);
          Console.Write(random + ", " + randomInt);

     }
}