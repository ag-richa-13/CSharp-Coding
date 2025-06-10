// Reverse an Array

using System;

public class ReverseArray
{
     static void ReverseAnArray(int[] arr)
     {
          int n = arr.Length;
          int temp = 0;

          for (int i = 0; i < n / 2; i++) // fix: only go till middle
          {
               temp = arr[i];
               arr[i] = arr[n - i - 1];
               arr[n - i - 1] = temp;
          }
     }

     public static void Main(string[] args)
     {
          int[] arr = { 12, 77, 98, 82, 10, 73 };

          ReverseAnArray(arr); // call method first

          Console.Write("Reversed Array: ");
          Console.WriteLine(string.Join(", ", arr)); // print array after reversing
     }
}
