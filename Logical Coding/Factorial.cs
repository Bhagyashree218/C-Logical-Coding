//Find factorial of a number.
/*This program calculates the factorial of a given number using a loop. Factorial of a number n is the product of all positive integers less than or equal to n.

Example:
5! = 5 × 4 × 3 × 2 × 1 = 120 */

using System;

class Factorial
{
    static void Main(string[] args)
    {
        int num = 5;
        int fact = 1;
        
        for(int i=1; i<=num; i++)
        {
            fact = fact * i;
        }
        
        Console.WriteLine("Factorial of "+num+" = "+fact);
    }
}


//Factorial of 5 = 120
