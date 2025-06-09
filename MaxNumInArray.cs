// Write a function that takes a list of numbers and returns the maximum.

using System;

public class MaxNumInArray
{
     static int MaxInArray(int[] nums)
     {
          int maxNum = nums[0];
          for (int i = 1; i < nums.Length; i++)
          {
               if (nums[i] > maxNum)
               {
                    maxNum = nums[i];
               }
          }
          return maxNum;
     }
     public static void Main(string[] args)
     {
          int[] nums = { 20, 10, 4, 29, 43 };
          Console.Write("Max num in Array: " + MaxInArray(nums));
     }
}