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
    public partial class User : Form
    {
        DatabaseConnect user = new DatabaseConnect();
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-N1JINFUV;Initial Catalog=MarketOtomasyonu;Integrated Security=True");

        public User()
        {
            InitializeComponent();
        }
        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketOtomasyonuDataSetUser.Table_User' table. You can move, or remove it, as needed.
            this.table_UserTableAdapter.Fill(this.marketOtomasyonuDataSetUser.Table_User);
            Yenile();
        }
        private void Yenile()
        {
            //tabloya data çekme
            string ekle = "select *from Table_User";
            SqlDataAdapter listeleyici = new SqlDataAdapter();
            dataGridViewUser.DataSource = user.listele(listeleyici, ekle);

            //tablonun yazı ayarları
            dataGridViewUser.Columns[0].HeaderText = "Tc No";
            dataGridViewUser.Columns[1].HeaderText = "Adı";
            dataGridViewUser.Columns[2].HeaderText = "Soyadı";
            dataGridViewUser.Columns[3].HeaderText = "Yetkisi";
            dataGridViewUser.Columns[4].HeaderText = "Telefon Numarası";
            dataGridViewUser.Columns[5].HeaderText = "Mail Adresi";
            dataGridViewUser.Columns[6].HeaderText = "Şifresi";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (maskedTextBoxTc.Text == "" || textBoxName.Text == "" || textBoxSurname.Text == "" || comboBoxAuthority.Text == "" || maskedTextBoxPhone.Text == "" || textBoxMail.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Tüm bilgileri eksiksiz doldurunuz.", "Eksik veri girişi",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komut = new SqlCommand("select * from Table_User where tc like'%" + maskedTextBoxTc.Text + "%'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    MessageBox.Show("Bu Tc Kimlik Nosunu zaten eklediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string ekle = "insert into Table_User(tc, name, surname, authority, phone, mail, password) " +
                    "values(@tc, @name, @surname, @authority, @phone, @mail, @password)";

                    SqlCommand yap = new SqlCommand();

                    yap.Parameters.AddWithValue("@tc", maskedTextBoxTc.Text);
                    yap.Parameters.AddWithValue("@name", textBoxName.Text);
                    yap.Parameters.AddWithValue("@surname", textBoxSurname.Text);
                    yap.Parameters.AddWithValue("@authority", comboBoxAuthority.Text);
                    yap.Parameters.AddWithValue("@phone", maskedTextBoxPhone.Text);
                    yap.Parameters.AddWithValue("@mail", textBoxMail.Text);
                    yap.Parameters.AddWithValue("@password", textBoxPassword.Text);

                    user.addDeleteEdit(yap, ekle);

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
            if (maskedTextBoxTc.Text == "" || textBoxName.Text == "" || textBoxSurname.Text == "" || comboBoxAuthority.Text == "" || maskedTextBoxPhone.Text == "" || textBoxMail.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Tüm bilgileri eksiksiz doldurunuz.", "Eksik veri girişi",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ekle = "update Table_User set name=@name, surname=@surname, authority=@authority, phone=@phone, mail=@mail, password=@password where tc=@tc";

                SqlCommand yap = new SqlCommand();

                yap.Parameters.AddWithValue("@tc", maskedTextBoxTc.Text);
                yap.Parameters.AddWithValue("@name", textBoxName.Text);
                yap.Parameters.AddWithValue("@surname", textBoxSurname.Text);
                yap.Parameters.AddWithValue("@authority", comboBoxAuthority.Text);
                yap.Parameters.AddWithValue("@phone", maskedTextBoxPhone.Text);
                yap.Parameters.AddWithValue("@mail", textBoxMail.Text);
                yap.Parameters.AddWithValue("@password", textBoxPassword.Text);

                user.addDeleteEdit(yap, ekle);

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
            if (dataGridViewUser.CurrentRow != null)
            {
                DataGridViewRow satir = dataGridViewUser.CurrentRow;
                SqlCommand yap = new SqlCommand();
                string ekle = "delete from Table_User where tc='" + satir.Cells[0].Value.ToString() + "'";
                user.addDeleteEdit(yap, ekle);
                Yenile();
            }
            else
            {
                MessageBox.Show("Silinecek bilgi yok.", "Silme başarısız.",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewUser_DoubleClick(object sender, EventArgs e)
        {

            DataGridViewRow satir = dataGridViewUser.CurrentRow;
            maskedTextBoxTc.Text = satir.Cells[0].Value.ToString();
            textBoxName.Text = satir.Cells[1].Value.ToString();
            textBoxSurname.Text = satir.Cells[2].Value.ToString();
            comboBoxAuthority.Text = satir.Cells[3].Value.ToString();
            maskedTextBoxPhone.Text = satir.Cells[4].Value.ToString();
            textBoxMail.Text = satir.Cells[5].Value.ToString();
            textBoxPassword.Text = satir.Cells[6].Value.ToString();
        }
        private void maskedTextBoxTc_Click(object sender, EventArgs e)
        {
            maskedTextBoxTc.Select(0, 0);
        }
        private void maskedTextBoxPhone_Click(object sender, EventArgs e)
        {
            maskedTextBoxPhone.Select(0, 0);
        }
    }
}
