//Check whether a string is palindrome.
/*This program checks whether a given string is a palindrome. A
palindrome is a word that reads the same forward and backward (e.g.,
"madam"). The logic compares characters from both ends moving toward
the center. 
Logic: Compare first character with last, second with second-last,
etc. */

using System;

class Palindrome
{
    static void Main(string[] args)
    {
        string str = "madam";
        bool isPalindrome = true;
        
        for(int i=0; i<str.Length; i++)
        {
            if(str[i] != str[str.Length-1-i])
            {
                isPalindrome = false;
                break;
            }
        }
        
        if(isPalindrome)
        {
            Console.WriteLine(str +" is a Palindrom");
        }
        else
        {
            Console.WriteLine(str +" is not a Palindrom");
        }
    }
}

//madam is a Palindrom
