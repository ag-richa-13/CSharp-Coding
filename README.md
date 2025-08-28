# C# Coding Examples

This repository contains various C# coding examples, demonstrating different programming concepts and algorithms.

## Files:

- [ArraySum.cs](ArraySum.cs): Calculates the sum of elements in an array.
- [BinaryConversion.cs](BinaryConversion.cs): Converts decimal numbers to binary.
- [BinomialCoefficient.cs](BinomialCoefficient.cs): Computes the binomial coefficient.
- [BitwiseOperator.cs](BitwiseOperator.cs): Demonstrates various bitwise operations.
- [Butterfly1.cs](Butterfly1.cs): Prints a butterfly pattern (type 1).
- [Butterfly2.cs](Butterfly2.cs): Prints a butterfly pattern (type 2).
- [CToF.cs](CToF.cs): Converts Celsius to Fahrenheit.
- [DecimalConversion.cs](DecimalConversion.cs): Converts binary numbers to decimal.
- [Diamond.cs](Diamond.cs): Prints a diamond pattern.
- [EvenorOdd.cs](EvenorOdd.cs): Checks if a number is even or odd.
- [Factorial.cs](Factorial.cs): Calculates the factorial of a number.
- [Fibonacci.cs](Fibonacci.cs): Generates Fibonacci sequence.
- [HollowDiamond.cs](HollowDiamond.cs): Prints a hollow diamond pattern.
- [Intersection.cs](Intersection.cs): Finds the intersection of two arrays.
- [LinearSearch.cs](LinearSearch.cs): Implements a linear search algorithm.
- [MaxNumInArray.cs](MaxNumInArray.cs): Finds the maximum number in an array.
- [MaximumNumber.cs](MaximumNumber.cs): Finds the maximum of three numbers.
- [NumSquare.cs](NumSquare.cs): Returns the square of a number.
- [PrimeNumber.cs](PrimeNumber.cs): Checks if a number is prime and prints prime numbers up to N.
- [PrintGreeting.cs](PrintGreeting.cs): Prints a greeting message.
- [RandomNumber.cs](RandomNumber.cs): Generates a random number.
- [ReverseArray.cs](ReverseArray.cs): Reverses the elements of an array.
- [SumAndProduct.cs](SumAndProduct.cs): Calculates the sum and product of array elements.
- [SumOfTwoNumber.cs](SumOfTwoNumber.cs): Adds two numbers.
- [SwapMaxAndMin.cs](SwapMaxAndMin.cs): Swaps the maximum and minimum elements in an array.
- [UniqueInteger.cs](UniqueInteger.cs): Finds unique integers in an array.
- [VowelCount.cs](VowelCount.cs): Counts the number of vowels in a string.

### Leetcode Problems:

- [Leetcode/349_Intersection.cs](Leetcode/349_Intersection.cs): Leetcode problem 349 - Intersection of Two Arrays.
- [Leetcode/ReverseString.cs](Leetcode/ReverseString.cs): Leetcode problem - Reverse String.
- [Leetcode/SingleNumber.cs](Leetcode/SingleNumber.cs): Leetcode problem - Single Number.

## Important Definitions and Formulas:

### Binomial Coefficient:
- **Definition**: The number of ways to choose k items from a set of n items without replacement and without regard to the order of the items.
- **Formula**: ( n!) / (k! * (n-k)!)

### Fibonacci Sequence:
- **Definition**: A series of numbers in which each number is the sum of the two preceding numbers. The first two numbers in the series are 0 and 1.
- **Formula**: fib(n) = fib(n-1) + fib(n-2)

### Celsius to Fahrenheit Conversion:
- **Formula**: fahrenheit = (celsius * 9/5) + 32

### Factorial:
- **Definition**: The product of all positive integers less than or equal to a given positive integer.
- **Formula**: n! = n * (n-1) * (n-2) * ... * 1

### Reverse String Logic:
To reverse a string (represented as a character array `s`):
1. Initialize a stack to store characters.
2. Push each character from the input array `s` onto the stack.
3. Pop characters from the stack and overwrite the original array `s` from the beginning. This will place the characters in reverse order.
