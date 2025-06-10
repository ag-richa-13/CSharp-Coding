// // Sum and Product of array

using System;

public class SumAndProduct
{
     // Return sum and Product
     static (int, int) SumProd(int[] arr)
     {
          int sum = 0;
          int prod = 1;

          for (int i = 0; i < arr.Length; i++)
          {
               sum += arr[i];
               prod *= arr[i];
          }
          return (sum, prod);
     }
     public static void Main(string[] args)
     {
          int[] arr = { 2, 4, 6, 1, 6 };

          Console.Write("Sum and Prod: " + SumProd(arr));
     }
}