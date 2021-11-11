using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            int studentId;

            Console.WriteLine($"Please enter the student ID number.\n Enter 0 to exit");

            do
            {
                //collect the student ID
                Console.WriteLine("StudentID: ");
                studentId = Convert.ToInt32(Console.ReadLine());

                if (studentId != 0)
                {
                    //collect student name and add the two to the Dictionary
                    Console.WriteLine("Please enter the student name.");
                    string studentName = Console.ReadLine();
                    students.Add(studentId, studentName);

                }

            } while (studentId > 0);

            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }



        }
    }
}
