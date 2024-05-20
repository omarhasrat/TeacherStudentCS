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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void person_Click(object sender, EventArgs e)
        {
            Users p1 = new Users();
            p1.Show();
            this.Hide();


        }

        private void search_Click(object sender, EventArgs e)
        {
            Relation relation = new Relation();
            relation.Show();
            this.Hide();   
        }

        private void list_Click(object sender, EventArgs e)
        {
            List list = new List();
            list.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RelInfo2 relInfo2 = new RelInfo2();
            relInfo2.Show();
            this.Hide();    
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
