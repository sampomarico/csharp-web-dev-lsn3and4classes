using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        public string CourseTitle { get; set; }
        private Dictionary<string, int> studentsEnrolled = new Dictionary<string, int>();
        public string CourseDayOfWeek { get; set; }

        public Dictionary<string, int> StudentsEnrolled
        {
            get { return studentsEnrolled; }
            set { studentsEnrolled = value; }
        }

    }
}
