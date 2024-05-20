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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {

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
            string surname = textBox2 .Text;
            string birthDate = textBox3.Text;
            string email = textBox4.Text;
            Teacher teacher = new Teacher(id, name, surname, birthDate, email);
            Database.teachers[Database.teacherId++]= teacher;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            MessageBox.Show("Qeydiyyat tamamlandı");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
