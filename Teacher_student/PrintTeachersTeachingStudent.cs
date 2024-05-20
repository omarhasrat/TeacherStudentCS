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
    public partial class PrintTeachersTeachingStudent : Form
    {
        public PrintTeachersTeachingStudent()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(textBox1.Text);
            for(int i = 0; i < Database.students.Length; i++) {
                if (Database.students[i]!=null &&
                    studentId != Database.students[i].Id) 
                {
                    MessageBox.Show("Bele bir Telebe yoxdur");
                    button3_Click(sender,e);
                }
                if (Database.students[i]!=null &&
                    studentId == Database.students[i].Id)
                {
                    MessageBox.Show("Ders kecen Muellimin ID : " + Database.teacher_Student[i].Teacher.Id + "\n" + "Ders kecen Muellimin adi : "
                        + Database.teacher_Student[i].Teacher.Name +
                        "\n" + "Ders kecen Muellimin soyadi :" +
                        Database.teacher_Student[i].Teacher.Surname);
                }
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Relation relation   = new Relation();   
            relation.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
