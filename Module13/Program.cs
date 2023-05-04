using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Module13List
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "f:\\cdev_Text.txt";
            var strings = new List<string>();
            // читаем весь файл с рабочего стола в строку текста
            string text = File.ReadAllText(path);
            // Сохраняем символы-разделители в массив
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            // убираем знааки препинания
            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            // разбиваем нашу строку текста, используя ранее перечисленные символы-разделители
            var words = noPunctuationText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // запускаем новый таймер
            var stopWatch = Stopwatch.StartNew();

            foreach ( var word in words )
            {
                strings.Add(word);
            }
            // смотрим, сколько операция заняла, в миллисекундах
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);

        }
    }
}
