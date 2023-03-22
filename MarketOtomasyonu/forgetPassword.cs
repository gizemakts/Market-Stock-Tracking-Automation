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
    public partial class forgetPassword : Form
    {
        public forgetPassword()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-N1JINFUV;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
        private void buttonShowPass_Click(object sender, EventArgs e)
        {
            bool hata = false;
            if (maskedTextBoxTc.Text == string.Empty)
                hata = true;
            if (maskedTextBoxPhone.Text == string.Empty)
                hata = true;
            if (hata == true)
            {
                MessageBox.Show("Boş Alanları Lütfen Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                SqlCommand kmt2 = new SqlCommand("select password from Table_User where tc='" + maskedTextBoxTc.Text + "' and phone='" + maskedTextBoxPhone.Text + "'", baglanti);
                SqlDataReader dr2 = kmt2.ExecuteReader();

                if (dr2.Read())
                {
                    string islem = dr2["password"].ToString();
                    MessageBox.Show(islem, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                    maskedTextBoxTc.Clear();
                    maskedTextBoxPhone.Clear();
                }
                else
                {
                    MessageBox.Show("Hatalı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    baglanti.Close();
                }
            }
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
