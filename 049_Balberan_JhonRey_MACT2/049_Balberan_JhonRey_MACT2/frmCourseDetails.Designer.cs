namespace _049_Balberan_JhonRey_MACT2
{
    partial class frmCourseDetails
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
            cmbPrograms = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtYear = new TextBox();
            btnViewSummary = new Button();
            SuspendLayout();
            // 
            // cmbPrograms
            // 
            cmbPrograms.FormattingEnabled = true;
            cmbPrograms.Items.AddRange(new object[] { "BSIT", "BSCS", "BSCE", "BSA", "BSGE", "BSCpE", "BSEE" });
            cmbPrograms.Location = new Point(96, 33);
            cmbPrograms.Name = "cmbPrograms";
            cmbPrograms.Size = new Size(121, 23);
            cmbPrograms.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 36);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Program: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 80);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Year: ";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(96, 77);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(52, 23);
            txtYear.TabIndex = 3;
            // 
            // btnViewSummary
            // 
            btnViewSummary.Location = new Point(96, 116);
            btnViewSummary.Name = "btnViewSummary";
            btnViewSummary.Size = new Size(121, 23);
            btnViewSummary.TabIndex = 4;
            btnViewSummary.Text = "View Summary";
            btnViewSummary.UseVisualStyleBackColor = true;
            btnViewSummary.Click += btnViewSummary_Click;
            // 
            // frmCourseDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 170);
            Controls.Add(btnViewSummary);
            Controls.Add(txtYear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbPrograms);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCourseDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Selection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPrograms;
        private Label label1;
        private Label label2;
        private TextBox txtYear;
        private Button btnViewSummary;
    }
}