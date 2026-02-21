//Check whether a number is prime.
/*This program checks whether a number is prime or not. A prime
number is divisible only by 1 and itself. The logic checks
divisibility from 2 up to n-1.
If number divisible by any number between 2 and n-1 → not prime.*/

using System;

class Prime
{
    static void Main(string[] args)
    {
        int num = 17;
        bool isPrime = true;
        
        if(num<=1)
        {
            isPrime=false;
        }
        
        //Better Optimization: A number cannot have factors greater than its square root.
        //for (int i = 2; i * i <= num; i++)
        //for (int i = 2; i <= num / i; i++)
        for(int i=2; i<=num/2; i++)
        {
            if(num%i==0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
            Console.WriteLine(num + " is a Prime Number");
        else
            Console.WriteLine(num + " is Not a Prime Number");
    }
}

//17 is a Prime Number
