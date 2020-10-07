using System;
using System.Security.Cryptography.X509Certificates;

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            double currentQualityScore = this.Gpa * this.NumberOfCredits;
            double classQualityScore = grade * courseCredits;
            double totalQualityScore = currentQualityScore + classQualityScore;
            this.NumberOfCredits += courseCredits;
            this.Gpa = totalQualityScore / this.NumberOfCredits;
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (this.NumberOfCredits >= 0 && this.NumberOfCredits <= 29)
            {
                return this.Name + " is a freshman";
            }
            else if (this.NumberOfCredits > 29 && this.NumberOfCredits <= 59)
            {
                return this.Name + " is a sophomore";
            }
            else if (this.NumberOfCredits > 59 && this.NumberOfCredits <= 89)
            {
                return this.Name + " is a junior";
            }
            else
            {
                return this.Name + " is a senior";
            }
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.

        public override string ToString()
        {
            return this.GetGradeLevel(this.NumberOfCredits) + " with a GPA of: " + this.Gpa + ".";
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Student s = obj as Student;
            return s.StudentId == StudentId;
        }

    }
}
