namespace Leetcode;

public class ValidAnagram
{
    public class Solution {
        public bool IsAnagram2(string s, string t)
        {
            if(s == t) return true;
                if(s.Length != t.Length) return false;
            var dictS = new Dictionary<char, int>();
            var dictT = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (dictS.ContainsKey(c))
                {
                    dictS[c]++;
                }
                else
                {
                    dictS.Add(c, 1);
                }
            }
            foreach (var c in t)
            {
                if (dictT.ContainsKey(c))
                {
                    dictT[c]--;
                    if (dictT[c] == 0)
                        dictT.Remove(c); 
                }
                else
                {
                    return false;
                }
            }

            return !dictT.Any();
        }
        
        public bool IsAnagram(string s, string t)
        {
            // sorts the s string
            var sortedS = s.ToCharArray();
            Array.Sort(sortedS);
            // sorts the t string
            var sortedT = t.ToCharArray();
            Array.Sort(sortedT);
            // compares the two strings
            return sortedS.SequenceEqual(sortedT);
        }
        
        public bool IsAnagram3(string s, string t)
        {
            var chars = s.ToCharArray().ToList();
            var chars2 = t.ToCharArray().ToList();
            foreach (var c in chars2)
            {
                if (!chars.Remove(c)) return false;
            }

            return !chars.Any();
        }
    }
}