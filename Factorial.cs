// Factorial of N

using System;

public class Factorial
{
     // Approch 1: 
     static int FactorialOfN(int n)
     {
          int fact = 1;
          for (int i = 1; i <= n; i++)
          {
               fact *= i;
          }
          return fact;
     }

     // Approch 2: Recursion
     static int fact(int n)
     {
          if (n <= 1)
          {
               return n;
          }
          return n * fact(n - 1);
     }

     public static void Main(string[] args)
     {
          int n = 8;
          int m = 5;

          Console.WriteLine("Factorial of " + m + " using recursion: " + fact(m));

          Console.WriteLine("Factorial of " + n + " without recursion: " + FactorialOfN(n));
     }
}

// Output:
// Factorial of 8: 40320