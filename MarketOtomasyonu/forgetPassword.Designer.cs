
namespace MarketOtomasyonu
{
    partial class forgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgetPassword));
            this.maskedTextBoxTc = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelTc = new System.Windows.Forms.Label();
            this.buttonShowPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBoxTc
            // 
            this.maskedTextBoxTc.BackColor = System.Drawing.SystemColors.Window;
            this.maskedTextBoxTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxTc.Location = new System.Drawing.Point(228, 78);
            this.maskedTextBoxTc.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxTc.Mask = "00000000000";
            this.maskedTextBoxTc.Name = "maskedTextBoxTc";
            this.maskedTextBoxTc.Size = new System.Drawing.Size(166, 27);
            this.maskedTextBoxTc.TabIndex = 74;
            this.maskedTextBoxTc.ValidatingType = typeof(int);
            this.maskedTextBoxTc.Click += new System.EventHandler(this.maskedTextBoxTc_Click);
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.BackColor = System.Drawing.SystemColors.Window;
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(228, 123);
            this.maskedTextBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxPhone.Mask = "0000000000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(166, 27);
            this.maskedTextBoxPhone.TabIndex = 73;
            this.maskedTextBoxPhone.ValidatingType = typeof(int);
            this.maskedTextBoxPhone.Click += new System.EventHandler(this.maskedTextBoxPhone_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPhone.Location = new System.Drawing.Point(48, 120);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(152, 30);
            this.labelPhone.TabIndex = 72;
            this.labelPhone.Text = "Telefon No      :";
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTc.Location = new System.Drawing.Point(48, 75);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(149, 30);
            this.labelTc.TabIndex = 71;
            this.labelTc.Text = "T.C. Kimlik No :";
            // 
            // buttonShowPass
            // 
            this.buttonShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowPass.Location = new System.Drawing.Point(256, 174);
            this.buttonShowPass.Name = "buttonShowPass";
            this.buttonShowPass.Size = new System.Drawing.Size(104, 60);
            this.buttonShowPass.TabIndex = 70;
            this.buttonShowPass.Text = "Şifreyi Göster";
            this.buttonShowPass.UseVisualStyleBackColor = true;
            this.buttonShowPass.Click += new System.EventHandler(this.buttonShowPass_Click);
            // 
            // forgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(442, 308);
            this.Controls.Add(this.maskedTextBoxTc);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelTc);
            this.Controls.Add(this.buttonShowPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "forgetPassword";
            this.Text = "Şifremi Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxTc;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.Button buttonShowPass;
    }
}