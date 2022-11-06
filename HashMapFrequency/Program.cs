using System;

namespace HashMapFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] array = {1, 3, 4, 5, 3, 4, 2, 2, 4, 3, 2, 7, 4, 3, 5, 4};
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int freq = -1;
            int res = -1;
            foreach(int i in array)
            {
                if(dict.ContainsKey(i))
                    dict[i]++;
                else
                    dict[i] = 1;
                
                if(dict[i] > freq) 
                {
                    freq = dict[i];
                    res = i;
                }
            }
            Console.WriteLine(res);
            
        }
    }
}
