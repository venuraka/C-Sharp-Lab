using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Q1
{
    internal class Course
    {
        private string courseName;
        private string instructorName;
        private double grade;

        public Course(string courseName, string instructorName, double grade)
        {
            CourseName = courseName;
            SetInstructorName(instructorName);
            Grade = grade;
        }

        public string CourseName
        {
            get
            {
                return courseName;
            }
            set { }

        }
        public double Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    FormatException ex = new FormatException("Grade must be between 0 and 100");
                }
                else
                {
                    grade = value;
                }
            }
        }
        public void SetInstructorName(string instructorName)
        {
            if (string.IsNullOrWhiteSpace(instructorName))
            {
                throw new ArgumentException("Instructor name cannot be empty or whitespace.");
            }
            this.instructorName = instructorName;
        }

        private string CalculateLetterGrade()
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        public void PrintCourseInfo()

        {
            Console.WriteLine("Course Name: {0}", CourseName);
            Console.WriteLine("Instructor Name: {0}", instructorName);
            Console.WriteLine("Grade: {0}", Grade);
            Console.WriteLine("Letter Grade: {0}", CalculateLetterGrade());
        }

    }
}
