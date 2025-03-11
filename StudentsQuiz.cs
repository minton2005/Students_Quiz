namespace StudentsQuiz
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Advisor> advisors = new List<Advisor>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            majorCBB.Items.AddRange(new string[] { "Computer Science", "Mathematics", "Physics" });
            AdvisorMajorCBB.Items.AddRange(new string[] { "Computer Science", "Mathematics", "Physics" });
        }
        private void ShowTopStudent()
        {
            if (students.Count > 0)
            {
                Student topStudent = students.OrderByDescending(s => s.grade).FirstOrDefault();
                if (topStudent != null)
                {
                    lbtStudentID.Text = topStudent.StudentID;
                    lbtStudentName.Text = topStudent.Name;
                    lbtStudentGrade.Text = topStudent.Grade.ToString();
                }
            }
        }
        private void SaveAdvisorBTN_Click(object sender, EventArgs e)
        {
            // ตรวจสอบข้อมูล Advisor
            if (tbAdvisorName.Text == "" || AdvisorMajorCBB.SelectedItem == null)
            {
                MessageBox.Show("Please enter advisor name and select a major.");
                return;
            }

            // เพิ่ม Advisor ลงใน advisors List
            string advisorName = tbAdvisorName.Text;
            string advisorMajor = AdvisorMajorCBB.SelectedItem.ToString();
            Advisor advisor = new Advisor(advisorName, advisorMajor);
            advisors.Add(advisor);

            // เพิ่ม Advisor ลงใน AdvisorCBB และ studentLBox ComboBox
            if (!AdvisorCBB.Items.Contains(advisorName))
            {
                AdvisorCBB.Items.Add(advisorName);
                studentLBox.Items.Add(advisorName);

                if (AdvisorCBB.Items.Count > 0)
                {
                    AdvisorCBB.SelectedIndex = 0;
                }
            }

            // เคลียร์ช่องป้อนข้อมูล Advisor
            tbAdvisorName.Clear();
            AdvisorMajorCBB.SelectedIndex = -1;
        }





        private void AdvisorMajorCBB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void SaveBTN_Click_1(object sender, EventArgs e)
        {
            // ตรวจสอบข้อมูล Advisor
            if (tbAdvisorName.Text == "" || AdvisorMajorCBB.SelectedItem == null)
            {
                MessageBox.Show("Please enter advisor name and select a major.");
                return;
            }

            // เพิ่ม Advisor ลงใน advisors List
            string advisorName = tbAdvisorName.Text;
            string advisorMajor = AdvisorMajorCBB.SelectedItem.ToString();
            Advisor advisor = new Advisor(advisorName, advisorMajor);
            advisors.Add(advisor);

            // เพิ่ม Advisor ลงใน AdvisorCBB และ studentLBox ComboBox
            if (!AdvisorCBB.Items.Contains(advisorName))
            {
                AdvisorCBB.Items.Add(advisorName);
               
                if (AdvisorCBB.Items.Count > 0)
                {
                    AdvisorCBB.SelectedIndex = 0;
                }
            }

            // เคลียร์ช่องป้อนข้อมูล Advisor
            tbAdvisorName.Clear();
            AdvisorMajorCBB.SelectedIndex = -1;
        }

        private void ShowDataBTN_Click(object sender, EventArgs e)
        {
            // ตรวจสอบ SelectedItem ก่อนใช้งาน
            if (AdvisorCBB.SelectedItem == null)
            {
                MessageBox.Show("Please select an advisor.");
                return; // หยุดการทำงานถ้าไม่มีรายการถูกเลือก
            }
            // แสดงรายชื่อนักศึกษาในที่ปรึกษา
            string advisorName = AdvisorCBB.SelectedItem.ToString();
            Advisor advisor = advisors.FirstOrDefault(a => a.GetName() == advisorName);
            if (advisor != null)
            {
                studentLBox.Items.Clear();
                foreach (string studentID in advisor.GetStudentIDs())
                {
                    Student student = students.FirstOrDefault(s => s.GetStudentID() == studentID);
                    if (student != null)
                    {
                        studentLBox.Items.Add(student.GetName());
                    }
                }
            }

            // แสดงนักศึกษาที่มีคะแนนเกรดสูงสุด
            Student topStudent = students.OrderByDescending(s => s.GetGrade()).FirstOrDefault();
            if (topStudent != null)
            {
                lbtStudentName.Text = topStudent.GetName();
                lbtStudentID.Text = topStudent.GetStudentID();
                lbtStudentGrade.Text = topStudent.GetGrade().ToString();
            }
        }

        private void AddStudentBTN_Click(object sender, EventArgs e)
        {
            // ตรวจสอบข้อมูล Student
            if (studentLBox.SelectedItem == null || majorCBB.SelectedItem == null || string.IsNullOrEmpty(tbStudentID.Text) || string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbGrade.Text))
            {
                MessageBox.Show("Please fill in all student information.");
                return;
            }

            // สร้าง Object Student และเพิ่มข้อมูล Student
            Student student = new Student(
                tbStudentID.Text,
                tbName.Text,
                majorCBB.SelectedItem.ToString(),
                studentLBox.SelectedItem.ToString(),
                0 // กำหนดค่าเริ่มต้นเป็น 0
            );

            // แปลง tbGrade.Text เป็น double และจัดการข้อผิดพลาด
            double grade;
            if (!double.TryParse(tbGrade.Text, out grade))
            {
                MessageBox.Show("Please enter a valid grade.");
                return;
            }
            student.Grade = grade;

            students.Add(student);

            // เพิ่มชื่อ Student ลงใน studentListBox
            studentLBox.Items.Add(student.Name);

            // แสดงข้อมูล Top Student
            ShowTopStudent();

            // เคลียร์ช่องป้อนข้อมูล Student
            tbStudentID.Clear();
            tbName.Clear();
            tbGrade.Clear();
        }
    }
    }






