using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            for(int i  = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    sb.AppendLine($"{i} * {j} = {i *j}");   
                }
            }
            Console.WriteLine( sb.ToString());
        }
    }
}
