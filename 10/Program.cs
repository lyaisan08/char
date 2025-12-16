using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for(int i = 0; i < 3; i++)
            {
                char lower = (char)('a' + random.Next(26));
                sb.Append(lower);
            }
            for(int i = 0;i < 3; i++)
            {
                char digit = (char)('0' + random.Next(10));
                sb.Append(digit);
            }
            for(int i = 0;i < 2; i++)
            {
                char upper = (char)('A' + random.Next(26));
                sb.Append(upper);
            }
            for(int i = 0; i < sb.Length; i++)
            {
                int index = random.Next(sb.Length);
                char a = sb[i];
                sb[i] = sb[index];
                sb[index] = a;
            }
            Console.WriteLine("Сгенерированный пароль: " + sb.ToString());
        }
    }
}
