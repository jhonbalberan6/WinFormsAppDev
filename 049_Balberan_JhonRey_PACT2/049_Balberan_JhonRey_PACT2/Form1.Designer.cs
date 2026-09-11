namespace _049_Balberan_JhonRey_PACT2
{
    partial class Form1
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
            cmbMainmeal = new ComboBox();
            label1 = new Label();
            radDrinkSmall = new RadioButton();
            radDrinkMedium = new RadioButton();
            radDrinkLarge = new RadioButton();
            chkFries = new CheckBox();
            chkExtraCheese = new CheckBox();
            chkDessert = new CheckBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            btnCompute = new Button();
            label3 = new Label();
            chkSeniorDiscount = new CheckBox();
            btnReset = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbMainmeal
            // 
            cmbMainmeal.Font = new Font("Microsoft Sans Serif", 9.75F);
            cmbMainmeal.FormattingEnabled = true;
            cmbMainmeal.Items.AddRange(new object[] { "Burger Meal", "Chicken Meal", "Spaghetti Meal", "Pizza Meal" });
            cmbMainmeal.Location = new Point(102, 32);
            cmbMainmeal.Name = "cmbMainmeal";
            cmbMainmeal.Size = new Size(121, 24);
            cmbMainmeal.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F);
            label1.Location = new Point(27, 35);
            label1.Name = "label1";
            label1.Size = new Size(69, 16);
            label1.TabIndex = 1;
            label1.Text = "Main Meal";
            // 
            // radDrinkSmall
            // 
            radDrinkSmall.AutoSize = true;
            radDrinkSmall.Location = new Point(25, 25);
            radDrinkSmall.Name = "radDrinkSmall";
            radDrinkSmall.Size = new Size(59, 20);
            radDrinkSmall.TabIndex = 2;
            radDrinkSmall.TabStop = true;
            radDrinkSmall.Text = "Small";
            radDrinkSmall.UseVisualStyleBackColor = true;
            // 
            // radDrinkMedium
            // 
            radDrinkMedium.AutoSize = true;
            radDrinkMedium.Location = new Point(25, 50);
            radDrinkMedium.Name = "radDrinkMedium";
            radDrinkMedium.Size = new Size(73, 20);
            radDrinkMedium.TabIndex = 3;
            radDrinkMedium.TabStop = true;
            radDrinkMedium.Text = "Medium";
            radDrinkMedium.UseVisualStyleBackColor = true;
            // 
            // radDrinkLarge
            // 
            radDrinkLarge.AutoSize = true;
            radDrinkLarge.Location = new Point(25, 75);
            radDrinkLarge.Name = "radDrinkLarge";
            radDrinkLarge.Size = new Size(60, 20);
            radDrinkLarge.TabIndex = 4;
            radDrinkLarge.TabStop = true;
            radDrinkLarge.Text = "Large";
            radDrinkLarge.UseVisualStyleBackColor = true;
            // 
            // chkFries
            // 
            chkFries.AutoSize = true;
            chkFries.Font = new Font("Microsoft Sans Serif", 9.75F);
            chkFries.Location = new Point(269, 50);
            chkFries.Name = "chkFries";
            chkFries.Size = new Size(56, 20);
            chkFries.TabIndex = 5;
            chkFries.Text = "Fries";
            chkFries.UseVisualStyleBackColor = true;
            // 
            // chkExtraCheese
            // 
            chkExtraCheese.AutoSize = true;
            chkExtraCheese.Font = new Font("Microsoft Sans Serif", 9.75F);
            chkExtraCheese.Location = new Point(269, 75);
            chkExtraCheese.Name = "chkExtraCheese";
            chkExtraCheese.Size = new Size(106, 20);
            chkExtraCheese.TabIndex = 6;
            chkExtraCheese.Text = "Extra Cheese";
            chkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // chkDessert
            // 
            chkDessert.AutoSize = true;
            chkDessert.Font = new Font("Microsoft Sans Serif", 9.75F);
            chkDessert.Location = new Point(269, 100);
            chkDessert.Name = "chkDessert";
            chkDessert.Size = new Size(73, 20);
            chkDessert.TabIndex = 7;
            chkDessert.Text = "Dessert";
            chkDessert.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radDrinkMedium);
            groupBox1.Controls.Add(radDrinkSmall);
            groupBox1.Controls.Add(radDrinkLarge);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBox1.Location = new Point(33, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(190, 111);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Drink Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(244, 32);
            label2.Name = "label2";
            label2.Size = new Size(59, 16);
            label2.TabIndex = 9;
            label2.Text = "Add Ons";
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.Azure;
            btnCompute.FlatStyle = FlatStyle.Popup;
            btnCompute.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold);
            btnCompute.Location = new Point(33, 192);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(79, 32);
            btnCompute.TabIndex = 10;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.Location = new Point(244, 136);
            label3.Name = "label3";
            label3.Size = new Size(75, 16);
            label3.TabIndex = 11;
            label3.Text = "Deductions";
            // 
            // chkSeniorDiscount
            // 
            chkSeniorDiscount.AutoSize = true;
            chkSeniorDiscount.Font = new Font("Microsoft Sans Serif", 9.75F);
            chkSeniorDiscount.Location = new Point(269, 154);
            chkSeniorDiscount.Name = "chkSeniorDiscount";
            chkSeniorDiscount.Size = new Size(107, 20);
            chkSeniorDiscount.TabIndex = 12;
            chkSeniorDiscount.Text = "Senior Citizen";
            chkSeniorDiscount.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.MistyRose;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold);
            btnReset.Location = new Point(148, 192);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 32);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 251);
            Controls.Add(btnReset);
            Controls.Add(chkSeniorDiscount);
            Controls.Add(label3);
            Controls.Add(btnCompute);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(chkDessert);
            Controls.Add(chkExtraCheese);
            Controls.Add(chkFries);
            Controls.Add(label1);
            Controls.Add(cmbMainmeal);
            Name = "Form1";
            Text = "FastBite Express";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMainmeal;
        private Label label1;
        private RadioButton radDrinkSmall;
        private RadioButton radDrinkMedium;
        private RadioButton radDrinkLarge;
        private CheckBox chkFries;
        private CheckBox chkExtraCheese;
        private CheckBox chkDessert;
        private GroupBox groupBox1;
        private Label label2;
        private Button btnCompute;
        private Label label3;
        private CheckBox chkSeniorDiscount;
        private Button btnReset;
    }
}
