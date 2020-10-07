using System;
using System.Runtime.CompilerServices;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student test = new Student("Sam", 15029, 3, 4.0);

            //Console.WriteLine(test.GetGradeLevel(test.NumberOfCredits));

            test.AddGrade(4, 3);
            Console.WriteLine(test.Gpa);
        }
    }
}
