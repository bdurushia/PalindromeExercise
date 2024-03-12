using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word)) return false;
            
            var reversedWord = new string(word.Reverse().ToArray()).ToLower();

            if (reversedWord == word.ToLower())
                return true;
            else
                return false;
                
        }
    }
}
