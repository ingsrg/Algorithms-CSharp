using System;

namespace IsUniqueChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsUniqueChar("Helo Ward"));
        }

        static bool IsUniqueChar(string w)
        {
            int checker = 0;

            for(int i=0; i < w.Length; i++)
            {
                int val = w[i] - 'a';
                if( (int) ( checker & 1 << val) > 0   )
                    return false;

                checker |= (1 << val);
            }
            return true;
        }

        static bool IsUniqueChar2(string w)
        {
            if(w.Length > 128)
                return false;

            bool[] array = new bool[128];

            for(int i=0; i < w.Length; i++)
            {
                int val = w[i];
                if(array[val])
                    return false;

                array[w[i]] = true;
            }
            return true;
        }
    }
}
