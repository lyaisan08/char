using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stroka = "яблоко, банан , апельсин,киви, груша";
            string[] strings = stroka.Split(',');
            for(int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].Trim();
            }
            Array.Sort(strings);
            string sentence = string.Join("; ", strings);
            Console.WriteLine(sentence);
        }
    }
}
