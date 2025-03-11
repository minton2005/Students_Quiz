    673450201-5 นายสหรัถ บุญเนาว์

a. Class diagram ของโปรแกรมที่ตนเองออกแบบ (เขียนให้ถูกต้องและครบถ้วน)

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

b. โปรแกรมได้ใช้หลักการเขียนโปรแกรมตามหลักการเขียนโปรแกรมเชิงวัตถุอย่างไรบ้าง
1. คลาส (Classes) และอ็อบเจ็กต์ (Objects):

โปรแกรมมีการกำหนดคลาส Student และ Advisor ซึ่งเป็นแม่แบบสำหรับสร้างอ็อบเจ็กต์
มีการสร้างอ็อบเจ็กต์ของคลาส Student และ Advisor เพื่อเก็บข้อมูลนักศึกษาและอาจารย์ที่ปรึกษา
คลาส Form1 ก็เป็นคลาสที่สร้าง object ของ form ขึ้นมาเพื่อแสดงผลและรับข้อมูลจากผู้ใช้งาน
2. การห่อหุ้ม (Encapsulation):

คลาส Student และ Advisor มีการกำหนดแอททริบิวต์ (คุณสมบัติ) และเมธอด (การกระทำ) ไว้ภายในคลาสเดียวกัน
มีการใช้เมธอด Get และ Set เพื่อเข้าถึงและแก้ไขข้อมูลภายในคลาส ซึ่งเป็นการควบคุมการเข้าถึงข้อมูล
มีการกำหนด access modifier เช่น private และ public เพื่อกำหนดขอบเขตการเข้าถึงข้อมูลและ method ของ class
3. การสืบทอด (Inheritance):

ในโค้ดที่คุณให้มา ยังไม่มีการใช้หลักการสืบทอดอย่างชัดเจน แต่สามารถนำไปประยุกต์ใช้ได้ เช่น หากต้องการสร้างคลาส GraduateStudent ที่สืบทอดจากคลาส Student เพื่อเพิ่มคุณสมบัติและเมธอดสำหรับนักศึกษาปริญญาโท
4. พหุสัณฐาน (Polymorphism):

ในโค้ดที่คุณให้มา ยังไม่มีการใช้หลักการพหุสัณฐานอย่างชัดเจน แต่สามารถนำไปประยุกต์ใช้ได้ เช่น หากต้องการสร้างเมธอด DisplayInfo ที่สามารถแสดงข้อมูลของทั้งนักศึกษาและอาจารย์ที่ปรึกษา โดยขึ้นอยู่กับประเภทของอ็อบเจ็กต์