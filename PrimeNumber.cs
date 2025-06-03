// Prime Number or Not
using System;

public class PrimeNumber
{
     static bool FindPrime(int n)
     {
          if (n <= 0)
          {
               return false;
          }
          for (int i = 2; i <= n / 2; i++)
          {
               if (n % i == 0)
               {
                    return false;
               }
          }
          return true;
     }
     // Print Prime Number 1 to N
     static void PrintPrime(int n)
     {
          for (int i = 2; i <= n; i++)
          {
               if (FindPrime(i))
               {
                    Console.Write(i + " ");
               }
          }
     }
     public static void Main(string[] args)
     {
          int n = 7;
          int m = 100;
          Console.Write("Ans: " + FindPrime(n));
          Console.WriteLine();
          PrintPrime(m);
     }
}