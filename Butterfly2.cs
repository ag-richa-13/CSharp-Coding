// Butterfly 2 Pattern

using System;

public class Butterfly2

{
     public static void Main(string[] args)
     {
          int n = 4;
          // Top Part
          for (int i = 0; i < n; i++)
          {
               for (int j = 1; j <= i + 1; j++)
               {
                    Console.Write("*");
               }
               // for space
               for (int sp = 0; sp < 2 * (n - i - 1); sp++)
               {
                    Console.Write(" ");
               }
               for (int j = 1; j <= i + 1; j++)
               {
                    Console.Write("*");
               }
               Console.WriteLine();
          }
          // Bottom Part
          for (int i = 0; i < n; i++)
          {
               for (int j = 1; j <= n - i; j++)
               {
                    Console.Write("*");
               }
               // For Space
               for (int sp = 0; sp < 2 * i; sp++)
               {
                    Console.Write(" ");
               }
               for (int j = 1; j <= n - i; j++)
               {
                    Console.Write("*");
               }
               Console.WriteLine();
          }

     }
}


/*
*             * 
* *         * * 
* * *     * * * 
* * * * * * * * 
* * * * * * * * 
* * *     * * * 
* *         * * 
*             * 
*/