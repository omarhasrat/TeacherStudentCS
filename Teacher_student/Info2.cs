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
    public partial class Info2 : Form
    {
        public Info2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  id = Convert.ToInt32(textBox1.Text);
            string name = textBox5.Text;
            string surname = textBox2.Text;
            string birthDate = textBox3.Text;
            string email = textBox4.Text;
            Student student = new Student(id, name, surname, birthDate, email);
            Database.students[Database.studentId++] = student;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            MessageBox.Show("Qeydiyyat tamamlandı");

        }

        private void Info2_Load(object sender, EventArgs e)
        {

        }
    }
}
