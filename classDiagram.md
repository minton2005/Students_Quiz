classDiagram
    class Form1 {
        -List<Student> students
        -List<Advisor> advisors
        +Form1()
        -Form1_Load(object sender, EventArgs e)
        -ShowTopStudent()
        -SaveAdvisorBTN_Click(object sender, EventArgs e)
        -AdvisorMajorCBB_SelectedIndexChanged(object sender, EventArgs e)
        -SaveBTN_Click_1(object sender, EventArgs e)
        -ShowDataBTN_Click(object sender, EventArgs e)
        -AddStudentBTN_Click(object sender, EventArgs e)
    }
    class Student {
        +string StudentID
        +string Name
        +string Major
        +string AdvisorName
        +double Grade
        +Student(string studentID, string name, string major, string advisorName, double grade)
        +string GetStudentID()
        +string GetName()
        +double GetGrade()
        +void SetGrade(double grade)
        +double grade
    }
    class Advisor {
        -string name
        -string major
        -List<string> studentIDs
        +Advisor(string name, string major)
        +string GetName()
        +string GetMajor()
        +List<string> GetStudentIDs()
        +void AddStudentID(string studentID)
    }
    Form1 "1" -- "*" Student : contains
    Form1 "1" -- "*" Advisor : contains
    Student "1" -- "1" Advisor : advisor