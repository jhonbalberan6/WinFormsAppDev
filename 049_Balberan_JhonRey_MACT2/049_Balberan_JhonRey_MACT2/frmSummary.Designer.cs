namespace _049_Balberan_JhonRey_MACT2
{
    partial class frmSummary
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            lblYear = new Label();
            lblProgram = new Label();
            lblLName = new Label();
            lblFName = new Label();
            lblStudId = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(28, 34);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(26, 64);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(24, 91);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 2;
            label3.Text = "Last Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(34, 117);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 3;
            label4.Text = "Program: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(58, 145);
            label5.Name = "label5";
            label5.Size = new Size(40, 17);
            label5.TabIndex = 4;
            label5.Text = "Year: ";
            // 
            // button1
            // 
            button1.Location = new Point(111, 184);
            button1.Name = "button1";
            button1.Size = new Size(80, 26);
            button1.TabIndex = 5;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 9.75F);
            lblYear.Location = new Point(117, 145);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(40, 17);
            lblYear.TabIndex = 10;
            lblYear.Text = "Year: ";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Font = new Font("Segoe UI", 9.75F);
            lblProgram.Location = new Point(117, 117);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(66, 17);
            lblProgram.TabIndex = 9;
            lblProgram.Text = "Program: ";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Segoe UI", 9.75F);
            lblLName.Location = new Point(117, 91);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(77, 17);
            lblLName.TabIndex = 8;
            lblLName.Text = "Last Name: ";
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Font = new Font("Segoe UI", 9.75F);
            lblFName.Location = new Point(117, 64);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(74, 17);
            lblFName.TabIndex = 7;
            lblFName.Text = "First Name:";
            // 
            // lblStudId
            // 
            lblStudId.AutoSize = true;
            lblStudId.Font = new Font("Segoe UI", 9.75F);
            lblStudId.Location = new Point(117, 34);
            lblStudId.Name = "lblStudId";
            lblStudId.Size = new Size(71, 17);
            lblStudId.TabIndex = 6;
            lblStudId.Text = "Student ID:";
            // 
            // frmSummary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 222);
            Controls.Add(lblYear);
            Controls.Add(lblProgram);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Controls.Add(lblStudId);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSummary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Summary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        public Label lblYear;
        public Label lblProgram;
        public Label lblLName;
        public Label lblFName;
        public Label lblStudId;
    }
}