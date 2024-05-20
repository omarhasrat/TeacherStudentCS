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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            Info teacherInfo = new Info();   
            teacherInfo.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void student_Click(object sender, EventArgs e)
        {
            Info2 studentInfo = new Info2();
            studentInfo.Show();
            this.Hide();

        }
    }
}
