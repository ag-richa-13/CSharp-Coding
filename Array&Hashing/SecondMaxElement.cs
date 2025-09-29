using System;

public class SecondMaxElement
{
     public static void Main(string[] args)
     {
          int[] arr = { 23, 56, 38, 20, 86, 32 };
          int n = arr.Length;
          int max = int.MinValue;
          int smx = int.MinValue;


          for (int i = 1; i < n; i++)
          {
               if (max < arr[i])
               {
                    max = arr[i];
               }

          }
          for (int i = 0; i < n; i++)
          {
               if (smx < arr[i] && arr[i] != max)
               {
                    smx = arr[i];
               }
          }



          Console.Write("Second Max: " + smx);
     }
}
