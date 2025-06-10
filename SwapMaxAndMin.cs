// Swap Max and Min no. of array

using System;

public class SwapMaxAndMin
{
     static void SwapMinMax(int[] arr)
     {
          // Find min and max first
          int n = arr.Length;
          int min = n - 1;
          int max = 0;

          for (int i = 0; i < n; i++)
          {
               if (arr[i] > arr[max])
               {
                    max = i;
               }
               if (arr[i] < arr[min])
               {
                    min = i;
               }
          }
          // Swap Min and max
          int temp = arr[max];
          arr[max] = arr[min];
          arr[min] = temp;
     }
     public static void Main(string[] args)
     {
          int[] arr = { 12, 77, 98, 82, 10, 73 };

          SwapMinMax(arr); // call method first

          Console.Write("Swapped Array: ");
          Console.WriteLine(string.Join(", ", arr));
     }
}