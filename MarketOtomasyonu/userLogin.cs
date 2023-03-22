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
    public partial class userLogin : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-N1JINFUV;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
        public static string authority;
        bool drmcontrol = false;
        public userLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT *FROM Table_User", baglanti);
            SqlDataReader oku = sorgu.ExecuteReader();

            while (oku.Read() == true)
            {
                if (oku["tc"].ToString() == maskedTextBoxTc.Text && oku["password"].ToString() == textBoxPassword.Text && oku["authority"].ToString() == "Müdür")
                {
                    drmcontrol = true;
                    authority = oku.GetValue(4).ToString();
                    AdminPanel ekle = new AdminPanel();
                    ekle.ShowDialog();
                    this.Hide();
                    break;
                }
                if (oku["tc"].ToString() == maskedTextBoxTc.Text && oku["password"].ToString() == textBoxPassword.Text && oku["authority"].ToString() == "Kasa Görevlisi")
                {
                    drmcontrol = true;
                    authority = oku.GetValue(4).ToString();
                    CashierPanel ekle = new CashierPanel();
                    ekle.ShowDialog();
                    this.Hide();
                    break;
                }
                if (oku["tc"].ToString() == maskedTextBoxTc.Text && oku["password"].ToString() == textBoxPassword.Text && oku["authority"].ToString() == "Tedarik Görevlisi")
                {
                    drmcontrol = true;
                    authority = oku.GetValue(4).ToString();
                    ProcurementOfficerPanel ekle = new ProcurementOfficerPanel();
                    ekle.ShowDialog();
                    this.Hide();
                    break;
                }
                if (oku["tc"].ToString() == maskedTextBoxTc.Text && oku["password"].ToString() == textBoxPassword.Text && oku["authority"].ToString() == "Ürün Görevlisi")
                {
                    drmcontrol = true;
                    authority = oku.GetValue(4).ToString();
                    ProductOfficerPanel ekle = new ProductOfficerPanel();
                    ekle.ShowDialog();
                    this.Hide();
                    break;
                }
            }
            if (maskedTextBoxTc.Text == "" || textBoxPassword.Text == "")
            { MessageBox.Show("Tc ve Şifre Alanları Boş Bırakılamaz!"); }

            else if (drmcontrol == false)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }
            baglanti.Close();
        }
        private void labelForgetPass_Click(object sender, EventArgs e)
        {
            var c = new forgetPassword
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            c.StartPosition = FormStartPosition.CenterParent;
            c.ShowDialog(this);
        }
        private void maskedTextBoxTc_Click(object sender, EventArgs e)
        {
            maskedTextBoxTc.Select(0, 0);
        }

        private void checkBoxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (checkBoxShowPas.Checked)
            {
                //karakteri göster.
                textBoxPassword.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }
        private void userLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketOtomasyonuDataSetUser.Table_User' table. You can move, or remove it, as needed.
            this.table_UserTableAdapter.Fill(this.marketOtomasyonuDataSetUser.Table_User);
            textBoxPassword.PasswordChar = '*';
            Controls_Tooltip("Giriş Yapmak İçin Tıkla", buttonLogin);

        }
        ToolTip Controls_Tooltip(string aciklama, Control cntrl)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Active = true; // Görünsün mü?
            toolTip.UseFading = true; // Silinerek kaybolma ve yavaşça görünme
            toolTip.UseAnimation = true; // Animasyonlu açılış
            toolTip.IsBalloon = true; // Baloncuk şekli mi dikdörtgen mi?
            toolTip.ShowAlways = true; // her zaman göster
            toolTip.AutoPopDelay = 3000; // Mesajın açık kalma süresi
            toolTip.ReshowDelay = 3000; // Mause çekildikten kaç ms sonra kaybolsun
            toolTip.InitialDelay = 1000; // Mesajın açılma süresi
            toolTip.BackColor = Color.Red; // arka plan rengi
            toolTip.ForeColor = Color.White; // yazı rengi
            toolTip.SetToolTip(cntrl, aciklama); // Hangi kontrolde görünsün
            return toolTip;
        }
    }
}
