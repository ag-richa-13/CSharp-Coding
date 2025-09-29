using System;

public class LinearSearch
{
     public static void Main(string[] args)
     {
          int[] arr = { 23, 56, 38, 20, 46, 32 };
          int n = arr.Length;
          int target = int.Parse(Console.ReadLine());
          bool found = false;

          for (int i = 0; i < n; i++)
          {
               if (arr[i] == target)
               {
                    Console.WriteLine("Found at index: " + i);
                    found = true;
                    break; // stop after first match
               }
          }

          if (!found)
          {
               Console.WriteLine("Not found");
          }
     }
}
