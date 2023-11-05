using System.Text.RegularExpressions;

namespace Leetcode;

public class ValidPalindrome
{
    public class Solution {
        public bool IsPalindrome(string s) {
            // Remove all non alphanumeric characters
            s = Regex.Replace(s, @"[^0-9a-zA-Z]+", "").ToLower();
            return s.Equals(Reverse(s));
        }

        private object? Reverse(string s)
        {
            var charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}