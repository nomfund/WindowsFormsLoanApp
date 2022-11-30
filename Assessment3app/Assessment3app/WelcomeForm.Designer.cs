namespace Assessment3app
{
    partial class WelcomeForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.NametextBox1 = new System.Windows.Forms.TextBox();
            this.IDtextBox1 = new System.Windows.Forms.TextBox();
            this.LoanFeetextBox1 = new System.Windows.Forms.TextBox();
            this.totalloantextBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.InterestRatetextBox1 = new System.Windows.Forms.TextBox();
            this.loanTypecomboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Welcome To Window\'s loan app";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NametextBox1
            // 
            this.NametextBox1.Location = new System.Drawing.Point(55, 81);
            this.NametextBox1.Name = "NametextBox1";
            this.NametextBox1.Size = new System.Drawing.Size(303, 23);
            this.NametextBox1.TabIndex = 1;
            this.NametextBox1.Text = "Name";
            // 
            // IDtextBox1
            // 
            this.IDtextBox1.Location = new System.Drawing.Point(382, 81);
            this.IDtextBox1.Name = "IDtextBox1";
            this.IDtextBox1.Size = new System.Drawing.Size(215, 23);
            this.IDtextBox1.TabIndex = 2;
            this.IDtextBox1.Text = "ID numder";
            // 
            // LoanFeetextBox1
            // 
            this.LoanFeetextBox1.Location = new System.Drawing.Point(55, 139);
            this.LoanFeetextBox1.Name = "LoanFeetextBox1";
            this.LoanFeetextBox1.Size = new System.Drawing.Size(303, 23);
            this.LoanFeetextBox1.TabIndex = 3;
            this.LoanFeetextBox1.Text = "Loan Fee";
            // 
            // totalloantextBox1
            // 
            this.totalloantextBox1.Location = new System.Drawing.Point(382, 139);
            this.totalloantextBox1.Name = "totalloantextBox1";
            this.totalloantextBox1.Size = new System.Drawing.Size(215, 23);
            this.totalloantextBox1.TabIndex = 4;
            this.totalloantextBox1.Text = "Total Loan";
            this.totalloantextBox1.TextChanged += new System.EventHandler(this.totalloantextBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 186);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(542, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // InterestRatetextBox1
            // 
            this.InterestRatetextBox1.Location = new System.Drawing.Point(55, 226);
            this.InterestRatetextBox1.Name = "InterestRatetextBox1";
            this.InterestRatetextBox1.Size = new System.Drawing.Size(303, 23);
            this.InterestRatetextBox1.TabIndex = 6;
            this.InterestRatetextBox1.Text = "Interest Rate";
            // 
            // loanTypecomboBox1
            // 
            this.loanTypecomboBox1.FormattingEnabled = true;
            this.loanTypecomboBox1.Location = new System.Drawing.Point(382, 226);
            this.loanTypecomboBox1.Name = "loanTypecomboBox1";
            this.loanTypecomboBox1.Size = new System.Drawing.Size(215, 23);
            this.loanTypecomboBox1.TabIndex = 7;
            this.loanTypecomboBox1.Text = "Loan Type";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Save Loan";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loanTypecomboBox1);
            this.Controls.Add(this.InterestRatetextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.totalloantextBox1);
            this.Controls.Add(this.LoanFeetextBox1);
            this.Controls.Add(this.IDtextBox1);
            this.Controls.Add(this.NametextBox1);
            this.Controls.Add(this.button1);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox NametextBox1;
        private TextBox IDtextBox1;
        private TextBox LoanFeetextBox1;
        private TextBox totalloantextBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox InterestRatetextBox1;
        private ComboBox loanTypecomboBox1;
        private Button button2;
    }
}