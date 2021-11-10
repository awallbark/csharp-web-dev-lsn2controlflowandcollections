using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            
            int[] someArray = new int[] { 1, 1, 2, 3, 5, 8 };

            //printing whole list
            foreach (var number in someArray)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            //printing only odd numbers
            for (i = 0; i < someArray.Length; i++)
            {
                //condition to check ODD number
                //https://www.includehelp.com/dot-net/print-all-odd-numbers-from-array-of-integers-using-c-sharp-program.aspx
                if (someArray[i] % 2 != 0)
                    Console.Write(someArray[i] + " ");
            }
            
        }
    }
}
