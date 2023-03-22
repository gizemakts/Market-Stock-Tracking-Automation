
namespace MarketOtomasyonu
{
    partial class ProductOfficerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductOfficerPanel));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxPiece = new System.Windows.Forms.TextBox();
            this.labelPiece = new System.Windows.Forms.Label();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.maskedTextBoxExpirationdate = new System.Windows.Forms.MaskedTextBox();
            this.labelExpirationdate = new System.Windows.Forms.Label();
            this.textBoxTrademark = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelTrademark = new System.Windows.Forms.Label();
            this.labelPriece = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelProductPurchasePrice = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dataGridViewProductOfficer = new System.Windows.Forms.DataGridView();
            this.productBarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTrademarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productExpirationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPurchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSalePrieceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPieceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableProductOfficerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marketOtomasyonuDataSetProductOfficer = new MarketOtomasyonu.MarketOtomasyonuDataSetProductOfficer();
            this.table_ProductOfficerTableAdapter = new MarketOtomasyonu.MarketOtomasyonuDataSetProductOfficerTableAdapters.Table_ProductOfficerTableAdapter();
            this.maskedTextBoxBarcode = new System.Windows.Forms.MaskedTextBox();
            this.textBoxProductPurchasePrice = new System.Windows.Forms.TextBox();
            this.textBoxPriece = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductOfficer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductOfficerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketOtomasyonuDataSetProductOfficer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Location = new System.Drawing.Point(325, 475);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 52);
            this.buttonDelete.TabIndex = 112;
            this.buttonDelete.Text = "SİL";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Location = new System.Drawing.Point(183, 475);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(109, 52);
            this.buttonEdit.TabIndex = 109;
            this.buttonEdit.Text = "GÜNCELLE";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxPiece
            // 
            this.textBoxPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPiece.Location = new System.Drawing.Point(278, 409);
            this.textBoxPiece.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPiece.MaxLength = 999;
            this.textBoxPiece.Multiline = true;
            this.textBoxPiece.Name = "textBoxPiece";
            this.textBoxPiece.Size = new System.Drawing.Size(166, 28);
            this.textBoxPiece.TabIndex = 108;
            // 
            // labelPiece
            // 
            this.labelPiece.AutoSize = true;
            this.labelPiece.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.labelPiece.Location = new System.Drawing.Point(36, 406);
            this.labelPiece.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPiece.Name = "labelPiece";
            this.labelPiece.Size = new System.Drawing.Size(215, 30);
            this.labelPiece.TabIndex = 107;
            this.labelPiece.Text = "Ürün Adedi              :";
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.labelBarcode.Location = new System.Drawing.Point(36, 70);
            this.labelBarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(210, 30);
            this.labelBarcode.TabIndex = 105;
            this.labelBarcode.Text = "Ürün Barkod No       :";
            // 
            // maskedTextBoxExpirationdate
            // 
            this.maskedTextBoxExpirationdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxExpirationdate.Location = new System.Drawing.Point(278, 265);
            this.maskedTextBoxExpirationdate.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxExpirationdate.Mask = "00/00/0000";
            this.maskedTextBoxExpirationdate.Name = "maskedTextBoxExpirationdate";
            this.maskedTextBoxExpirationdate.Size = new System.Drawing.Size(166, 27);
            this.maskedTextBoxExpirationdate.TabIndex = 104;
            this.maskedTextBoxExpirationdate.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxExpirationdate.Click += new System.EventHandler(this.maskedTextBoxExpirationdate_Click);
            // 
            // labelExpirationdate
            // 
            this.labelExpirationdate.AutoSize = true;
            this.labelExpirationdate.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.labelExpirationdate.Location = new System.Drawing.Point(36, 262);
            this.labelExpirationdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExpirationdate.Name = "labelExpirationdate";
            this.labelExpirationdate.Size = new System.Drawing.Size(210, 30);
            this.labelExpirationdate.TabIndex = 103;
            this.labelExpirationdate.Text = "Son Kullanma Tarihi  :";
            // 
            // textBoxTrademark
            // 
            this.textBoxTrademark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTrademark.Location = new System.Drawing.Point(278, 217);
            this.textBoxTrademark.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTrademark.MaxLength = 50;
            this.textBoxTrademark.Multiline = true;
            this.textBoxTrademark.Name = "textBoxTrademark";
            this.textBoxTrademark.Size = new System.Drawing.Size(166, 28);
            this.textBoxTrademark.TabIndex = 102;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Meyve/Sebze",
            "Et/Tavuk/Balık",
            "Süt/Kahvaltılık",
            "Gıda/Şekerleme",
            "İçecek",
            "Deterjan/Temizlik",
            "Kağıt/Kozmetik",
            "Bebek/Oyuncak",
            "Ev/Pet",
            "Elektronik"});
            this.comboBoxCategory.Location = new System.Drawing.Point(278, 169);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(166, 28);
            this.comboBoxCategory.TabIndex = 101;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(41, 475);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 52);
            this.buttonAdd.TabIndex = 100;
            this.buttonAdd.Text = "EKLE";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.labelCategory.Location = new System.Drawing.Point(36, 166);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(212, 30);
            this.labelCategory.TabIndex = 99;
            this.labelCategory.Text = "Ürün Kategori          :";
            // 
            // labelTrademark
            // 
            this.labelTrademark.AutoSize = true;
            this.labelTrademark.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.labelTrademark.Location = new System.Drawing.Point(36, 214);
            this.labelTrademark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTrademark.Name = "labelTrademark";
            this.labelTrademark.Size = new System.Drawing.Size(212, 30);
            this.labelTrademark.TabIndex = 98;
            this.labelTrademark.Text = "Ürün Markası           :";
            // 
            // labelPriece
            // 
            this.labelPriece.AutoSize = true;
            this.labelPriece.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.labelPriece.Location = new System.Drawing.Point(36, 358);
            this.labelPriece.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPriece.Name = "labelPriece";
            this.labelPriece.Size = new System.Drawing.Size(213, 30);
            this.labelPriece.TabIndex = 97;
            this.labelPriece.Text = "Ürün Satış Fiyatı       :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.labelName.Location = new System.Drawing.Point(36, 118);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(209, 30);
            this.labelName.TabIndex = 96;
            this.labelName.Text = "Ürün Adı                :";
            // 
            // labelProductPurchasePrice
            // 
            this.labelProductPurchasePrice.AutoSize = true;
            this.labelProductPurchasePrice.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.labelProductPurchasePrice.Location = new System.Drawing.Point(36, 310);
            this.labelProductPurchasePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductPurchasePrice.Name = "labelProductPurchasePrice";
            this.labelProductPurchasePrice.Size = new System.Drawing.Size(209, 30);
            this.labelProductPurchasePrice.TabIndex = 95;
            this.labelProductPurchasePrice.Text = "Ürün Alış Fiyatı        :";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxName.Location = new System.Drawing.Point(278, 121);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(166, 28);
            this.textBoxName.TabIndex = 94;
            // 
            // dataGridViewProductOfficer
            // 
            this.dataGridViewProductOfficer.AutoGenerateColumns = false;
            this.dataGridViewProductOfficer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductOfficer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productBarcodeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productCategoryDataGridViewTextBoxColumn,
            this.productTrademarkDataGridViewTextBoxColumn,
            this.productExpirationdateDataGridViewTextBoxColumn,
            this.productPurchasePriceDataGridViewTextBoxColumn,
            this.productSalePrieceDataGridViewTextBoxColumn,
            this.productPieceDataGridViewTextBoxColumn});
            this.dataGridViewProductOfficer.DataSource = this.tableProductOfficerBindingSource;
            this.dataGridViewProductOfficer.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewProductOfficer.Location = new System.Drawing.Point(487, 0);
            this.dataGridViewProductOfficer.Name = "dataGridViewProductOfficer";
            this.dataGridViewProductOfficer.RowHeadersWidth = 51;
            this.dataGridViewProductOfficer.RowTemplate.Height = 24;
            this.dataGridViewProductOfficer.Size = new System.Drawing.Size(990, 606);
            this.dataGridViewProductOfficer.TabIndex = 113;
            this.dataGridViewProductOfficer.DoubleClick += new System.EventHandler(this.dataGridViewProductOfficer_DoubleClick);
            // 
            // productBarcodeDataGridViewTextBoxColumn
            // 
            this.productBarcodeDataGridViewTextBoxColumn.DataPropertyName = "productBarcode";
            this.productBarcodeDataGridViewTextBoxColumn.HeaderText = "productBarcode";
            this.productBarcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productBarcodeDataGridViewTextBoxColumn.Name = "productBarcodeDataGridViewTextBoxColumn";
            this.productBarcodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productCategoryDataGridViewTextBoxColumn
            // 
            this.productCategoryDataGridViewTextBoxColumn.DataPropertyName = "productCategory";
            this.productCategoryDataGridViewTextBoxColumn.HeaderText = "productCategory";
            this.productCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productCategoryDataGridViewTextBoxColumn.Name = "productCategoryDataGridViewTextBoxColumn";
            this.productCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // productTrademarkDataGridViewTextBoxColumn
            // 
            this.productTrademarkDataGridViewTextBoxColumn.DataPropertyName = "productTrademark";
            this.productTrademarkDataGridViewTextBoxColumn.HeaderText = "productTrademark";
            this.productTrademarkDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productTrademarkDataGridViewTextBoxColumn.Name = "productTrademarkDataGridViewTextBoxColumn";
            this.productTrademarkDataGridViewTextBoxColumn.Width = 125;
            // 
            // productExpirationdateDataGridViewTextBoxColumn
            // 
            this.productExpirationdateDataGridViewTextBoxColumn.DataPropertyName = "productExpirationdate";
            this.productExpirationdateDataGridViewTextBoxColumn.HeaderText = "productExpirationdate";
            this.productExpirationdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productExpirationdateDataGridViewTextBoxColumn.Name = "productExpirationdateDataGridViewTextBoxColumn";
            this.productExpirationdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // productPurchasePriceDataGridViewTextBoxColumn
            // 
            this.productPurchasePriceDataGridViewTextBoxColumn.DataPropertyName = "productPurchasePrice";
            this.productPurchasePriceDataGridViewTextBoxColumn.HeaderText = "productPurchasePrice";
            this.productPurchasePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPurchasePriceDataGridViewTextBoxColumn.Name = "productPurchasePriceDataGridViewTextBoxColumn";
            this.productPurchasePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productSalePrieceDataGridViewTextBoxColumn
            // 
            this.productSalePrieceDataGridViewTextBoxColumn.DataPropertyName = "productSalePriece";
            this.productSalePrieceDataGridViewTextBoxColumn.HeaderText = "productSalePriece";
            this.productSalePrieceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productSalePrieceDataGridViewTextBoxColumn.Name = "productSalePrieceDataGridViewTextBoxColumn";
            this.productSalePrieceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productPieceDataGridViewTextBoxColumn
            // 
            this.productPieceDataGridViewTextBoxColumn.DataPropertyName = "productPiece";
            this.productPieceDataGridViewTextBoxColumn.HeaderText = "productPiece";
            this.productPieceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPieceDataGridViewTextBoxColumn.Name = "productPieceDataGridViewTextBoxColumn";
            this.productPieceDataGridViewTextBoxColumn.Width = 125;
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
            // maskedTextBoxBarcode
            // 
            this.maskedTextBoxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxBarcode.Location = new System.Drawing.Point(278, 73);
            this.maskedTextBoxBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxBarcode.Mask = "0-000000-000000";
            this.maskedTextBoxBarcode.Name = "maskedTextBoxBarcode";
            this.maskedTextBoxBarcode.Size = new System.Drawing.Size(166, 27);
            this.maskedTextBoxBarcode.TabIndex = 106;
            this.maskedTextBoxBarcode.Click += new System.EventHandler(this.maskedTextBoxBarcode_Click);
            // 
            // textBoxProductPurchasePrice
            // 
            this.textBoxProductPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxProductPurchasePrice.Location = new System.Drawing.Point(278, 313);
            this.textBoxProductPurchasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductPurchasePrice.MaxLength = 50;
            this.textBoxProductPurchasePrice.Multiline = true;
            this.textBoxProductPurchasePrice.Name = "textBoxProductPurchasePrice";
            this.textBoxProductPurchasePrice.Size = new System.Drawing.Size(166, 28);
            this.textBoxProductPurchasePrice.TabIndex = 114;
            // 
            // textBoxPriece
            // 
            this.textBoxPriece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPriece.Location = new System.Drawing.Point(278, 361);
            this.textBoxPriece.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPriece.MaxLength = 999;
            this.textBoxPriece.Multiline = true;
            this.textBoxPriece.Name = "textBoxPriece";
            this.textBoxPriece.Size = new System.Drawing.Size(166, 28);
            this.textBoxPriece.TabIndex = 115;
            // 
            // ProductOfficerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1477, 606);
            this.Controls.Add(this.textBoxPriece);
            this.Controls.Add(this.textBoxProductPurchasePrice);
            this.Controls.Add(this.dataGridViewProductOfficer);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxPiece);
            this.Controls.Add(this.labelPiece);
            this.Controls.Add(this.maskedTextBoxBarcode);
            this.Controls.Add(this.labelBarcode);
            this.Controls.Add(this.maskedTextBoxExpirationdate);
            this.Controls.Add(this.labelExpirationdate);
            this.Controls.Add(this.textBoxTrademark);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelTrademark);
            this.Controls.Add(this.labelPriece);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelProductPurchasePrice);
            this.Controls.Add(this.textBoxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProductOfficerPanel";
            this.Text = "Ürün Görevlisi Girişi";
            this.Load += new System.EventHandler(this.ProductOfficerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductOfficer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductOfficerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketOtomasyonuDataSetProductOfficer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxPiece;
        private System.Windows.Forms.Label labelPiece;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxExpirationdate;
        private System.Windows.Forms.Label labelExpirationdate;
        private System.Windows.Forms.TextBox textBoxTrademark;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelTrademark;
        private System.Windows.Forms.Label labelPriece;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelProductPurchasePrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DataGridView dataGridViewProductOfficer;
        private MarketOtomasyonuDataSetProductOfficer marketOtomasyonuDataSetProductOfficer;
        private System.Windows.Forms.BindingSource tableProductOfficerBindingSource;
        private MarketOtomasyonuDataSetProductOfficerTableAdapters.Table_ProductOfficerTableAdapter table_ProductOfficerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTrademarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productExpirationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPurchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSalePrieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBarcode;
        private System.Windows.Forms.TextBox textBoxProductPurchasePrice;
        private System.Windows.Forms.TextBox textBoxPriece;
    }
}