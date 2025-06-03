using System;
using System.Collections.Generic;  // Add This 

public class Binary
{
     public static void Main(string[] args)
     {
          int n = 101010;   //number
          int pow = 0;    // power
          int decimalValue = 0;

          while (n > 0)
          {
               int rem = n % 10;
               n /= 10;
               decimalValue += rem * (int)Math.Pow(2, pow);
               pow++;
          }

          Console.Write(decimalValue);
     }
}


/*
n = 101010
ans = 1*2^5 + 0*2^4 + 1*2^3 + 0*2^2 + 1*2^1 + 0*2^0
ans = 32 + 0 + 8 + 0 + 2 + 0
ans = 42
*/