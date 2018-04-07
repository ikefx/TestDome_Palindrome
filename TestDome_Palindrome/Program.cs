using System;
using System.Linq;
/* 
 * Write a function that checks if a given sentence is a palindrome. A palindrome is a word, phrase, verse, 
 * or sentence that reads the same backward or forward. Only the order of English alphabet letters 
 * (A-Z and a-z) should be considered, other characters should be ignored.  
 * 
 * For example, IsPalindrome("Noel sees Leon.") should return true as spaces, period, and case should be 
 * ignored resulting with "noelseesleon" which is a palindrome since it reads same backward and forward.
*/

namespace TestDome_Palindrome
{
    class TestDome_Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            char[] letters = word.ToCharArray(); //character array
            /* fill array with only letters from parameter string */
            letters = Array.FindAll<char>(letters, (c => (char.IsLetter(c) )));

            /* create a new string from character array */
            var newWord = new string(letters);

            /* create a copy of the previous string, reverse character order */
            var word2 = new string(newWord.Reverse().ToArray());

            /* return T/F, is newWord equal to word2? Palindrome would be true */
            return newWord.ToLower() == word2.ToLower();
        }


        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("Noel sees Leon."));
            Console.WriteLine(IsPalindrome("Noel sees Leon"));
            Console.WriteLine(IsPalindrome("Noel seesLeon"));
            Console.WriteLine(IsPalindrome("Deleveled"));
            Console.WriteLine(IsPalindrome(".D.eleveled..."));

            Console.ReadKey();
        }
    }
}
