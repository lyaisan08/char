using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово на английском строчными буквами:");
            string c = Console.ReadLine().ToLower();  
            StringBuilder sb = new StringBuilder();
            foreach (char b in c)
            {
                if (char.IsLetter(b))
                {
                    char f = (char)(b + 3);
                    if(f > 'z')
                    {
                        f = (char)(f - 26);
                    }
                    sb.Append(f);
                }
                else
                    sb.Append(b);
            }
            Console.WriteLine("Зашифрованное слово: " + sb); ;
        }
    }
}
