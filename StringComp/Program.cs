using System;
using System.Text;

namespace StringComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringComp("aabcccccaaa"));
            Console.WriteLine(StringComp("abca"));
            Console.WriteLine(StringComp("abcd"));
        }

        static string StringComp(string word)
        {
            int cc = CountCompression(word);
            if(word.Length <= cc) return word;

            StringBuilder sb = new StringBuilder(cc);
            int count = 0;

            for(int i=0; i < word.Length; i++)
            {
                count++;
                if(i + 1 >= word.Length || word[i] != word[i + 1])
                {
                    sb.Append("" + word[i] + count);
                    count = 0;
                }
            } 
            return sb.ToString();
        }

        static int CountCompression(string word)
        {
            int count = 0;
            int compressedLength = 0;

            for(int i=0; i < word.Length; i++)
            {
                count++;
                if(i + 1 >= word.Length || word[i] != word[i + 1])
                {
                    compressedLength += (1 + Convert.ToString(count).Length);
                    count = 0;
                }
            }
            return compressedLength;
        }

        static string StringComp3(string word)
        {
            int count = 0;
            string result = "";

            for(int i=0; i < word.Length; i++)
            {
                count++;
                if(i + 1 >= word.Length || word[i] != word[i + 1])
                {
                    result += "" + word[i] + count;
                    count = 0;
                }
            }

            return result.Length < word.Length ? result : word;
        }


        static string StringComp2(string word)
        {
            char tmp = word[0];
            int count = 1;
            StringBuilder sb = new StringBuilder();

            for(int i=1; i < word.Length; i++)
            {
                if(tmp != word[i])
                {
                    sb.Append(tmp + count.ToString());

                    tmp = word[i];
                    count = 0;
                }
                count ++;
            }
            sb.Append(tmp + count.ToString());

            //check if original is less return this.
            return sb.Length < word.Length ? sb.ToString() : word;
        }
    }
}
