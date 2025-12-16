using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = 'a';
            char digit = '2';
            char symbol = '$';
            char heart = '\u2665';
            Console.WriteLine(heart);
            char.IsLetter('H');//проверяет , это буква?
            char.IsDigit('3');//проверяет, это цифра?
            char.ToLower('H');//к нижнему регистру
            char.ToUpper('a');//к верхнему регистру
            string name = "Артем";
            string group = "224 СИС";
            string emptyString = " ";
            Console.WriteLine(name + emptyString + group);//конкатенация
            //интерполяция строк
            Console.WriteLine($"Студент {name} обучается в группе {group}");
            int len = group.Length;//7
            char firstLetter = name[0];//А


            //поиск подстроки
            string sentence = "Кот сидит на трубе";
            int position = sentence.IndexOf("сидит");//4
            bool contains = sentence.Contains("на");//true
            //проверка начала и конца сроки
            bool start = sentence.StartsWith("Кот");//начало
            bool end = sentence.EndsWith("трубе");//конец
            //изменение регистра
            string mixed = "ПрИвет";
            string lower = mixed.ToLower();
            Console.WriteLine(mixed.ToUpper());
            Console.WriteLine(lower);

            //удаление лишних пробелов
            string withSpaces = "  text  ";
            Console.WriteLine(withSpaces);
            Console.WriteLine(withSpaces.Trim());//удаляет лишние пробелы
            Console.WriteLine(withSpaces.TrimStart());//удаляет лишние пробелы в начале строки
            Console.WriteLine(withSpaces.TrimEnd());//удаляет лишние пробелы в конце строки

            //замена слова
            string original = "Я люблю яблоки";
            string replaced = original.Replace("яблоки", "груши");
            Console.WriteLine(original);
            Console.WriteLine(replaced);
            //разделение на подстроки
            string kanzTovars = "карандаш,ручка,линейка,тетрадь";
            string[] kanzTovarray = kanzTovars.Split(',');
            /* kanzTovars будет хранить:
            * [0] карандаш
            * [1] ручка
            * [2] линейка
            * [3] тетрадь
            */
            //объединение подстрок (склейка)
            string[] words = { "Привет", "223", "группа!" };
            string sentence1 = string.Join(" ", words);
            string sentence2 = string.Join(", ", words);
            Console.WriteLine(sentence1);
            Console.WriteLine(sentence2);

            StringBuilder sb = new StringBuilder();
            //быстрое добавление
            sb.Append("Привет");
            sb.Append(" ");
            sb.Append("мир!");
            //Вставка в определенную позицию
            sb.Insert(6, "Дорогой");
            //замена
            sb.Replace("Дорогой", "любимый");
            string finalString = sb.ToString();
            Console.WriteLine(finalString);
        }  
    }
}
