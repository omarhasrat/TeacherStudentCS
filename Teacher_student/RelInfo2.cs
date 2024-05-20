using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_student
{
    public partial class RelInfo2 : Form
    {
        public RelInfo2()
        {
            InitializeComponent();
        }

        private void RelInfo2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int TSId = Database.teacherStudentId;
            int teacherId = Convert.ToInt32(textBox1.Text);
            Teacher teacher = Database.teachers[teacherId];
            int studentId = Convert.ToInt32(textBox5.Text);
            Student student = Database.students[studentId];
            string lesson = textBox2.Text;
            int classNumber =Convert.ToInt32(textBox4.Text);
            TeacherStudent teacherStudent =
                new TeacherStudent(TSId++, teacher, student,classNumber, lesson);
            Database.teacher_Student[Database.teacherStudentId] = teacherStudent;
            textBox1.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox2.Clear();
            MessageBox.Show("Elaqe yarandi");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox2.Clear();
        }
    }
}
