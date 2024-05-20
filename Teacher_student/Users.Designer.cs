namespace Teacher_student
{
    partial class Users
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
            this.teacher = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teacher
            // 
            this.teacher.Location = new System.Drawing.Point(85, 90);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(137, 66);
            this.teacher.TabIndex = 0;
            this.teacher.Text = "Yeni Muellim";
            this.teacher.UseVisualStyleBackColor = true;
            this.teacher.Click += new System.EventHandler(this.teacher_Click);
            // 
            // student
            // 
            this.student.Location = new System.Drawing.Point(423, 90);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(137, 66);
            this.student.TabIndex = 1;
            this.student.Text = "Yeni Telebe";
            this.student.UseVisualStyleBackColor = true;
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.student);
            this.Controls.Add(this.teacher);
            this.Name = "Users";
            this.Text = "Users";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button teacher;
        private System.Windows.Forms.Button student;
        private System.Windows.Forms.Button button1;
    }
}