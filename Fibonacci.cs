// Print Prime Number using Function

using System;

public class Fibonacci
{
     static int fib(int n)
     {
          if (n <= 1)
          {
               return n;
          }
          return fib(n - 1) + fib(n - 2);
     }
     public static void Main(string[] args)
     {
          int n = 8;
          Console.Write(fib(n));
          Console.WriteLine();
          for (int i = 0; i < n; i++)
          {
               Console.Write(fib(i) + " ");
          }
     }
}

// What is Fibonacci Number?
// Fibonacci series is a series of numbers in which each number is the sum of the two preceding numbers.
// The first two numbers in the series are 0 and 1.

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