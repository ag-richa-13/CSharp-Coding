// Intersection of 2 arrays

using System;
using System.Collections.Generic;

public class Intersection
{
     static Stack<int> IntersecNum(int[] arr1, int[] arr2)
     {
          int n = arr1.Length;
          int m = arr2.Length;
          Stack<int> res = new Stack<int>();
          for (int i = 0; i < n; i++)
          {
               for (int j = 0; j < m; j++)
               {
                    if (arr1[i] == arr2[j])
                    {
                         if (!res.Contains(arr1[i]))
                         {
                              res.Push(arr1[i]);
                         }
                    }
               }
          }
          return res;
     }
     public static void Main(string[] args)
     {
          int[] arr1 = { 1, 4, 3, 9, 2 };
          int[] arr2 = { 3, 6, 8, 2, 7 };

          Stack<int> res = IntersecNum(arr1, arr2);
          Console.Write("Intersection Point: ");
          while (res.Count > 0)
          {
               Console.Write(res.Pop() + " ");
          }

     }
}