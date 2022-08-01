using System;

namespace CheckPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckPermutations2("Hello World!", "Wld!or oellH"));
        }

        static bool CheckPermutations(string s, string t)
        {
            if(s.Length != t.Length)
                return false;

            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();

            Array.Sort(sArray);
            Array.Sort(tArray);

            for(int i=0; i < s.Length; i++)
            {
                if(!sArray[i].Equals(tArray[i]))
                    return false;
            }

            return true;
        }

        static bool CheckPermutations2(string s, string t)
        {
            if(s.Length != t.Length)
                return false;

            int[] letters = new int[128];

            for(int i=0; i < s.Length; i++)
            {
                letters[s[i]]++;
            }

            for(int i=0; i < t.Length; i++)
            {
                letters[t[i]]--;
                if(letters[t[i]] < 0)
                    return false;
            }

            return true;
        }
    }
}
