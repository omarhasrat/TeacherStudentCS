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
    public partial class Relation : Form
    {
        public Relation()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = new PrintTeachersTeachingStudent();
            p.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ps = new PrintStudentsTeacherByTeacher();
            ps.Show();
            this.Hide();
        }
    }
}
