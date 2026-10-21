namespace _049_Balberan_JhonRey_MACT2
{
    partial class frmStudentRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtFname = new TextBox();
            txtLname = new TextBox();
            btnNext = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 37);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 71);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "First Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 108);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name: ";
            // 
            // txtId
            // 
            txtId.Location = new Point(109, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(149, 23);
            txtId.TabIndex = 3;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(109, 68);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(149, 23);
            txtFname.TabIndex = 4;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(109, 105);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(149, 23);
            txtLname.TabIndex = 5;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(109, 147);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(56, 23);
            btnNext.TabIndex = 6;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(196, 147);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(62, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmStudentRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 182);
            Controls.Add(btnCancel);
            Controls.Add(btnNext);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmStudentRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtFname;
        private TextBox txtLname;
        private Button btnNext;
        private Button btnCancel;
    }
}
