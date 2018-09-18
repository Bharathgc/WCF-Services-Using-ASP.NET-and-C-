namespace WindowsFormsApp1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.Go_button = new System.Windows.Forms.Button();
            this.label_encry_nouse = new System.Windows.Forms.Label();
            this.label_decry_nouse = new System.Windows.Forms.Label();
            this.encrypted_label = new System.Windows.Forms.Label();
            this.label_decrypted = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_input_stock = new System.Windows.Forms.TextBox();
            this.stock_button = new System.Windows.Forms.Button();
            this.label_stock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(1, 197);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1402, 606);
            this.webBrowser1.TabIndex = 0;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 13);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(1189, 26);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "http://";
            // 
            // Go_button
            // 
            this.Go_button.Location = new System.Drawing.Point(1262, 13);
            this.Go_button.Name = "Go_button";
            this.Go_button.Size = new System.Drawing.Size(75, 38);
            this.Go_button.TabIndex = 2;
            this.Go_button.Text = "Go";
            this.Go_button.UseVisualStyleBackColor = true;
            this.Go_button.Click += new System.EventHandler(this.Go_button_Click);
            // 
            // label_encry_nouse
            // 
            this.label_encry_nouse.AutoSize = true;
            this.label_encry_nouse.Location = new System.Drawing.Point(13, 58);
            this.label_encry_nouse.Name = "label_encry_nouse";
            this.label_encry_nouse.Size = new System.Drawing.Size(81, 20);
            this.label_encry_nouse.TabIndex = 3;
            this.label_encry_nouse.Text = "Encrypted";
            // 
            // label_decry_nouse
            // 
            this.label_decry_nouse.AutoSize = true;
            this.label_decry_nouse.Location = new System.Drawing.Point(758, 57);
            this.label_decry_nouse.Name = "label_decry_nouse";
            this.label_decry_nouse.Size = new System.Drawing.Size(82, 20);
            this.label_decry_nouse.TabIndex = 4;
            this.label_decry_nouse.Text = "Decrypted";
            // 
            // encrypted_label
            // 
            this.encrypted_label.AutoSize = true;
            this.encrypted_label.Location = new System.Drawing.Point(123, 57);
            this.encrypted_label.Name = "encrypted_label";
            this.encrypted_label.Size = new System.Drawing.Size(0, 20);
            this.encrypted_label.TabIndex = 5;
            // 
            // label_decrypted
            // 
            this.label_decrypted.AutoSize = true;
            this.label_decrypted.Location = new System.Drawing.Point(878, 58);
            this.label_decrypted.Name = "label_decrypted";
            this.label_decrypted.Size = new System.Drawing.Size(0, 20);
            this.label_decrypted.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter company symbol for stock quote";
            // 
            // textBox_input_stock
            // 
            this.textBox_input_stock.Location = new System.Drawing.Point(659, 120);
            this.textBox_input_stock.Name = "textBox_input_stock";
            this.textBox_input_stock.Size = new System.Drawing.Size(132, 26);
            this.textBox_input_stock.TabIndex = 8;
            this.textBox_input_stock.Text = "IBM";
            // 
            // stock_button
            // 
            this.stock_button.Location = new System.Drawing.Point(832, 120);
            this.stock_button.Name = "stock_button";
            this.stock_button.Size = new System.Drawing.Size(124, 36);
            this.stock_button.TabIndex = 9;
            this.stock_button.Text = "Stock Quote";
            this.stock_button.UseVisualStyleBackColor = true;
            this.stock_button.Click += new System.EventHandler(this.stock_button_Click);
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Location = new System.Drawing.Point(1003, 128);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(0, 20);
            this.label_stock.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 802);
            this.Controls.Add(this.label_stock);
            this.Controls.Add(this.stock_button);
            this.Controls.Add(this.textBox_input_stock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_decrypted);
            this.Controls.Add(this.encrypted_label);
            this.Controls.Add(this.label_decry_nouse);
            this.Controls.Add(this.label_encry_nouse);
            this.Controls.Add(this.Go_button);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Bharath\'s Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button Go_button;
        private System.Windows.Forms.Label label_encry_nouse;
        private System.Windows.Forms.Label label_decry_nouse;
        private System.Windows.Forms.Label encrypted_label;
        private System.Windows.Forms.Label label_decrypted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_input_stock;
        private System.Windows.Forms.Button stock_button;
        private System.Windows.Forms.Label label_stock;
    }
}

