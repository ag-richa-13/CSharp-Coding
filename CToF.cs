// Write a function to convert Celsius to Fahrenheit

// Formula: fahrenheit = (celsius * 9/5) + 32

using System;

public class CToF
{
     static int CelsiusToFahrenheit(int c)
     {
          int f = (c * 9 / 5) + 32;
          return f;
     }
     public static void Main(string[] args)
     {
          int c = 25;
          Console.Write("Celsius to Fahrenheit: " + CelsiusToFahrenheit(c) + "degF");
     }
}