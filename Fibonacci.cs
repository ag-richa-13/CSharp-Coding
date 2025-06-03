// Print Prime Number using Function

using System;

public class Fibonacci
{
     static int nthFibonacci(int n)
     {
          if (n <= 1)
          {
               return n;
          }
          return nthFibonacci(n - 1) + nthFibonacci(n - 2);
     }
     public static void Main(string[] args)
     {
          int n = 9;

          Console.WriteLine("Fibonacci: " + nthFibonacci(n));
          Console.Write("Fibonacci Series: ");
          for (int i = 0; i <= n; i++)
          {
               Console.Write(nthFibonacci(i) + " ");
          }

     }
}



/*
Formula: fib(n) = fib(n-1) + fib(n-2)

fib(4) = fib(4-1) + fib(4-2)
fib(4) = fib(3) + fib(2)
fib(4) = fib(3-1)+ fib(3-2) + fib(2-1) + fib(2-2)
fib(4) = fib(2) + fib(1) + fib(1) + fib(0)
fib(4) = fib(2-1) + fib(2-2) + fib(1) + fib(1) + fib(0)
fib(4) = fib(1) + fib(0) + fib(1) + fib(1) + fib(0)
fib(4) =   1    +    0   +   1   +   1    +   0
fib(4) =   3 
*/