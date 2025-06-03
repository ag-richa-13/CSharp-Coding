// Decimal To binary Conversion using stack

using System;
using System.Collections.Generic;

public class DecimalToBinary
{
     static Stack<int> BinaryConversion(int n)
     {
          Stack<int> ans = new Stack<int>();
          if (n == 0)
          {
               ans.Push(0);
               return ans;
          }
          while (n > 0)
          {
               int rem = n % 2;
               n = n / 2;
               ans.Push(rem);
          }
          return ans;
     }
     public static void Main(string[] args)
     {
          int n = 10;
          Console.WriteLine("Binary: ");
          for (int i = 0; i <= n; i++)
          {
               Stack<int> ans = BinaryConversion(i);
               while (ans.Count > 0)
               {
                    Console.Write(ans.Pop());

               }
               Console.WriteLine();
          }


     }
}