using System;

namespace Teacher_student
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.person = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // person
            // 
            this.person.Location = new System.Drawing.Point(68, 61);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(99, 46);
            this.person.TabIndex = 0;
            this.person.Text = "Yeni Istifadeci";
            this.person.UseVisualStyleBackColor = true;
            this.person.Click += new System.EventHandler(this.person_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(68, 253);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(99, 46);
            this.list.TabIndex = 2;
            this.list.Text = "Siyahi";
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(323, 253);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(99, 46);
            this.search.TabIndex = 4;
            this.search.Text = "Axtaris";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(614, 148);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 48);
            this.exit.TabIndex = 5;
            this.exit.Text = "Cixis";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Elaqe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.search);
            this.Controls.Add(this.list);
            this.Controls.Add(this.person);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        private void relation_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button person;
        private System.Windows.Forms.Button list;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button1;
    }
}

