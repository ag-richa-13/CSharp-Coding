using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
     public int SingleNumber(int[] nums)
     {
          int n = nums.Length;
          int res = 0;
          for (int i = 0; i < n; i++)
          {
               res ^= nums[i];   // using XOR 
          }
          return res;
     }
}