namespace StudentRegisterFormDemo
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string PCN = tbPCN.Text;

            Student student = new Student(name, email, PCN);
            students.Add(student);

            FillListBox();
        }

        private void FillListBox()
        {
            listBox1.Items.Clear();
            foreach (Student s in students)
            {
                listBox1.Items.Add($"PCN:{s.PCN} student name = {s.Name} - email = {s.Email}");
            }
        }
    }
}