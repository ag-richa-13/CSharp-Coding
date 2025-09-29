using System;

public class MaxElement
{
     public static void Main(string[] args)
     {
          int[] arr = { 23, 56, 38, 20, 86, 32 };
          int n = arr.Length;
          int max = int.MinValue;
          int mx = int.MinValue;


          // // 1st approch
          for (int i = 1; i < n; i++)
          {
               if (max < arr[i])
               {
                    max = arr[i];
               }
          }

          // 2nd approach using Math.Max
          for (int j = 1; j < n; j++)
          {
               mx = Math.Max(mx, arr[j]);
          }

          Console.Write(max + ", " + mx);
     }
}
