using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _VaAP__Pochekuev_LR1
{
    class Program
    {
        private static List<String> words = new List<String>();

        static void Main(string[] args)
        {
            Console.WriteLine("Вводите слова, завершая каждое нажатием Enter.");
            Console.WriteLine("Для выхода наберите \"exit\".\n");

            do
            {
                Console.Write("Введите слово: ");
                words.Add(Console.ReadLine());
            } while (isInputEnded(words[words.Count - 1]));

            String maxLengthWord = findMaxLengthWord();

            Console.Write("\nСчитывание завершено.");
            Console.Write($"\nСамое длинное слово: \"{maxLengthWord.ToUpper()}\" ({maxLengthWord.Length})");
            Console.ReadKey();
        }

        private static bool isInputEnded(String input)
        {
            if (input.Equals("exit")) return !true;
            return !false;
        }

        private static String findMaxLengthWord()
        {
            String tmp = "";

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].ToString().Length > tmp.Length)
                {
                    tmp = words[i].ToString();
                }
            }

            return tmp;
        }
    }
}
