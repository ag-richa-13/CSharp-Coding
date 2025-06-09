// Write a function that returns the square of a number.

using System;

public class NumSquare
{
     static int SqrOfNum(int num)
     {
          int pow = 2;
          int Square = (int)Math.Pow(num, pow);
          return Square;
     }
     public static void Main(string[] args)
     {
          int num = Convert.ToInt32(Console.ReadLine());

          Console.Write("Square of " + num + ": " + SqrOfNum(num));
     }
}