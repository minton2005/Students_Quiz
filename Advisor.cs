using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsQuiz
{
    public class Advisor
    {
        protected string name;
        protected string major;
        protected List<string> studentIDs = new List<string>();

        public Advisor(string name, string major)
        {
            this.name = name;
            this.major = major;
        }

        public string GetName() { return name; }
        public string GetMajor() { return major; }
        public List<string> GetStudentIDs() { return studentIDs; }

        public void AddStudentID(string studentID) { studentIDs.Add(studentID); }
    }
}
