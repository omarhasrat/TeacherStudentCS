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
    public partial class PrintStudentsTeacherByTeacher : Form
    {
        public PrintStudentsTeacherByTeacher()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int teacherId = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < Database.teachers.Length; i++)
            {               
                if (Database.teachers[i] != null &&
                    teacherId == Database.teachers[i].Id)
                {
                    MessageBox.Show("Ders kecilen Telebenein Id : " +
                        Database.teacher_Student[i].Student.Id +
                        "\n" + "Ders kecilen Telebenein adi : "
                        + Database.teacher_Student[i].Student.Name +
                        "\n" + "Ders kecilen Telebenein soyadi :" +
                        Database.teacher_Student[i].Student.Surname);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Relation relation = new Relation();
            relation.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
           
        }
    }
}
