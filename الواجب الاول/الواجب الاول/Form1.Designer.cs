namespace الواجب_الاول
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
            label2 = new Label();
            label1 = new Label();
            pnlDynamicControls = new Panel();
            txtNumberOfControls = new TextBox();
            comboBox1 = new ComboBox();
            btnCreateControls = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 104);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 11;
            label2.Text = "Number of controls";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(355, 50);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 10;
            label1.Text = "Control Type";
            // 
            // pnlDynamicControls
            // 
            pnlDynamicControls.AutoScroll = true;
            pnlDynamicControls.BackColor = Color.FromArgb(0, 0, 192);
            pnlDynamicControls.Location = new Point(76, 263);
            pnlDynamicControls.Name = "pnlDynamicControls";
            pnlDynamicControls.Size = new Size(720, 296);
            pnlDynamicControls.TabIndex = 9;
            // 
            // txtNumberOfControls
            // 
            txtNumberOfControls.Location = new Point(291, 127);
            txtNumberOfControls.Name = "txtNumberOfControls";
            txtNumberOfControls.Size = new Size(236, 27);
            txtNumberOfControls.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Button", "TextBox", "Label" });
            comboBox1.Location = new Point(291, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 28);
            comboBox1.TabIndex = 7;
            // 
            // btnCreateControls
            // 
            btnCreateControls.BackColor = Color.FromArgb(0, 0, 192);
            btnCreateControls.ForeColor = SystemColors.ButtonHighlight;
            btnCreateControls.Location = new Point(321, 160);
            btnCreateControls.Name = "btnCreateControls";
            btnCreateControls.Size = new Size(163, 68);
            btnCreateControls.TabIndex = 6;
            btnCreateControls.Text = "Create Controls";
            btnCreateControls.UseVisualStyleBackColor = false;
            btnCreateControls.Click += btnCreateControls_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(866, 613);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlDynamicControls);
            Controls.Add(txtNumberOfControls);
            Controls.Add(comboBox1);
            Controls.Add(btnCreateControls);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel pnlDynamicControls;
        private TextBox txtNumberOfControls;
        private ComboBox comboBox1;
        private Button btnCreateControls;
    }
}