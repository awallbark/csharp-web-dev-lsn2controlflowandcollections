using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //string sentence = "I would not, could not, in a box. I would not, could not with a fox. " +
            //"I will not eat them in a house. I will not eat them with a mouse.";

            //string[] newSentence = sentence.Split(' ');

            //Console.WriteLine(string.Join(",", newSentence));

            string sentence2 = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

            string[] newSentence2 = sentence2.Split(".");

            Console.WriteLine(string.Join($".\n ", newSentence2));
        }
    }
}
