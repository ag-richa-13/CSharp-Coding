// Write a function that takes a Array and returns the sum of its elements

using System;

public class ArraySum
{
     static int SumOfArray(int[] nums)
     {
          int sum = 0;
          for (int i = 0; i < nums.Length; i++)
          {
               sum += nums[i];
          }
          return sum;
     }
     public static void Main(string[] args)
     {
          int[] nums = { 10, 23, 21, 65 };

          Console.Write("Sum: " + SumOfArray(nums));
     }
}