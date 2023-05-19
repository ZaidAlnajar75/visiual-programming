namespace Calculator
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
            buttonMinus = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonPlus = new Button();
            button0 = new Button();
            button = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            buttonMultiply = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonDivision = new Button();
            txtResult = new TextBox();
            button10 = new Button();
            SuspendLayout();
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(184, 225);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(51, 46);
            buttonMinus.TabIndex = 1;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(127, 225);
            button3.Name = "button3";
            button3.Size = new Size(51, 46);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(70, 225);
            button2.Name = "button2";
            button2.Size = new Size(51, 46);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(13, 225);
            button1.Name = "button1";
            button1.Size = new Size(51, 46);
            button1.TabIndex = 4;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(184, 277);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(51, 46);
            buttonPlus.TabIndex = 5;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Location = new Point(13, 277);
            button0.Name = "button0";
            button0.Size = new Size(51, 46);
            button0.TabIndex = 6;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            button.Location = new Point(127, 277);
            button.Name = "button";
            button.Size = new Size(51, 46);
            button.TabIndex = 7;
            button.Text = "=";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(13, 173);
            button4.Name = "button4";
            button4.Size = new Size(51, 46);
            button4.TabIndex = 16;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(70, 173);
            button5.Name = "button5";
            button5.Size = new Size(51, 46);
            button5.TabIndex = 15;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(127, 173);
            button6.Name = "button6";
            button6.Size = new Size(51, 46);
            button6.TabIndex = 14;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(184, 173);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(51, 46);
            buttonMultiply.TabIndex = 13;
            buttonMultiply.Text = "×";
            buttonMultiply.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(13, 121);
            button7.Name = "button7";
            button7.Size = new Size(51, 46);
            button7.TabIndex = 12;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(70, 121);
            button8.Name = "button8";
            button8.Size = new Size(51, 46);
            button8.TabIndex = 11;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(127, 121);
            button9.Name = "button9";
            button9.Size = new Size(51, 46);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // buttonDivision
            // 
            buttonDivision.Location = new Point(184, 121);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(51, 46);
            buttonDivision.TabIndex = 9;
            buttonDivision.Text = "÷";
            buttonDivision.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Location = new Point(13, 24);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(222, 65);
            txtResult.TabIndex = 17;
            // 
            // button10
            // 
            button10.Location = new Point(70, 277);
            button10.Name = "button10";
            button10.Size = new Size(51, 46);
            button10.TabIndex = 18;
            button10.Text = "C";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 331);
            Controls.Add(button10);
            Controls.Add(txtResult);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(buttonMultiply);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(buttonDivision);
            Controls.Add(button);
            Controls.Add(button0);
            Controls.Add(buttonPlus);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(buttonMinus);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMinus;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonPlus;
        private Button button0;
        private Button button;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button buttonMultiply;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonDivision;
        private TextBox txtResult;
        private Button button10;
    }
}