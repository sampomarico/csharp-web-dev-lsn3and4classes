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
            //Console.WriteLine(test.Gpa);

            //Console.WriteLine(test.ToString());

            Student test2 = new Student("Haley", 15029, 45, 3.75);

            Console.WriteLine(test.Equals(test2));
        }
    }
}
