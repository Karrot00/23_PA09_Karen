namespace _23_PA9_Karen
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
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_selectcurrency = new System.Windows.Forms.Label();
            this.lbl_value = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_convertedAmt = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rdb_USdollars = new System.Windows.Forms.RadioButton();
            this.rdb_JapaneseYen = new System.Windows.Forms.RadioButton();
            this.rdb_malaysianringgit = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(36, 34);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(56, 17);
            this.lbl_amount.TabIndex = 0;
            this.lbl_amount.Text = "Amount";
            // 
            // lbl_selectcurrency
            // 
            this.lbl_selectcurrency.AutoSize = true;
            this.lbl_selectcurrency.Location = new System.Drawing.Point(36, 110);
            this.lbl_selectcurrency.Name = "lbl_selectcurrency";
            this.lbl_selectcurrency.Size = new System.Drawing.Size(108, 17);
            this.lbl_selectcurrency.TabIndex = 1;
            this.lbl_selectcurrency.Text = "Select Currency";
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Location = new System.Drawing.Point(36, 222);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(44, 17);
            this.lbl_value.TabIndex = 2;
            this.lbl_value.Text = "Value";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(198, 31);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(184, 22);
            this.txt_amount.TabIndex = 3;
            // 
            // txt_convertedAmt
            // 
            this.txt_convertedAmt.Location = new System.Drawing.Point(198, 220);
            this.txt_convertedAmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_convertedAmt.Name = "txt_convertedAmt";
            this.txt_convertedAmt.ReadOnly = true;
            this.txt_convertedAmt.Size = new System.Drawing.Size(184, 22);
            this.txt_convertedAmt.TabIndex = 4;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(439, 104);
            this.btn_convert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(94, 27);
            this.btn_convert.TabIndex = 5;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(439, 136);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 27);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rdb_USdollars
            // 
            this.rdb_USdollars.AutoSize = true;
            this.rdb_USdollars.Location = new System.Drawing.Point(198, 140);
            this.rdb_USdollars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_USdollars.Name = "rdb_USdollars";
            this.rdb_USdollars.Size = new System.Drawing.Size(96, 21);
            this.rdb_USdollars.TabIndex = 7;
            this.rdb_USdollars.TabStop = true;
            this.rdb_USdollars.Text = "US Dollars";
            this.rdb_USdollars.UseVisualStyleBackColor = true;
            // 
            // rdb_JapaneseYen
            // 
            this.rdb_JapaneseYen.AutoSize = true;
            this.rdb_JapaneseYen.Location = new System.Drawing.Point(198, 108);
            this.rdb_JapaneseYen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdb_JapaneseYen.Name = "rdb_JapaneseYen";
            this.rdb_JapaneseYen.Size = new System.Drawing.Size(120, 21);
            this.rdb_JapaneseYen.TabIndex = 8;
            this.rdb_JapaneseYen.TabStop = true;
            this.rdb_JapaneseYen.Text = "Japanese Yen";
            this.rdb_JapaneseYen.UseVisualStyleBackColor = true;
            // 
            // rdb_malaysianringgit
            // 
            this.rdb_malaysianringgit.AutoSize = true;
            this.rdb_malaysianringgit.Location = new System.Drawing.Point(198, 177);
            this.rdb_malaysianringgit.Name = "rdb_malaysianringgit";
            this.rdb_malaysianringgit.Size = new System.Drawing.Size(140, 21);
            this.rdb_malaysianringgit.TabIndex = 9;
            this.rdb_malaysianringgit.TabStop = true;
            this.rdb_malaysianringgit.Text = "Malaysian Ringgit";
            this.rdb_malaysianringgit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.rdb_malaysianringgit);
            this.Controls.Add(this.rdb_JapaneseYen);
            this.Controls.Add(this.rdb_USdollars);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_convertedAmt);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.lbl_selectcurrency);
            this.Controls.Add(this.lbl_amount);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_selectcurrency;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_convertedAmt;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RadioButton rdb_USdollars;
        private System.Windows.Forms.RadioButton rdb_JapaneseYen;
        private System.Windows.Forms.RadioButton rdb_malaysianringgit;
    }
}

