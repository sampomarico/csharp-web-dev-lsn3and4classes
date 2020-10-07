using System;
using System.Runtime.CompilerServices;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student test = new Student("Sam", 15029, 95, 4.0);

            Console.WriteLine(test.GetGradeLevel(test.NumberOfCredits));
        }
    }
}
