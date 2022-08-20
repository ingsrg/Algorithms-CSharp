using System;

namespace CheckPermutations2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Console.WriteLine(CheckPermutations(str1, str2));
        }

        static bool CheckPermutations(string str1, string str2)
        {
            if(str1.Length != str2.Length)
                return false;

            int[] letters = new int[128];

            for(int i=0; i < str1.Length; i++)
            {
                letters[ str1[i]] ++;
            }

            for(int i=0; i < str2.Length; i++)
            {
                letters[str2[i]]--;
                if(letters[ str2[i]] < 0)
                    return false;
            }
            return true;
        }

        static bool CheckPermutations2(string str1, string str2)
        {
            if(str1.Length != str2.Length)
                return false;

            char[] str1Array = str1.ToCharArray();
            Array.Sort(str1Array);

            char[] str2Array = str2.ToCharArray();
            Array.Sort(str2Array);

            for(int i=0; i < str1.Length; i++)
            {
                if(str1Array[i] != str2Array[i])
                    return false;
            }
            return true;
        }
    }
}
