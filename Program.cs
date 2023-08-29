using System;
using System.ComponentModel.DataAnnotations;

// Test the solution for base case and valid integers 
Console.WriteLine($"Largest binary gap in 1041 (5 Expected): {LargestBinaryGap(1041)}"); 
Console.WriteLine($"Test with int 430034 (3 Expected): {LargestBinaryGap(430034)}"); 
Console.WriteLine($"Test with int 5 (1 Expected): {LargestBinaryGap(5)}"); 
Console.WriteLine($"Test base case less than 3 digits in binary int 2 (0 Expected): {LargestBinaryGap(2)}"); 
Console.WriteLine($"Test base case negative integer -10 (Expected 0): {LargestBinaryGap(-10)}"); 
 

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
        
        /* 
        * My algorithmic solution 
        */

        // Maintain the largest zero-gap counted and
        // the current gap being counted 
        int largestGap = 0; 
        int currentGap = 0; 

        // Iterate the digits in the binary string right -> left 
        for (int i = 0; i < binaryString.Length; i++) {
            bool digit = (binaryString[i] == '1'); 
            if (digit) {
                // End count of zeros, set largestGap to currentGap if it is greater 
                // Reset current gap to zero ready for next count 
                // largestGap is unchanged when counting successive 1's 
                //          as currentGap will be zero 
                largestGap = Math.Max(largestGap, currentGap); 
                currentGap = 0; 
            }
            else
                currentGap++; 
        }

        return largestGap;
    }
}