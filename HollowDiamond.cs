// Full Hollow Diamond

using System;

public class HollowDiamond
{
     public static void Main(string[] args)
     {
          int n = 4;

          // Top Half
          for (int i = 0; i < n; i++)
          {
               for (int sp = 0; sp < n - i - 1; sp++)
               {
                    Console.Write(" ");
               }

               Console.Write("*");

               if (i != 0)
               {
                    for (int sp = 0; sp < 2 * i - 1; sp++)
                    {
                         Console.Write(" ");
                    }
                    Console.Write("*");
               }

               Console.WriteLine();
          }

          // Bottom Half
          for (int i = 0; i < n - 1; i++)
          {
               for (int sp = 0; sp <= i; sp++)
               {
                    Console.Write(" ");
               }

               Console.Write("*");

               if (i != n - 2)
               {
                    for (int sp = 0; sp < (n - 2 * i - 1); sp++)
                    {
                         Console.Write(" ");
                    }
                    Console.Write("*");
               }

               Console.WriteLine();
          }
     }
}





/*
   *
  * *
 *   *
*     *
 *   *
  * *
   *
*/