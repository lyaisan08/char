using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "C# это современный язык программирования";
            int kol = text.Length;
            string[] word = text.Split(' ');
            int kolWord = word.Length;
            int position = text.IndexOf("язык");
            bool start = text.StartsWith("C#");
            Console.WriteLine(kol);
            Console.WriteLine(kolWord);
            Console.WriteLine(position);
            Console.WriteLine(start);
        }
    }
}
