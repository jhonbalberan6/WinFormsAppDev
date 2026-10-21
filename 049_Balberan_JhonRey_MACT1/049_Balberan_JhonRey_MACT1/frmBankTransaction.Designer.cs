namespace _049_Balberan_JhonRey_MACT1
{
    partial class frmBankTransaction
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
            cmbTransaction = new ComboBox();
            label1 = new Label();
            txtDepositAmt = new TextBox();
            txtWithdrawAmt = new TextBox();
            btnSubmit = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // cmbTransaction
            // 
            cmbTransaction.FormattingEnabled = true;
            cmbTransaction.Items.AddRange(new object[] { "Check Balance", "Deposit", "Withdraw" });
            cmbTransaction.Location = new Point(138, 33);
            cmbTransaction.Name = "cmbTransaction";
            cmbTransaction.Size = new Size(102, 23);
            cmbTransaction.TabIndex = 0;
            cmbTransaction.SelectedIndexChanged += cmbTransaction_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // txtDepositAmt
            // 
            txtDepositAmt.Enabled = false;
            txtDepositAmt.Location = new Point(58, 70);
            txtDepositAmt.Name = "txtDepositAmt";
            txtDepositAmt.PlaceholderText = "Enter Deposit Amount";
            txtDepositAmt.Size = new Size(135, 23);
            txtDepositAmt.TabIndex = 7;
            // 
            // txtWithdrawAmt
            // 
            txtWithdrawAmt.Enabled = false;
            txtWithdrawAmt.Location = new Point(58, 99);
            txtWithdrawAmt.Name = "txtWithdrawAmt";
            txtWithdrawAmt.PlaceholderText = "Enter Withdraw Amount";
            txtWithdrawAmt.Size = new Size(135, 23);
            txtWithdrawAmt.TabIndex = 8;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(165, 143);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 36);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 10;
            label2.Text = "Select Transaction:";
            // 
            // frmBankTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 198);
            Controls.Add(label2);
            Controls.Add(btnSubmit);
            Controls.Add(txtWithdrawAmt);
            Controls.Add(txtDepositAmt);
            Controls.Add(label1);
            Controls.Add(cmbTransaction);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBankTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBankTransaction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTransaction;
        private Label label1;
        private TextBox txtDepositAmt;
        private TextBox txtWithdrawAmt;
        private Button btnSubmit;
        private Label label2;
    }
}