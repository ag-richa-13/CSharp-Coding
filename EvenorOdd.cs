// Write a function to check if a number is even or odd.

using System;

public class EvenOrOdd
{
     static void EvenOdd(int n)
     {
          if (n % 2 == 0)
          {
               Console.Write(n + " is even.");
          }
          else
          {
               Console.Write(n + " is odd.");
          }
     }
     public static void Main(string[] args)
     {
          int n = 26;
          EvenOdd(n);
     }
}