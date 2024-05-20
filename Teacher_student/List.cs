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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Muellimler : ");
            for (int i = 0; i < Database.teachers.Length; i++)
            {
                if (Database.teachers[i] != null)
                {
                    MessageBox.Show(("ID : "+Database.teachers[i].Id + "\n"+
                     "AD : " + Database.teachers[i].Name+"\n"+
                     "SOYAD : "+   Database.teachers[i].Surname+"\n"+
                      "---------"));
                }
            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Telebeler :");
            for (int i = 0;i< Database.students.Length; i++)
            {
                if (Database.students[i] != null)
                {
                    MessageBox.Show(("ID : " + Database.students[i].Id + "\n" +
                     "AD : " + Database.students[i].Name + "\n" +
                     "SOYAD : " + Database.students[i].Surname + "\n" +
                      "---------"));
                }
            }
        }
    }
}
