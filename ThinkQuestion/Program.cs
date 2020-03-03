using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> dictionary = new Dictionary<string,int>();

            List<string> words = new List<string>()
            {
                "java", "jjava", "vaj", "aavj", "j", "vjaa", "dan", "and", "ddan"
            };
            SortByLength sortByLength = new SortByLength();
            SortByChar sortByChar = new SortByChar();
            words.Sort(sortByLength);
            foreach (var word in words)
            {
                char[] Arr = word.ToCharArray();
                Array.Sort(Arr);
                string w = new string(Arr);
                if (dictionary.ContainsKey(w))
                {
                    dictionary[w]++;
                }
                else
                {
                    dictionary.Add(w, 1);
                }                              
            }
            foreach (var word in dictionary)
            {
                Console.Write($"{word.Key} : ");
                Console.WriteLine(word.Value);
            }
            
        }
        
    }
}
