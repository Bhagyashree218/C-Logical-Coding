//Palindrome Number
//Logic: reverse the number and check if both are same.

using System;
class PalindromeNumber
{
    static void Main(string[] args)
    {
        int num = 2345432;
        int temp = num;
        int rev = 0;
        
        if(num<0)
        {
            Console.WriteLine(num + " is not a palindrome");
            return;
        }
        
        while(temp>0)
        {
            int rem = temp%10;
            rev = rev*10 + rem;
            temp = temp/10;
        }
        
        if(num==rev)
        {
            Console.WriteLine(num + " is a palindrome");
        }
        else
        {
            Console.WriteLine(num + " is not a palindrome");
        }
    }
}

//2345432 is a palindrome
//Time Complexity : O(d) (where d = number of digits in the num)
//Space complexity: O(1)
