// Binomial Coefficient

using System;

public class Binomial
{

     /* Formula For Binomial Coefficient:
           ( n!) / (k! * (n-k)!)
     */
     static int Fact(int n)
     {
          if (n <= 1) return n;
          return n * Fact(n - 1);
     }
     static int BinomialCoeff(int n, int k)
     {
          int ans = Fact(n) / (Fact(k) * Fact(n - k));
          return ans;
     }
     public static void Main(string[] args)
     {
          int n = 4;
          int k = 2;
          Console.Write("Binomial Coefficient: " + BinomialCoeff(n, k));
     }
}