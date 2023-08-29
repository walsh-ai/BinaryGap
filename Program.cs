using System;
using System.ComponentModel.DataAnnotations;

// Test the solution 
int result = LargestBinaryGap(1041); 
Console.WriteLine($"Largest binary gap in 1041: {result}"); 
Console.WriteLine($"Test with small number (2): {LargestBinaryGap(2)}"); 
Console.WriteLine($"Test with (5): {LargestBinaryGap(5)}"); 
Console.WriteLine($"Test with (-10): {LargestBinaryGap(-10)}"); 
Console.WriteLine($"Test with (430034): {LargestBinaryGap(430034)}"); // Should be 3 

public static partial class Program {
    /// <summary>
    /// Return the largest binary gap (consecutive zeros between 1s)
    /// in the binary representation of a given integer.
    /// </summary>
    /// <param name="x">The integer to examine</param>
    /// <returns></returns>
    public static int LargestBinaryGap(int x) {
        // Convert integer to string representation in Base 2 
        string binaryString = Convert.ToString(x, 2); 

        // Base: Minimum digits to form a binary gap and positive integer
        if ((x < 0) || binaryString.Length < 3) 
            return 0; 
        
        // The algorithm 
        int largestGap = 0; 
        int currentGap = 0; 

        for (int i = 0; i < binaryString.Length; i++) {
            bool digit = (binaryString[i] == '1'); 
            if (digit) {
                largestGap = Math.Max(largestGap, currentGap); 
                currentGap = 0; 
            }
            else
                currentGap++; 
        }

        return largestGap;
    }
}