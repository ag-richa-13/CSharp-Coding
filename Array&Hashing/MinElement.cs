using System;

public class MinElement
{
     public static void Main(string[] args)
     {
          int[] arr = { 23, 56, 38, 20, 86, 32 };
          int n = arr.Length;
          int min = int.MaxValue;
          int mn = int.MaxValue;



          for (int i = 1; i < n; i++)
          {
               // 1st approch
               if (min > arr[i])
               {
                    min = arr[i];
               }
               // 2nd Approach
               mn = Math.Min(mn, arr[i]);
          }

          Console.Write(min + ", " + mn);
     }
}
