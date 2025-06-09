// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class BitwiseOperator
{
     public static void Main(string[] args)
     {
          int a = 6, b = 10, c = 1, d = 2;
          // And Operator
          Console.WriteLine("AND: " + (a & b));

          // OR Operator
          Console.WriteLine("OR: " + (a | b));

          // XOR Operator
          Console.WriteLine("XOR: " + (a ^ b));

          // Left Shift Operator
          Console.WriteLine("Left Shift: " + (b << d));

          // Right Shift Operator
          Console.WriteLine("Right Shift: " + (b >> c));
     }
}