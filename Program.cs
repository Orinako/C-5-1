using System;

namespace Задание_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();

            string[] words = SplitSentence(sentence);
            OutputWords(words);

            Console.ReadKey();
        }

        static string[] SplitSentence (string text)
        {
            string[] words = text.Split(' ');        
            return words;
        }

        static void OutputWords (string[] wordsArray)
        {
            int i = 0;
            while (i++ < wordsArray.Length)
            {
                Console.WriteLine($"{wordsArray[i-1]}");
            }

        }
    }
}
