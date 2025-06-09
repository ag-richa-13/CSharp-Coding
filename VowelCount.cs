// Write a function to count the number of vowels in a string.

using System;

public class VowelCount
{
     static int CountVowels(string input)
     {
          char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
          int count = 0;
          foreach (char c in input.ToLower())
          {
               foreach (char v in vowels)
               {
                    if (c == v)
                    {
                         count++;
                         break;
                    }
               }
          }
          return count;

     }
     public static void Main(string[] args)
     {
          string input = "I am Richa Agrawal";
          Console.Write("Vowels in input: " + CountVowels(input));
     }
}