
namespace MarketOtomasyonu
{
    partial class ProcurementOfficerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcurementOfficerPanel));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewProcurementOfficer = new System.Windows.Forms.DataGridView();
            this.supplierVknDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableProcurementOfficerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketOtomasyonuDataSetProcurementOfficer = new MarketOtomasyonu.MarketOtomasyonuDataSetProcurementOfficer();
            this.maskedTextBoxVkn = new System.Windows.Forms.MaskedTextBox();
            this.labelVkn = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelCompany = new System.Windows.Forms.Label();
            this.table_ProcurementOfficerTableAdapter = new MarketOtomasyonu.MarketOtomasyonuDataSetProcurementOfficerTableAdapters.Table_ProcurementOfficerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcurementOfficer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProcurementOfficerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketOtomasyonuDataSetProcurementOfficer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Location = new System.Drawing.Point(318, 359);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 52);
            this.buttonDelete.TabIndex = 111;
            this.buttonDelete.Text = "SİL";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Location = new System.Drawing.Point(176, 359);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(109, 52);
            this.buttonEdit.TabIndex = 110;
            this.buttonEdit.Text = "GÜNCELLE";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(34, 359);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 52);
            this.buttonAdd.TabIndex = 109;
            this.buttonAdd.Text = "EKLE";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewProcurementOfficer
            // 
            this.dataGridViewProcurementOfficer.AutoGenerateColumns = false;
            this.dataGridViewProcurementOfficer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcurementOfficer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierVknDataGridViewTextBoxColumn,
            this.supplierCompanyDataGridViewTextBoxColumn,
            this.supplierPhoneDataGridViewTextBoxColumn,
            this.supplierMailDataGridViewTextBoxColumn,
            this.supplierAddressDataGridViewTextBoxColumn});
            this.dataGridViewProcurementOfficer.DataSource = this.tableProcurementOfficerBindingSource;
            this.dataGridViewProcurementOfficer.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewProcurementOfficer.Location = new System.Drawing.Point(500, 0);
            this.dataGridViewProcurementOfficer.Name = "dataGridViewProcurementOfficer";
            this.dataGridViewProcurementOfficer.RowHeadersWidth = 51;
            this.dataGridViewProcurementOfficer.RowTemplate.Height = 24;
            this.dataGridViewProcurementOfficer.Size = new System.Drawing.Size(679, 496);
            this.dataGridViewProcurementOfficer.TabIndex = 108;
            this.dataGridViewProcurementOfficer.DoubleClick += new System.EventHandler(this.dataGridViewProcurementOfficer_DoubleClick);
            // 
            // supplierVknDataGridViewTextBoxColumn
            // 
            this.supplierVknDataGridViewTextBoxColumn.DataPropertyName = "supplierVkn";
            this.supplierVknDataGridViewTextBoxColumn.HeaderText = "supplierVkn";
            this.supplierVknDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierVknDataGridViewTextBoxColumn.Name = "supplierVknDataGridViewTextBoxColumn";
            this.supplierVknDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierCompanyDataGridViewTextBoxColumn
            // 
            this.supplierCompanyDataGridViewTextBoxColumn.DataPropertyName = "supplierCompany";
            this.supplierCompanyDataGridViewTextBoxColumn.HeaderText = "supplierCompany";
            this.supplierCompanyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierCompanyDataGridViewTextBoxColumn.Name = "supplierCompanyDataGridViewTextBoxColumn";
            this.supplierCompanyDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierPhoneDataGridViewTextBoxColumn
            // 
            this.supplierPhoneDataGridViewTextBoxColumn.DataPropertyName = "supplierPhone";
            this.supplierPhoneDataGridViewTextBoxColumn.HeaderText = "supplierPhone";
            this.supplierPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierPhoneDataGridViewTextBoxColumn.Name = "supplierPhoneDataGridViewTextBoxColumn";
            this.supplierPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierMailDataGridViewTextBoxColumn
            // 
            this.supplierMailDataGridViewTextBoxColumn.DataPropertyName = "supplierMail";
            this.supplierMailDataGridViewTextBoxColumn.HeaderText = "supplierMail";
            this.supplierMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierMailDataGridViewTextBoxColumn.Name = "supplierMailDataGridViewTextBoxColumn";
            this.supplierMailDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierAddressDataGridViewTextBoxColumn
            // 
            this.supplierAddressDataGridViewTextBoxColumn.DataPropertyName = "supplierAddress";
            this.supplierAddressDataGridViewTextBoxColumn.HeaderText = "supplierAddress";
            this.supplierAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierAddressDataGridViewTextBoxColumn.Name = "supplierAddressDataGridViewTextBoxColumn";
            this.supplierAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableProcurementOfficerBindingSource
            // 
            this.tableProcurementOfficerBindingSource.DataMember = "Table_ProcurementOfficer";
            this.tableProcurementOfficerBindingSource.DataSource = this.marketOtomasyonuDataSetProcurementOfficer;
            // 
            // marketOtomasyonuDataSetProcurementOfficer
            // 
            this.marketOtomasyonuDataSetProcurementOfficer.DataSetName = "MarketOtomasyonuDataSetProcurementOfficer";
            this.marketOtomasyonuDataSetProcurementOfficer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedTextBoxVkn
            // 
            this.maskedTextBoxVkn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxVkn.Location = new System.Drawing.Point(261, 103);
            this.maskedTextBoxVkn.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxVkn.Mask = "0000000000";
            this.maskedTextBoxVkn.Name = "maskedTextBoxVkn";
            this.maskedTextBoxVkn.Size = new System.Drawing.Size(166, 27);
            this.maskedTextBoxVkn.TabIndex = 107;
            this.maskedTextBoxVkn.Click += new System.EventHandler(this.maskedTextBoxVkn_Click);
            // 
            // labelVkn
            // 
            this.labelVkn.AutoSize = true;
            this.labelVkn.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.labelVkn.Location = new System.Drawing.Point(27, 100);
            this.labelVkn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVkn.Name = "labelVkn";
            this.labelVkn.Size = new System.Drawing.Size(212, 30);
            this.labelVkn.TabIndex = 106;
            this.labelVkn.Text = "Vergi Kimlik No        :";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMail.Location = new System.Drawing.Point(261, 247);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMail.MaxLength = 50;
            this.textBoxMail.Multiline = true;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(166, 28);
            this.textBoxMail.TabIndex = 105;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.labelMail.Location = new System.Drawing.Point(29, 244);
            this.labelMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(210, 30);
            this.labelMail.TabIndex = 104;
            this.labelMail.Text = "Tedarikçi Mail          :";
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCompany.Location = new System.Drawing.Point(261, 151);
            this.textBoxCompany.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCompany.MaxLength = 50;
            this.textBoxCompany.Multiline = true;
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(166, 28);
            this.textBoxCompany.TabIndex = 103;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAddress.Location = new System.Drawing.Point(261, 295);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddress.MaxLength = 100;
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(166, 28);
            this.textBoxAddress.TabIndex = 102;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(261, 199);
            this.maskedTextBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxPhone.Mask = "(999) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(166, 27);
            this.maskedTextBoxPhone.TabIndex = 101;
            this.maskedTextBoxPhone.Click += new System.EventHandler(this.maskedTextBoxPhone_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.labelAddress.Location = new System.Drawing.Point(29, 292);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(209, 30);
            this.labelAddress.TabIndex = 100;
            this.labelAddress.Text = "Tedarikçi Adres        :";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.labelPhone.Location = new System.Drawing.Point(29, 196);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(210, 30);
            this.labelPhone.TabIndex = 99;
            this.labelPhone.Text = "Tedarikçi Telefon No  :";
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.labelCompany.Location = new System.Drawing.Point(29, 148);
            this.labelCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(212, 30);
            this.labelCompany.TabIndex = 98;
            this.labelCompany.Text = "Tedarikçi Firma Adı   :";
            // 
            // table_ProcurementOfficerTableAdapter
            // 
            this.table_ProcurementOfficerTableAdapter.ClearBeforeFill = true;
            // 
            // ProcurementOfficerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1179, 496);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewProcurementOfficer);
            this.Controls.Add(this.maskedTextBoxVkn);
            this.Controls.Add(this.labelVkn);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelCompany);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProcurementOfficerPanel";
            this.Text = "Tedarik Görevlisi Girişi";
            this.Load += new System.EventHandler(this.ProcurementOfficerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcurementOfficer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProcurementOfficerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketOtomasyonuDataSetProcurementOfficer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewProcurementOfficer;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxVkn;
        private System.Windows.Forms.Label labelVkn;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelCompany;
        private MarketOtomasyonuDataSetProcurementOfficer marketOtomasyonuDataSetProcurementOfficer;
        private System.Windows.Forms.BindingSource tableProcurementOfficerBindingSource;
        private MarketOtomasyonuDataSetProcurementOfficerTableAdapters.Table_ProcurementOfficerTableAdapter table_ProcurementOfficerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierVknDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierAddressDataGridViewTextBoxColumn;
    }
}