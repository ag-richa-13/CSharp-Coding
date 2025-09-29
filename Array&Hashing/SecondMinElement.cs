using System;

public class SecondMinElement
{
     public static void Main(string[] args)
     {
          int[] arr = { 23, 56, 38, 20, 86, 32 };
          int n = arr.Length;
          int min = int.MaxValue;
          int smn = int.MaxValue;



          for (int i = 1; i < n; i++)
          {
               // 1st approch
               if (min > arr[i])
               {
                    min = arr[i];
               }

          }
          for (int i = 0; i < n; i++)
          {
               if (smn > arr[i] && arr[i] != min)
               {
                    smn = arr[i];
               }
          }

          Console.Write("Second Min: " + smn);
     }
}
