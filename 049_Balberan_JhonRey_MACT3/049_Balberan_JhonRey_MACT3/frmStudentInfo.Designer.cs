namespace _049_Balberan_JhonRey_MACT3
{
    partial class frmStudentInfo
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
            lblFname = new Label();
            lblLname = new Label();
            lblCourse = new Label();
            lblDepartment = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Location = new Point(130, 37);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(38, 15);
            lblFname.TabIndex = 0;
            lblFname.Text = "label1";
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Location = new Point(130, 68);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(38, 15);
            lblLname.TabIndex = 1;
            lblLname.Text = "label1";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(130, 99);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(38, 15);
            lblCourse.TabIndex = 2;
            lblCourse.Text = "label1";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(130, 130);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(38, 15);
            lblDepartment.TabIndex = 3;
            lblDepartment.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 37);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 4;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 70);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 5;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 101);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "Course:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 132);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 7;
            label4.Text = "Department:";
            // 
            // frmStudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 191);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDepartment);
            Controls.Add(lblCourse);
            Controls.Add(lblLname);
            Controls.Add(lblFname);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmStudentInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Student Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblFname;
        public Label lblLname;
        public Label lblCourse;
        public Label lblDepartment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}