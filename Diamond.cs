// Full Diamond

using System;

public class Diamond
{
     public static void Main(string[] args)
     {
          int n = 4;

          for (int i = 0; i < n; i++)
          {
               for (int sp = 0; sp < n - i - 1; sp++)
               {
                    Console.Write("   ");
               }
               for (int j = 1; j <= 2 * i + 1; j++)
               {
                    Console.Write("*".ToString().PadLeft(3));
               }
               Console.WriteLine();
          }
          for (int i = 0; i < n - 1; i++)
          {
               for (int sp = 0; sp < i + 1; sp++)
               {
                    Console.Write("   ");
               }
               for (int j = 1; j <= 2 * (n - 1 - i) - 1; j++)
               {
                    Console.Write("*".ToString().PadLeft(3));
               }
               Console.WriteLine();
          }
     }
}




/*
           *
        *  *  *
     *  *  *  *  *
  *  *  *  *  *  *  *
     *  *  *  *  *
        *  *  *
           *
*/