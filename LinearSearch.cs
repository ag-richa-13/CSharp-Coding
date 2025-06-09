// Linear Search

using System;

public class LinearSearch
{
     static int LinearSearchInArr(int[] arr, int target)
     {

          for (int i = 0; i < arr.Length; i++)
          {
               if (target == arr[i])
               {
                    return i;
               }
          }
          return -1;
     }
     public static void Main(string[] args)
     {
          int[] arr = { 12, 77, 98, 82, 10, 73 };
          int target = 82;

          Console.Write("Target Index: " + LinearSearchInArr(arr, target));
     }
}