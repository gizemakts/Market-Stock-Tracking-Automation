using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu
{
    public partial class ProductOfficerPanel : Form
    {
        DatabaseConnect product = new DatabaseConnect();
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-N1JINFUV;Initial Catalog=MarketOtomasyonu;Integrated Security=True");

        public ProductOfficerPanel()
        {
            InitializeComponent();
        }
        private void ProductOfficerPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketOtomasyonuDataSetProductOfficer.Table_ProductOfficer' table. You can move, or remove it, as needed.
            this.table_ProductOfficerTableAdapter.Fill(this.marketOtomasyonuDataSetProductOfficer.Table_ProductOfficer);
            Yenile();
        }
        private void Yenile()
        {
            //tabloya data çekme
            string ekle = "select *from Table_ProductOfficer";
            SqlDataAdapter listeleyici = new SqlDataAdapter();
            dataGridViewProductOfficer.DataSource = product.listele(listeleyici, ekle);

            //tablonun yazı ayarları
            dataGridViewProductOfficer.Columns[0].HeaderText = "Barkod No";
            dataGridViewProductOfficer.Columns[1].HeaderText = "Adı";
            dataGridViewProductOfficer.Columns[2].HeaderText = "Kategorisi";
            dataGridViewProductOfficer.Columns[3].HeaderText = "Ürün Markası";
            dataGridViewProductOfficer.Columns[4].HeaderText = "Son Kullanma Tarihi";
            dataGridViewProductOfficer.Columns[5].HeaderText = "Alış Fiyatı";
            dataGridViewProductOfficer.Columns[6].HeaderText = "Satış Fiyatı";
            dataGridViewProductOfficer.Columns[7].HeaderText = "Adedi";

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (maskedTextBoxBarcode.Text == "" || textBoxName.Text == "" || comboBoxCategory.Text == "" || textBoxTrademark.Text == "" || maskedTextBoxExpirationdate.Text == "" || textBoxProductPurchasePrice.Text == "" || textBoxPriece.Text == "" || textBoxPiece.Text == "")
            {
                MessageBox.Show("Tüm bilgileri eksiksiz doldurunuz.", "Eksik veri girişi",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komut = new SqlCommand("select * from Table_ProductOfficer where productBarcode like'%" + maskedTextBoxBarcode.Text + "%'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    MessageBox.Show("Bu Tc Kimlik Nosunu zaten eklediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string ekle = "insert into Table_ProductOfficer(productBarcode, productName, productCategory, productTrademark, productExpirationdate, productPurchasePrice, productSalePriece, productPiece ) " +
                    "values(@productBarcode, @productName, @productCategory, @productTrademark, @productExpirationdate, @productPurchasePrice, @productSalePriece, @productPiece )";

                    SqlCommand yap = new SqlCommand();

                    yap.Parameters.AddWithValue("@productBarcode", maskedTextBoxBarcode.Text);
                    yap.Parameters.AddWithValue("@productName", textBoxName.Text);
                    yap.Parameters.AddWithValue("@productCategory", comboBoxCategory.Text);
                    yap.Parameters.AddWithValue("@productTrademark", textBoxTrademark.Text);
                    yap.Parameters.AddWithValue("@productExpirationdate", maskedTextBoxExpirationdate.Text);
                    yap.Parameters.AddWithValue("@productPurchasePrice", textBoxProductPurchasePrice.Text);
                    yap.Parameters.AddWithValue("@productSalePriece", textBoxPriece.Text);
                    yap.Parameters.AddWithValue("@productPiece", textBoxPiece.Text);
                    product.addDeleteEdit(yap, ekle);

                    //textbox temizler
                    foreach (Control item in Controls) if (item is TextBox)
                            item.Text = "";
                    //combobox temizler
                    foreach (Control item in Controls) if (item is ComboBox)
                            item.Text = "";
                    //maskedtextbox temizler
                    foreach (Control item in Controls) if (item is MaskedTextBox)
                            item.Text = "";
                    Yenile();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || comboBoxCategory.Text == "" || textBoxTrademark.Text == "" || maskedTextBoxExpirationdate.Text == "" || textBoxProductPurchasePrice.Text == "" || textBoxPriece.Text == "" || textBoxPiece.Text == "")
            {
                MessageBox.Show("Tüm bilgileri eksiksiz doldurunuz.", "Eksik veri girişi",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ekle = "update Table_ProductOfficer set productName=@productName, productCategory=@productCategory, productTrademark=@productTrademark, productExpirationdate=@productExpirationdate, productPurchasePrice=@productPurchasePrice, productSalePriece=@productSalePriece, productPiece=@productPiece WHERE productBarcode=@productBarcode";

                SqlCommand yap = new SqlCommand();

                yap.Parameters.AddWithValue("@productBarcode", maskedTextBoxBarcode.Text);
                yap.Parameters.AddWithValue("@productName", textBoxName.Text);
                yap.Parameters.AddWithValue("@productCategory", comboBoxCategory.Text);
                yap.Parameters.AddWithValue("@productTrademark", textBoxTrademark.Text);
                yap.Parameters.AddWithValue("@productExpirationdate", maskedTextBoxExpirationdate.Text);
                yap.Parameters.AddWithValue("@productPurchasePrice", textBoxProductPurchasePrice.Text);
                yap.Parameters.AddWithValue("@productSalePriece", textBoxPriece.Text);
                yap.Parameters.AddWithValue("@productPiece", textBoxPiece.Text);
                product.addDeleteEdit(yap, ekle);

                //textbox temizler
                foreach (Control item in Controls) if (item is TextBox)
                        item.Text = "";
                //combobox temizler
                foreach (Control item in Controls) if (item is ComboBox)
                        item.Text = "";
                //maskedtextbox temizler
                foreach (Control item in Controls) if (item is MaskedTextBox)
                        item.Text = "";
                Yenile();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductOfficer.CurrentRow != null)
            {
                DataGridViewRow satir = dataGridViewProductOfficer.CurrentRow;
                SqlCommand yap = new SqlCommand();

                string ekle = "delete from Table_ProductOfficer where productBarcode='" + satir.Cells[0].Value.ToString() + "'";
                product.addDeleteEdit(yap, ekle);
                Yenile();
            }
            else
            {
                MessageBox.Show("Silinecek bilgi yok.", "Silme başarısız.",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProductOfficer_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridViewProductOfficer.CurrentRow;
            maskedTextBoxBarcode.Text = satir.Cells[0].Value.ToString();
            textBoxName.Text = satir.Cells[1].Value.ToString();
            comboBoxCategory.Text = satir.Cells[2].Value.ToString();
            textBoxTrademark.Text = satir.Cells[3].Value.ToString();
            maskedTextBoxExpirationdate.Text = satir.Cells[4].Value.ToString();
            textBoxProductPurchasePrice.Text = satir.Cells[5].Value.ToString();
            textBoxPriece.Text = satir.Cells[6].Value.ToString();
            textBoxPiece.Text = satir.Cells[7].Value.ToString();
        }

        private void maskedTextBoxBarcode_Click(object sender, EventArgs e)
        {
            maskedTextBoxBarcode.Select(0, 0);

        }

        private void maskedTextBoxExpirationdate_Click(object sender, EventArgs e)
        {
            maskedTextBoxExpirationdate.Select(0, 0);

        }
    }
}
