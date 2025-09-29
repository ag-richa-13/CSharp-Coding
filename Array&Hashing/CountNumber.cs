// Count No. of elements which is greater than x

using System;

public class CountNumber
{
     public static void Main(string[] args)
     {
          int[] arr = {45, 12, 78, 34, 89, 2, 99, 23, 56, 72,
             18, 90, 11, 67, 88, 120, 4, 39, 101, 200,
             76, 150, 3, 87, 65, 32, 14, 77, 50, 170,
             230, 12, 89, 45, 210, 5, 19, 99, 300, 400,
             220, 10, 250, 275, 150, 50, 33, 121, 88, 66};
          int n = arr.Length;
          int x = 89;
          int count = 0;

          for (int i = 0; i < n; i++)
          {
               if (arr[i] > x)
               {
                    count++;
               }
          }
          Console.Write(count);
     }
}
