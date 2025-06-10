// Find Unique Value in an Array

using System;

public class UniqueInteger
{
     static int UniqueNum(int[] arr)
     {
          int res = 0;

          for (int i = 0; i < arr.Length; i++)
          {
               res ^= arr[i];
          }
          return res;
     }
     public static void Main(string[] args)
     {
          int[] arr = { 12, 42, 21, 12, 21, 42, 76 };

          Console.Write("Unique Value: " + UniqueNum(arr));
     }
}