using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "анна";
            string city = "москва";
            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            city = city.ToUpper();
            Console.WriteLine($"Привет, {name} из {city}!");
        }
    }
}
