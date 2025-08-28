// Swap two Variable

using System;

public class Swap2Variable
{
     // First Method
     static (int, int) Swap(int x, int y)
     {
          int temp = 0;
          temp = x;
          x = y;
          y = temp;

          return (x, y);
     }
     public static void Main(string[] args)
     {
          int x = 12;
          int y = 20;

          Console.WriteLine(Swap(x, y));
     }
}