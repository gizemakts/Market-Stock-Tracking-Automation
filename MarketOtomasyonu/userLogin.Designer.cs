
namespace MarketOtomasyonu
{
    partial class userLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userLogin));
            this.groupBoxPassword = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBoxTc = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxTc = new System.Windows.Forms.MaskedTextBox();
            this.labelForgetPass = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelTcNo = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.checkBoxShowPas = new System.Windows.Forms.CheckBox();
            this.marketOtomasyonuDataSetUser = new MarketOtomasyonu.MarketOtomasyonuDataSetUser();
            this.tableUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_UserTableAdapter = new MarketOtomasyonu.MarketOtomasyonuDataSetUserTableAdapters.Table_UserTableAdapter();
            this.toolTipClick = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxPassword.SuspendLayout();
            this.groupBoxTc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketOtomasyonuDataSetUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPassword
            // 
            this.groupBoxPassword.Controls.Add(this.textBoxPassword);
            this.groupBoxPassword.Location = new System.Drawing.Point(509, 171);
            this.groupBoxPassword.Name = "groupBoxPassword";
            this.groupBoxPassword.Size = new System.Drawing.Size(320, 60);
            this.groupBoxPassword.TabIndex = 46;
            this.groupBoxPassword.TabStop = false;
            this.groupBoxPassword.Text = "Şifre";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPassword.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxPassword.Location = new System.Drawing.Point(1, 20);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(314, 40);
            this.textBoxPassword.TabIndex = 34;
            // 
            // groupBoxTc
            // 
            this.groupBoxTc.Controls.Add(this.maskedTextBoxTc);
            this.groupBoxTc.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxTc.Location = new System.Drawing.Point(510, 99);
            this.groupBoxTc.Name = "groupBoxTc";
            this.groupBoxTc.Size = new System.Drawing.Size(320, 64);
            this.groupBoxTc.TabIndex = 45;
            this.groupBoxTc.TabStop = false;
            this.groupBoxTc.Text = "T.C. Kimlik No";
            // 
            // maskedTextBoxTc
            // 
            this.maskedTextBoxTc.BackColor = System.Drawing.SystemColors.Control;
            this.maskedTextBoxTc.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.maskedTextBoxTc.Location = new System.Drawing.Point(0, 18);
            this.maskedTextBoxTc.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxTc.Mask = "00000000000";
            this.maskedTextBoxTc.Name = "maskedTextBoxTc";
            this.maskedTextBoxTc.Size = new System.Drawing.Size(314, 40);
            this.maskedTextBoxTc.TabIndex = 79;
            this.maskedTextBoxTc.Click += new System.EventHandler(this.maskedTextBoxTc_Click);
            // 
            // labelForgetPass
            // 
            this.labelForgetPass.AutoSize = true;
            this.labelForgetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForgetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForgetPass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelForgetPass.Location = new System.Drawing.Point(590, 372);
            this.labelForgetPass.Name = "labelForgetPass";
            this.labelForgetPass.Size = new System.Drawing.Size(147, 17);
            this.labelForgetPass.TabIndex = 44;
            this.labelForgetPass.Text = "Şifreni Mi Unuttun?";
            this.labelForgetPass.Click += new System.EventHandler(this.labelForgetPass_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLogin.Location = new System.Drawing.Point(607, 264);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(105, 50);
            this.buttonLogin.TabIndex = 43;
            this.buttonLogin.Text = "Giriş";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "----------------------------- YA DA ------------------------------";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.Image")));
            this.pictureBoxImage.Location = new System.Drawing.Point(0, -45);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(411, 574);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 41;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelTcNo
            // 
            this.labelTcNo.AutoSize = true;
            this.labelTcNo.Location = new System.Drawing.Point(756, 409);
            this.labelTcNo.Name = "labelTcNo";
            this.labelTcNo.Size = new System.Drawing.Size(96, 17);
            this.labelTcNo.TabIndex = 47;
            this.labelTcNo.Text = "11111111111";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(766, 437);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(76, 17);
            this.labelPass.TabIndex = 48;
            this.labelPass.Text = "ayseeldem";
            // 
            // checkBoxShowPas
            // 
            this.checkBoxShowPas.AutoSize = true;
            this.checkBoxShowPas.Location = new System.Drawing.Point(517, 237);
            this.checkBoxShowPas.Name = "checkBoxShowPas";
            this.checkBoxShowPas.Size = new System.Drawing.Size(116, 21);
            this.checkBoxShowPas.TabIndex = 49;
            this.checkBoxShowPas.Text = "Şifreyi Göster";
            this.checkBoxShowPas.UseVisualStyleBackColor = true;
            this.checkBoxShowPas.CheckedChanged += new System.EventHandler(this.checkBoxShowPas_CheckedChanged);
            // 
            // marketOtomasyonuDataSetUser
            // 
            this.marketOtomasyonuDataSetUser.DataSetName = "MarketOtomasyonuDataSetUser";
            this.marketOtomasyonuDataSetUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableUserBindingSource
            // 
            this.tableUserBindingSource.DataMember = "Table_User";
            this.tableUserBindingSource.DataSource = this.marketOtomasyonuDataSetUser;
            // 
            // table_UserTableAdapter
            // 
            this.table_UserTableAdapter.ClearBeforeFill = true;
            // 
            // userLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(874, 485);
            this.Controls.Add(this.checkBoxShowPas);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelTcNo);
            this.Controls.Add(this.groupBoxPassword);
            this.Controls.Add(this.groupBoxTc);
            this.Controls.Add(this.labelForgetPass);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "userLogin";
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.userLogin_Load);
            this.groupBoxPassword.ResumeLayout(false);
            this.groupBoxPassword.PerformLayout();
            this.groupBoxTc.ResumeLayout(false);
            this.groupBoxTc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketOtomasyonuDataSetUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox groupBoxTc;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTc;
        private System.Windows.Forms.Label labelForgetPass;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label labelTcNo;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.CheckBox checkBoxShowPas;
        private MarketOtomasyonuDataSetUser marketOtomasyonuDataSetUser;
        private System.Windows.Forms.BindingSource tableUserBindingSource;
        private MarketOtomasyonuDataSetUserTableAdapters.Table_UserTableAdapter table_UserTableAdapter;
        private System.Windows.Forms.ToolTip toolTipClick;
    }
}

