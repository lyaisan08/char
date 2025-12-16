using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = "user.example@gmail.com";
            bool sob = email.Contains("@");
            if (sob == true)
            {
                int index = email.IndexOf("@");
                string zam = email.Substring(0, index);
                string stars = new string('*', zam.Length);
                string kon = email.Substring(index);
                string pol = stars + kon;
                Console.WriteLine("Пароль со звездочками: " + pol);
            }
            else
                Console.WriteLine("Email не содержит @");
        }
    }
}
