// Write a function to add two numbers.

using System;

public class SumOfTwoNumber
{
     static int Sum(int a, int b)
     {
          int sum = 0;
          sum = a + b;
          return sum;
     }
     public static void Main(string[] args)
     {
          int a = 10;
          int b = 90;

          Console.Write("Sum: " + Sum(a, b));
     }
}