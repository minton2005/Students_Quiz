using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsQuiz
{
    public class Student
    {
        public string StudentID { get; set; } // แก้ไขเป็น StudentID
        public string Name { get; set; } // แก้ไขเป็น Name
        public string Major { get; set; }
        public string AdvisorName { get; set; }
        public double Grade { get; set; } // แก้ไขเป็น Grade


        public Student(string studentID, string name, string major, string advisorName, double grade)
        {
            StudentID = studentID; // แก้ไขเป็น StudentID
            Name = name; // แก้ไขเป็น Name
            Major = major;
            AdvisorName = advisorName;
            Grade = grade; // แก้ไขเป็น Grade
        }

         public string GetStudentID() { return StudentID; } // แก้ไขเป็น StudentID
        public string GetName() { return Name; } // แก้ไขเป็น Name
        public double GetGrade() { return Grade; } // แก้ไขเป็น Grade
        public void SetGrade(double grade) { this.grade = grade; }
        public double grade { get; set; }
    }
}
