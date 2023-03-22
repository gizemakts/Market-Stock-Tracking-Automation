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
    public partial class ProcurementOfficerPanel : Form
    {
        DatabaseConnect supplier = new DatabaseConnect();
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-N1JINFUV;Initial Catalog=MarketOtomasyonu;Integrated Security=True");

        public ProcurementOfficerPanel()
        {
            InitializeComponent();
        }
        private void ProcurementOfficerPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketOtomasyonuDataSetProcurementOfficer.Table_ProcurementOfficer' table. You can move, or remove it, as needed.
            this.table_ProcurementOfficerTableAdapter.Fill(this.marketOtomasyonuDataSetProcurementOfficer.Table_ProcurementOfficer);
            Yenile();
        }
        private void Yenile()
        {
            //tabloya data çekme
            string ekle = "select *from Table_ProcurementOfficer";
            SqlDataAdapter listeleyici = new SqlDataAdapter();
            dataGridViewProcurementOfficer.DataSource = supplier.listele(listeleyici, ekle);

            //tablonun yazı ayarları
            dataGridViewProcurementOfficer.Columns[0].HeaderText = "Vergi Kimlik No";
            dataGridViewProcurementOfficer.Columns[1].HeaderText = "Firma Adı";
            dataGridViewProcurementOfficer.Columns[2].HeaderText = "Telefon No";
            dataGridViewProcurementOfficer.Columns[3].HeaderText = "Mail";
            dataGridViewProcurementOfficer.Columns[4].HeaderText = "Adres";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (maskedTextBoxVkn.Text == "" || textBoxCompany.Text == "" || maskedTextBoxPhone.Text == "" || textBoxMail.Text == "" || textBoxAddress.Text == "")
            {
                MessageBox.Show("Tüm bilgileri eksiksiz doldurunuz.", "Eksik veri girişi",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komut = new SqlCommand("select * from Table_ProcurementOfficer where supplierVkn like'%" + maskedTextBoxVkn.Text + "%'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    MessageBox.Show("Bu Vergi Kİmlik Nosunu zaten eklediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string ekle = "insert into Table_ProcurementOfficer(supplierVkn, supplierCompany, supplierPhone, supplierMail, supplierAddress) " +
                    "values(@supplierVkn, @supplierCompany, @supplierPhone, @supplierMail, @supplierAddress)";

                    SqlCommand yap = new SqlCommand();

                    yap.Parameters.AddWithValue("@supplierVkn", maskedTextBoxVkn.Text);
                    yap.Parameters.AddWithValue("@supplierCompany", textBoxCompany.Text);
                    yap.Parameters.AddWithValue("@supplierPhone", maskedTextBoxPhone.Text);
                    yap.Parameters.AddWithValue("@supplierMail", textBoxMail.Text);
                    yap.Parameters.AddWithValue("@supplierAddress", textBoxAddress.Text);

                    supplier.addDeleteEdit(yap, ekle);

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
            if (maskedTextBoxVkn.Text == "" || textBoxCompany.Text == "" || maskedTextBoxPhone.Text == "" || textBoxMail.Text == "" || textBoxAddress.Text == "")
            {
                MessageBox.Show("Tüm bilgileri eksiksiz doldurunuz.", "Eksik veri girişi",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ekle = "update Table_ProcurementOfficer set supplierCompany=@supplierCompany, supplierPhone=@supplierPhone, supplierMail=@supplierMail, supplierAddress=@supplierAddress WHERE supplierVkn=@supplierVkn";

                SqlCommand yap = new SqlCommand();

                yap.Parameters.AddWithValue("@supplierVkn", maskedTextBoxVkn.Text);
                yap.Parameters.AddWithValue("@supplierCompany", textBoxCompany.Text);
                yap.Parameters.AddWithValue("@supplierPhone", maskedTextBoxPhone.Text);
                yap.Parameters.AddWithValue("@supplierMail", textBoxMail.Text);
                yap.Parameters.AddWithValue("@supplierAddress", textBoxAddress.Text);

                supplier.addDeleteEdit(yap, ekle);

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
            if (dataGridViewProcurementOfficer.CurrentRow != null)
            {
                DataGridViewRow satir = dataGridViewProcurementOfficer.CurrentRow;
                SqlCommand yap = new SqlCommand();

                string ekle = "delete from Table_ProcurementOfficer where supplierVkn='" + satir.Cells[0].Value.ToString() + "'";
                supplier.addDeleteEdit(yap, ekle);
                Yenile();
            }
            else
            {
                MessageBox.Show("Silinecek bilgi yok.", "Silme başarısız.",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewProcurementOfficer_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridViewProcurementOfficer.CurrentRow;
            maskedTextBoxVkn.Text = satir.Cells[0].Value.ToString();
            textBoxCompany.Text = satir.Cells[1].Value.ToString();
            maskedTextBoxPhone.Text = satir.Cells[2].Value.ToString();
            textBoxMail.Text = satir.Cells[3].Value.ToString();
            textBoxAddress.Text = satir.Cells[4].Value.ToString();
        }
        private void maskedTextBoxVkn_Click(object sender, EventArgs e)
        {
            maskedTextBoxVkn.Select(0, 0);
        }
        private void maskedTextBoxPhone_Click(object sender, EventArgs e)
        {
            maskedTextBoxPhone.Select(0, 0);
        }
    }
}
