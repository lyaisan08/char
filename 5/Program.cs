using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");
            string a = Console.ReadLine();
            string b = a.Trim().ToLower();
            string result = "является палидромом";
            for(int i = 0; i < b.Length / 2; i++)
            {
                if(b[i] != b[b.Length - 1 - i])
                {
                    result = "не является палидромом";
                    break;
                }
            }
            Console.WriteLine($"Слово {a} {result}");
        }
    }
}
