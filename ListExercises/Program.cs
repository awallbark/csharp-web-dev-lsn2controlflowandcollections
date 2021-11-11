using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(SumEvenNumbers(numbers));

            List<string> fiveLetters = new List<string>() { "cat", "dog", "house", "dance", "sleep", "bed", "car" };

            PrintFiveLetterWords(fiveLetters);
            
        }

        public static int SumEvenNumbers(List<int> numbers)
        {
            int sum = 0;

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        public static void PrintFiveLetterWords(List<string> fiveLetters)
        {
            Console.WriteLine("Enter the length of the word you want to search");
            int wordLength = Convert.ToInt32(Console.ReadLine());

            foreach (var word in fiveLetters)
            {
                if (word.Length == wordLength)
                {
                    Console.WriteLine(word);
                }
            }

        }
    }
}
