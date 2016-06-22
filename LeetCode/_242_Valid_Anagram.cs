using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _242_Valid_Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s == null || t == null) return false;

            if (s.Length != t.Length) return false;

            var signatureS = new Dictionary<char, int>();
            foreach (var letter in s)
            {
                if (!signatureS.ContainsKey(letter))
                {
                    signatureS.Add(letter, 1);
                }
                else
                {
                    signatureS[letter]++;
                }
                
            }

            var signatureT = new Dictionary<char, int>();
            foreach (var letter in t)
            {
                if (!signatureT.ContainsKey(letter))
                {
                    signatureT.Add(letter, 1);
                }
                else
                {
                    signatureT[letter]++;
                }
            }

            foreach (var key in signatureS.Keys)
            {
                if (!signatureT.ContainsKey(key) || signatureS[key] != signatureT[key])
                {
                    return false;
                }
            }

            return true;


        }
    }
}
