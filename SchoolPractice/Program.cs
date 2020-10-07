using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student sam = new Student();

            sam.Name = "Sam";
            sam.StudentId = 15029;
            sam.NumberOfCredits = 1;
            sam.Gpa = 4.0;

            Student logan = new Student();

            logan.Name = "Logan";
            logan.StudentId = 321654;
            logan.NumberOfCredits = 1;
            logan.Gpa = 4.0;

            Console.WriteLine(sam.Name);
            Console.WriteLine(sam.StudentId);
            Console.WriteLine(sam.NumberOfCredits);
            Console.WriteLine(sam.Gpa);

            Course csharp = new Course();

            csharp.CourseTitle = "Intro to C#";
            csharp.StudentsEnrolled.Add(sam.Name, sam.StudentId);
            csharp.StudentsEnrolled.Add(logan.Name, logan.StudentId);
            csharp.CourseDayOfWeek = "Tuesday and Thursday";

            Console.WriteLine(csharp.CourseTitle);
            foreach (KeyValuePair<string, int> student in csharp.StudentsEnrolled)
            {
                Console.WriteLine(student.Value);
            }
            Console.WriteLine(csharp.CourseDayOfWeek);
        }
    }
}
