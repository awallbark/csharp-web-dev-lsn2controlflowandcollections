using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine(SumEvenNumbers(numbers));
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
    }
}
