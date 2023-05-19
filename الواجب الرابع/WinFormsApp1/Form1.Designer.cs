namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNationalNumber = new TextBox();
            btnRegister = new Button();
            rbtnMale = new RadioButton();
            rbtnFeMale = new RadioButton();
            groupBox1 = new GroupBox();
            gbxSkills = new GroupBox();
            chbxUI_UX = new CheckBox();
            chbxwebdesign = new CheckBox();
            chbxprogramming = new CheckBox();
            txtName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cmbCountry = new ComboBox();
            cmbCity = new ComboBox();
            groupBox1.SuspendLayout();
            gbxSkills.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 32);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "National Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 77);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 126);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 185);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 3;
            label4.Text = "Country of Residence";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 242);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 4;
            label5.Text = "City of Residence";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(573, 70);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 5;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(588, 193);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 6;
            label7.Text = "Skills";
            // 
            // txtNationalNumber
            // 
            txtNationalNumber.Location = new Point(192, 29);
            txtNationalNumber.MaxLength = 4;
            txtNationalNumber.Name = "txtNationalNumber";
            txtNationalNumber.Size = new Size(207, 27);
            txtNationalNumber.TabIndex = 7;
            txtNationalNumber.KeyPress += txtNationalNumber_KeyPress;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(305, 403);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Location = new Point(6, 26);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(63, 24);
            rbtnMale.TabIndex = 9;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFeMale
            // 
            rbtnFeMale.AutoSize = true;
            rbtnFeMale.Location = new Point(75, 26);
            rbtnFeMale.Name = "rbtnFeMale";
            rbtnFeMale.Size = new Size(78, 24);
            rbtnFeMale.TabIndex = 10;
            rbtnFeMale.TabStop = true;
            rbtnFeMale.Text = "Female";
            rbtnFeMale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnMale);
            groupBox1.Controls.Add(rbtnFeMale);
            groupBox1.Location = new Point(573, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(160, 53);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // gbxSkills
            // 
            gbxSkills.Controls.Add(chbxUI_UX);
            gbxSkills.Controls.Add(chbxwebdesign);
            gbxSkills.Controls.Add(chbxprogramming);
            gbxSkills.Location = new Point(573, 216);
            gbxSkills.Name = "gbxSkills";
            gbxSkills.Size = new Size(160, 128);
            gbxSkills.TabIndex = 12;
            gbxSkills.TabStop = false;
            // 
            // chbxUI_UX
            // 
            chbxUI_UX.AutoSize = true;
            chbxUI_UX.Location = new Point(15, 86);
            chbxUI_UX.Name = "chbxUI_UX";
            chbxUI_UX.Size = new Size(70, 24);
            chbxUI_UX.TabIndex = 2;
            chbxUI_UX.Text = "UI/UX";
            chbxUI_UX.UseVisualStyleBackColor = true;
            // 
            // chbxwebdesign
            // 
            chbxwebdesign.AutoSize = true;
            chbxwebdesign.Location = new Point(15, 56);
            chbxwebdesign.Name = "chbxwebdesign";
            chbxwebdesign.Size = new Size(111, 24);
            chbxwebdesign.TabIndex = 1;
            chbxwebdesign.Text = "Web Design";
            chbxwebdesign.UseVisualStyleBackColor = true;
            // 
            // chbxprogramming
            // 
            chbxprogramming.AutoSize = true;
            chbxprogramming.Location = new Point(15, 26);
            chbxprogramming.Name = "chbxprogramming";
            chbxprogramming.Size = new Size(122, 24);
            chbxprogramming.TabIndex = 0;
            chbxprogramming.Text = "Programming";
            chbxprogramming.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(192, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(207, 27);
            txtName.TabIndex = 13;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(192, 121);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(207, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(192, 185);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(207, 28);
            cmbCountry.TabIndex = 15;
            cmbCountry.SelectedIndexChanged += cmbCountry_SelectedIndexChanged;
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(192, 239);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(207, 28);
            cmbCity.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbCity);
            Controls.Add(cmbCountry);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtName);
            Controls.Add(gbxSkills);
            Controls.Add(groupBox1);
            Controls.Add(btnRegister);
            Controls.Add(txtNationalNumber);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbxSkills.ResumeLayout(false);
            gbxSkills.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNationalNumber;
        private Button btnRegister;
        private RadioButton rbtnMale;
        private RadioButton rbtnFeMale;
        private GroupBox groupBox1;
        private GroupBox gbxSkills;
        private CheckBox chbxUI_UX;
        private CheckBox chbxwebdesign;
        private CheckBox chbxprogramming;
        private TextBox txtName;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbCountry;
        private ComboBox cmbCity;
    }
}