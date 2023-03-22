
namespace MarketOtomasyonu
{
    partial class CashierPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierPanel));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.groupBoxProductPiece = new System.Windows.Forms.GroupBox();
            this.textBoxProductPiece = new System.Windows.Forms.TextBox();
            this.groupBoxExpirationdate = new System.Windows.Forms.GroupBox();
            this.labelExpirationdate = new System.Windows.Forms.Label();
            this.groupBoxAmountTaken = new System.Windows.Forms.GroupBox();
            this.textBoxAmountTaken = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.groupBoxPiece = new System.Windows.Forms.GroupBox();
            this.textBoxSellingPiece = new System.Windows.Forms.TextBox();
            this.groupBoxBarcode = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxBarcode = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxSelling = new System.Windows.Forms.GroupBox();
            this.labelGrandTotall = new System.Windows.Forms.Label();
            this.labelChangee = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.dataGridViewCashier = new System.Windows.Forms.DataGridView();
            this.productSellingBarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPieceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableCashierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketOtomasyonuDataSetCashier = new MarketOtomasyonu.MarketOtomasyonuDataSetCashier();
            this.table_CashierTableAdapter = new MarketOtomasyonu.MarketOtomasyonuDataSetCashierTableAdapters.Table_CashierTableAdapter();
            this.tableProductOfficerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketOtomasyonuDataSetProductOfficer = new MarketOtomasyonu.MarketOtomasyonuDataSetProductOfficer();
            this.table_ProductOfficerTableAdapter = new MarketOtomasyonu.MarketOtomasyonuDataSetProductOfficerTableAdapters.Table_ProductOfficerTableAdapter();
            this.labelTotall = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.groupBoxTotal = new System.Windows.Forms.GroupBox();
            this.groupBoxProductPiece.SuspendLayout();
            this.groupBoxExpirationdate.SuspendLayout();
            this.groupBoxAmountTaken.SuspendLayout();
            this.groupBoxPiece.SuspendLayout();
            this.groupBoxBarcode.SuspendLayout();
            this.groupBoxSelling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCashierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketOtomasyonuDataSetCashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductOfficerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketOtomasyonuDataSetProductOfficer)).BeginInit();
            this.groupBoxTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Wheat;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDelete.Location = new System.Drawing.Point(910, 657);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(142, 63);
            this.buttonDelete.TabIndex = 206;
            this.buttonDelete.Text = "SİL";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Wheat;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdd.Location = new System.Drawing.Point(502, 657);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(142, 63);
            this.buttonAdd.TabIndex = 205;
            this.buttonAdd.Text = "EKLE";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Wheat;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEdit.Location = new System.Drawing.Point(707, 657);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(142, 63);
            this.buttonEdit.TabIndex = 204;
            this.buttonEdit.Text = "GÜNCELLE";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // groupBoxProductPiece
            // 
            this.groupBoxProductPiece.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBoxProductPiece.Controls.Add(this.textBoxProductPiece);
            this.groupBoxProductPiece.Location = new System.Drawing.Point(800, 237);
            this.groupBoxProductPiece.Name = "groupBoxProductPiece";
            this.groupBoxProductPiece.Size = new System.Drawing.Size(300, 80);
            this.groupBoxProductPiece.TabIndex = 198;
            this.groupBoxProductPiece.TabStop = false;
            this.groupBoxProductPiece.Text = "Stok Adet";
            // 
            // textBoxProductPiece
            // 
            this.textBoxProductPiece.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxProductPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxProductPiece.Location = new System.Drawing.Point(9, 22);
            this.textBoxProductPiece.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductPiece.Multiline = true;
            this.textBoxProductPiece.Name = "textBoxProductPiece";
            this.textBoxProductPiece.Size = new System.Drawing.Size(272, 41);
            this.textBoxProductPiece.TabIndex = 169;
            // 
            // groupBoxExpirationdate
            // 
            this.groupBoxExpirationdate.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBoxExpirationdate.Controls.Add(this.labelExpirationdate);
            this.groupBoxExpirationdate.Location = new System.Drawing.Point(459, 338);
            this.groupBoxExpirationdate.Name = "groupBoxExpirationdate";
            this.groupBoxExpirationdate.Size = new System.Drawing.Size(300, 80);
            this.groupBoxExpirationdate.TabIndex = 202;
            this.groupBoxExpirationdate.TabStop = false;
            this.groupBoxExpirationdate.Text = "Son Kullanma Tarihi";
            // 
            // labelExpirationdate
            // 
            this.labelExpirationdate.AutoSize = true;
            this.labelExpirationdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelExpirationdate.Location = new System.Drawing.Point(15, 29);
            this.labelExpirationdate.Name = "labelExpirationdate";
            this.labelExpirationdate.Size = new System.Drawing.Size(159, 32);
            this.labelExpirationdate.TabIndex = 164;
            this.labelExpirationdate.Text = "00.00.0000";
            // 
            // groupBoxAmountTaken
            // 
            this.groupBoxAmountTaken.BackColor = System.Drawing.Color.Goldenrod;
            this.groupBoxAmountTaken.Controls.Add(this.textBoxAmountTaken);
            this.groupBoxAmountTaken.Location = new System.Drawing.Point(800, 338);
            this.groupBoxAmountTaken.Name = "groupBoxAmountTaken";
            this.groupBoxAmountTaken.Size = new System.Drawing.Size(300, 80);
            this.groupBoxAmountTaken.TabIndex = 196;
            this.groupBoxAmountTaken.TabStop = false;
            this.groupBoxAmountTaken.Text = "Alınan Para";
            this.groupBoxAmountTaken.Visible = false;
            // 
            // textBoxAmountTaken
            // 
            this.textBoxAmountTaken.BackColor = System.Drawing.Color.Goldenrod;
            this.textBoxAmountTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAmountTaken.Location = new System.Drawing.Point(9, 22);
            this.textBoxAmountTaken.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAmountTaken.Multiline = true;
            this.textBoxAmountTaken.Name = "textBoxAmountTaken";
            this.textBoxAmountTaken.Size = new System.Drawing.Size(272, 41);
            this.textBoxAmountTaken.TabIndex = 170;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.Wheat;
            this.buttonConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonConfirm.Location = new System.Drawing.Point(879, 450);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(173, 63);
            this.buttonConfirm.TabIndex = 200;
            this.buttonConfirm.Text = "SATIŞI ONAYLA";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Visible = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // groupBoxPiece
            // 
            this.groupBoxPiece.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBoxPiece.Controls.Add(this.textBoxSellingPiece);
            this.groupBoxPiece.Location = new System.Drawing.Point(459, 450);
            this.groupBoxPiece.Name = "groupBoxPiece";
            this.groupBoxPiece.Size = new System.Drawing.Size(300, 80);
            this.groupBoxPiece.TabIndex = 197;
            this.groupBoxPiece.TabStop = false;
            this.groupBoxPiece.Text = "Adet";
            // 
            // textBoxSellingPiece
            // 
            this.textBoxSellingPiece.BackColor = System.Drawing.Color.BurlyWood;
            this.textBoxSellingPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSellingPiece.Location = new System.Drawing.Point(9, 22);
            this.textBoxSellingPiece.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSellingPiece.Multiline = true;
            this.textBoxSellingPiece.Name = "textBoxSellingPiece";
            this.textBoxSellingPiece.Size = new System.Drawing.Size(272, 41);
            this.textBoxSellingPiece.TabIndex = 169;
            // 
            // groupBoxBarcode
            // 
            this.groupBoxBarcode.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBoxBarcode.Controls.Add(this.maskedTextBoxBarcode);
            this.groupBoxBarcode.Location = new System.Drawing.Point(459, 237);
            this.groupBoxBarcode.Name = "groupBoxBarcode";
            this.groupBoxBarcode.Size = new System.Drawing.Size(300, 80);
            this.groupBoxBarcode.TabIndex = 195;
            this.groupBoxBarcode.TabStop = false;
            this.groupBoxBarcode.Text = "Ürün Barkod No";
            // 
            // maskedTextBoxBarcode
            // 
            this.maskedTextBoxBarcode.BackColor = System.Drawing.Color.BurlyWood;
            this.maskedTextBoxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxBarcode.Location = new System.Drawing.Point(9, 22);
            this.maskedTextBoxBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxBarcode.Mask = "0-000000-000000";
            this.maskedTextBoxBarcode.Name = "maskedTextBoxBarcode";
            this.maskedTextBoxBarcode.Size = new System.Drawing.Size(272, 38);
            this.maskedTextBoxBarcode.TabIndex = 104;
            this.maskedTextBoxBarcode.Click += new System.EventHandler(this.maskedTextBoxBarcode_Click);
            // 
            // groupBoxSelling
            // 
            this.groupBoxSelling.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBoxSelling.Controls.Add(this.labelGrandTotall);
            this.groupBoxSelling.Controls.Add(this.labelChangee);
            this.groupBoxSelling.Controls.Add(this.labelChange);
            this.groupBoxSelling.Controls.Add(this.labelGrandTotal);
            this.groupBoxSelling.Location = new System.Drawing.Point(459, 25);
            this.groupBoxSelling.Name = "groupBoxSelling";
            this.groupBoxSelling.Size = new System.Drawing.Size(676, 180);
            this.groupBoxSelling.TabIndex = 199;
            this.groupBoxSelling.TabStop = false;
            // 
            // labelGrandTotall
            // 
            this.labelGrandTotall.AutoSize = true;
            this.labelGrandTotall.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGrandTotall.Location = new System.Drawing.Point(42, 33);
            this.labelGrandTotall.Name = "labelGrandTotall";
            this.labelGrandTotall.Size = new System.Drawing.Size(352, 70);
            this.labelGrandTotall.TabIndex = 158;
            this.labelGrandTotall.Text = "Genel Toplam  :";
            // 
            // labelChangee
            // 
            this.labelChangee.AutoSize = true;
            this.labelChangee.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelChangee.Location = new System.Drawing.Point(43, 96);
            this.labelChangee.Name = "labelChangee";
            this.labelChangee.Size = new System.Drawing.Size(344, 57);
            this.labelChangee.TabIndex = 160;
            this.labelChangee.Text = "Para Üstü           :";
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelChange.Location = new System.Drawing.Point(462, 108);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(91, 36);
            this.labelChange.TabIndex = 163;
            this.labelChange.Text = "00,00";
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.AutoSize = true;
            this.labelGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGrandTotal.Location = new System.Drawing.Point(443, 48);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(130, 51);
            this.labelGrandTotal.TabIndex = 162;
            this.labelGrandTotal.Text = "00,00";
            // 
            // dataGridViewCashier
            // 
            this.dataGridViewCashier.AutoGenerateColumns = false;
            this.dataGridViewCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCashier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productSellingBarcodeDataGridViewTextBoxColumn,
            this.sellingPieceDataGridViewTextBoxColumn});
            this.dataGridViewCashier.DataSource = this.tableCashierBindingSource;
            this.dataGridViewCashier.Location = new System.Drawing.Point(23, 25);
            this.dataGridViewCashier.Name = "dataGridViewCashier";
            this.dataGridViewCashier.RowHeadersWidth = 51;
            this.dataGridViewCashier.RowTemplate.Height = 24;
            this.dataGridViewCashier.Size = new System.Drawing.Size(404, 709);
            this.dataGridViewCashier.TabIndex = 207;
            this.dataGridViewCashier.DoubleClick += new System.EventHandler(this.dataGridViewCashier_DoubleClick);
            // 
            // productSellingBarcodeDataGridViewTextBoxColumn
            // 
            this.productSellingBarcodeDataGridViewTextBoxColumn.DataPropertyName = "productSellingBarcode";
            this.productSellingBarcodeDataGridViewTextBoxColumn.HeaderText = "productSellingBarcode";
            this.productSellingBarcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productSellingBarcodeDataGridViewTextBoxColumn.Name = "productSellingBarcodeDataGridViewTextBoxColumn";
            this.productSellingBarcodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // sellingPieceDataGridViewTextBoxColumn
            // 
            this.sellingPieceDataGridViewTextBoxColumn.DataPropertyName = "sellingPiece";
            this.sellingPieceDataGridViewTextBoxColumn.HeaderText = "sellingPiece";
            this.sellingPieceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellingPieceDataGridViewTextBoxColumn.Name = "sellingPieceDataGridViewTextBoxColumn";
            this.sellingPieceDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableCashierBindingSource
            // 
            this.tableCashierBindingSource.DataMember = "Table_Cashier";
            this.tableCashierBindingSource.DataSource = this.marketOtomasyonuDataSetCashier;
            // 
            // marketOtomasyonuDataSetCashier
            // 
            this.marketOtomasyonuDataSetCashier.DataSetName = "MarketOtomasyonuDataSetCashier";
            this.marketOtomasyonuDataSetCashier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_CashierTableAdapter
            // 
            this.table_CashierTableAdapter.ClearBeforeFill = true;
            // 
            // tableProductOfficerBindingSource
            // 
            this.tableProductOfficerBindingSource.DataMember = "Table_ProductOfficer";
            this.tableProductOfficerBindingSource.DataSource = this.marketOtomasyonuDataSetProductOfficer;
            // 
            // marketOtomasyonuDataSetProductOfficer
            // 
            this.marketOtomasyonuDataSetProductOfficer.DataSetName = "MarketOtomasyonuDataSetProductOfficer";
            this.marketOtomasyonuDataSetProductOfficer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_ProductOfficerTableAdapter
            // 
            this.table_ProductOfficerTableAdapter.ClearBeforeFill = true;
            // 
            // labelTotall
            // 
            this.labelTotall.AutoSize = true;
            this.labelTotall.Font = new System.Drawing.Font("Segoe Print", 16.2F);
            this.labelTotall.Location = new System.Drawing.Point(10, 20);
            this.labelTotall.Name = "labelTotall";
            this.labelTotall.Size = new System.Drawing.Size(158, 49);
            this.labelTotall.TabIndex = 208;
            this.labelTotall.Text = "Toplam  :";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F);
            this.labelTotal.Location = new System.Drawing.Point(174, 31);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(71, 29);
            this.labelTotal.TabIndex = 209;
            this.labelTotal.Text = "00,00";
            // 
            // groupBoxTotal
            // 
            this.groupBoxTotal.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBoxTotal.Controls.Add(this.labelTotall);
            this.groupBoxTotal.Controls.Add(this.labelTotal);
            this.groupBoxTotal.Location = new System.Drawing.Point(459, 554);
            this.groupBoxTotal.Name = "groupBoxTotal";
            this.groupBoxTotal.Size = new System.Drawing.Size(300, 80);
            this.groupBoxTotal.TabIndex = 198;
            this.groupBoxTotal.TabStop = false;
            this.groupBoxTotal.Text = "Toplam";
            // 
            // CashierPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1165, 773);
            this.Controls.Add(this.groupBoxTotal);
            this.Controls.Add(this.dataGridViewCashier);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.groupBoxProductPiece);
            this.Controls.Add(this.groupBoxExpirationdate);
            this.Controls.Add(this.groupBoxAmountTaken);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.groupBoxPiece);
            this.Controls.Add(this.groupBoxBarcode);
            this.Controls.Add(this.groupBoxSelling);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CashierPanel";
            this.Text = "Kasa Görevlisi Girişi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CashierPanel_FormClosed);
            this.Load += new System.EventHandler(this.CashierPanel_Load);
            this.groupBoxProductPiece.ResumeLayout(false);
            this.groupBoxProductPiece.PerformLayout();
            this.groupBoxExpirationdate.ResumeLayout(false);
            this.groupBoxExpirationdate.PerformLayout();
            this.groupBoxAmountTaken.ResumeLayout(false);
            this.groupBoxAmountTaken.PerformLayout();
            this.groupBoxPiece.ResumeLayout(false);
            this.groupBoxPiece.PerformLayout();
            this.groupBoxBarcode.ResumeLayout(false);
            this.groupBoxBarcode.PerformLayout();
            this.groupBoxSelling.ResumeLayout(false);
            this.groupBoxSelling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCashier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCashierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketOtomasyonuDataSetCashier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductOfficerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketOtomasyonuDataSetProductOfficer)).EndInit();
            this.groupBoxTotal.ResumeLayout(false);
            this.groupBoxTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.GroupBox groupBoxProductPiece;
        private System.Windows.Forms.TextBox textBoxProductPiece;
        private System.Windows.Forms.GroupBox groupBoxExpirationdate;
        private System.Windows.Forms.Label labelExpirationdate;
        private System.Windows.Forms.GroupBox groupBoxAmountTaken;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.GroupBox groupBoxPiece;
        private System.Windows.Forms.TextBox textBoxSellingPiece;
        private System.Windows.Forms.GroupBox groupBoxBarcode;
        private System.Windows.Forms.GroupBox groupBoxSelling;
        private System.Windows.Forms.Label labelGrandTotall;
        private System.Windows.Forms.Label labelChangee;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.DataGridView dataGridViewCashier;
        private MarketOtomasyonuDataSetCashier marketOtomasyonuDataSetCashier;
        private System.Windows.Forms.BindingSource tableCashierBindingSource;
        private MarketOtomasyonuDataSetCashierTableAdapters.Table_CashierTableAdapter table_CashierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSellingBarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBarcode;
        private MarketOtomasyonuDataSetProductOfficer marketOtomasyonuDataSetProductOfficer;
        private System.Windows.Forms.BindingSource tableProductOfficerBindingSource;
        private MarketOtomasyonuDataSetProductOfficerTableAdapters.Table_ProductOfficerTableAdapter table_ProductOfficerTableAdapter;
        private System.Windows.Forms.TextBox textBoxAmountTaken;
        private System.Windows.Forms.Label labelTotall;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.GroupBox groupBoxTotal;
    }
}