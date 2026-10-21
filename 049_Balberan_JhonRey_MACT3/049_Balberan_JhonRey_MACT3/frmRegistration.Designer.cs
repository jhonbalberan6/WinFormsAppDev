namespace _049_Balberan_JhonRey_MACT3
{
    partial class frmRegistration
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
            label4 = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtCourse = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            cmbDepartment = new ComboBox();
            dtgStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 97);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Course";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 22);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 97);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Department";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(27, 46);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(240, 23);
            txtFName.TabIndex = 4;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(320, 46);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(240, 23);
            txtLName.TabIndex = 5;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(24, 125);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(243, 23);
            txtCourse.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(389, 175);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(485, 175);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "Elementary Department  ", "Junior High School Department  ", "Senior High School Department  ", "School of Engineering, Architecture, and Information Technology Education  ", "School of Accountancy, Business, and Hospitality  ", "School of Education, Arts, and Sciences  ", "School of Health and Allied Sciences  " });
            cmbDepartment.Location = new Point(320, 125);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(240, 23);
            cmbDepartment.TabIndex = 10;
            // 
            // dtgStudents
            // 
            dtgStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgStudents.BackgroundColor = SystemColors.ButtonHighlight;
            dtgStudents.BorderStyle = BorderStyle.Fixed3D;
            dtgStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgStudents.Location = new Point(24, 215);
            dtgStudents.MultiSelect = false;
            dtgStudents.Name = "dtgStudents";
            dtgStudents.ReadOnly = true;
            dtgStudents.RowHeadersVisible = false;
            dtgStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgStudents.Size = new Size(536, 141);
            dtgStudents.TabIndex = 11;
            dtgStudents.CellContentClick += dtgStudents_CellContentClick;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 378);
            Controls.Add(dtgStudents);
            Controls.Add(cmbDepartment);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtCourse);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration Form";
            Load += frmRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)dtgStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtCourse;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cmbDepartment;
        private DataGridView dtgStudents;
    }
}
