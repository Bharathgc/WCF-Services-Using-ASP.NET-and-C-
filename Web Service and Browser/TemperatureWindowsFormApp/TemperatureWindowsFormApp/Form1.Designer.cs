namespace TemperatureWindowsFormApp
{
    partial class Form1
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
            this.c2f_button_1 = new System.Windows.Forms.Button();
            this.f2c_button_1 = new System.Windows.Forms.Button();
            this.f2c_label1 = new System.Windows.Forms.Label();
            this.c2f_label1 = new System.Windows.Forms.Label();
            this.c2f_textBox1 = new System.Windows.Forms.TextBox();
            this.f2c_textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // c2f_button_1
            // 
            this.c2f_button_1.Location = new System.Drawing.Point(59, 123);
            this.c2f_button_1.Name = "c2f_button_1";
            this.c2f_button_1.Size = new System.Drawing.Size(179, 70);
            this.c2f_button_1.TabIndex = 0;
            this.c2f_button_1.Text = "Celsius to Farenheit";
            this.c2f_button_1.UseVisualStyleBackColor = true;
            this.c2f_button_1.Click += new System.EventHandler(this.c2f_button_1_Click);
            // 
            // f2c_button_1
            // 
            this.f2c_button_1.Location = new System.Drawing.Point(59, 322);
            this.f2c_button_1.Name = "f2c_button_1";
            this.f2c_button_1.Size = new System.Drawing.Size(179, 66);
            this.f2c_button_1.TabIndex = 1;
            this.f2c_button_1.Text = "Fareheit to Celsius";
            this.f2c_button_1.UseVisualStyleBackColor = true;
            this.f2c_button_1.Click += new System.EventHandler(this.f2c_button_1_Click);
            // 
            // f2c_label1
            // 
            this.f2c_label1.AutoSize = true;
            this.f2c_label1.Location = new System.Drawing.Point(821, 348);
            this.f2c_label1.Name = "f2c_label1";
            this.f2c_label1.Size = new System.Drawing.Size(51, 20);
            this.f2c_label1.TabIndex = 2;
            this.f2c_label1.Text = "label1";
            // 
            // c2f_label1
            // 
            this.c2f_label1.AutoSize = true;
            this.c2f_label1.Location = new System.Drawing.Point(821, 151);
            this.c2f_label1.Name = "c2f_label1";
            this.c2f_label1.Size = new System.Drawing.Size(51, 20);
            this.c2f_label1.TabIndex = 3;
            this.c2f_label1.Text = "label2";
            // 
            // c2f_textBox1
            // 
            this.c2f_textBox1.Location = new System.Drawing.Point(446, 145);
            this.c2f_textBox1.Name = "c2f_textBox1";
            this.c2f_textBox1.Size = new System.Drawing.Size(160, 26);
            this.c2f_textBox1.TabIndex = 4;
            // 
            // f2c_textBox1
            // 
            this.f2c_textBox1.Location = new System.Drawing.Point(446, 342);
            this.f2c_textBox1.Name = "f2c_textBox1";
            this.f2c_textBox1.Size = new System.Drawing.Size(160, 26);
            this.f2c_textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1599, 784);
            this.Controls.Add(this.f2c_textBox1);
            this.Controls.Add(this.c2f_textBox1);
            this.Controls.Add(this.c2f_label1);
            this.Controls.Add(this.f2c_label1);
            this.Controls.Add(this.f2c_button_1);
            this.Controls.Add(this.c2f_button_1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button c2f_button;
        private System.Windows.Forms.Button f2c_button;
        private System.Windows.Forms.TextBox c2f_textbox;
        private System.Windows.Forms.TextBox f2c_textbox;
        private System.Windows.Forms.Label c2f_label;
        private System.Windows.Forms.Label f2c_label;
        private System.Windows.Forms.Button c2f_button_1;
        private System.Windows.Forms.Button f2c_button_1;
        private System.Windows.Forms.Label f2c_label1;
        private System.Windows.Forms.Label c2f_label1;
        private System.Windows.Forms.TextBox c2f_textBox1;
        private System.Windows.Forms.TextBox f2c_textBox1;
    }
}

