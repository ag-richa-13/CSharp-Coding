// Write a function that returns the maximum of three numbers.

using System;

public class MaximumNumber
{
     static void MaxNum(int a, int b, int c)
     {
          if (a > b && a > c)
          {
               Console.Write(a + " is greater.");
          }
          else if (b > c && b > a)
          {
               Console.Write(b + " is greater.");
          }
          else
          {
               Console.Write(c + " is greater.");
          }
     }
     public static void Main(string[] args)
     {
          int a = 10;
          int b = 19;
          int c = 80;

          MaxNum(a, b, c);
     }
}