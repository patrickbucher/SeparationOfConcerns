﻿using SeparationOfConcerns;

public class Program
{
    public static void Main()
    {
        // Example 1: Multiplication Table
        // MultiplicationTable.For(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

        // Example 2: Prime Factors
        PrimeFactors.Factor(new List<int>() { 100, 55, 90 });
    }
}
