using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phone = "+79161234567";
            string nach = phone.Substring(0, 2);
            string vtor = phone.Substring(2, 3);
            string tret = phone.Substring(5, 3);
            string chet = phone.Substring(8, 2);
            string pyat = phone.Substring(10, 2);
            string pol = $"{nach} ({vtor}) {tret}-{chet}-{pyat}";
            Console.WriteLine("Телефон: " + pol);
        }
    }
}
