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
    public partial class CashierPanel : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-N1JINFUV;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
        SqlConnection baglanti2 = new SqlConnection("Data Source=LAPTOP-N1JINFUV;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
        SqlConnection baglanti3 = new SqlConnection("Data Source=LAPTOP-N1JINFUV;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
        SqlConnection baglanti4 = new SqlConnection("Data Source=LAPTOP-N1JINFUV;Initial Catalog=MarketOtomasyonu;Integrated Security=True");



        DatabaseConnect selling = new DatabaseConnect();
        public CashierPanel()
        {
            InitializeComponent();
        }
        private void CashierPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketOtomasyonuDataSetProductOfficer.Table_ProductOfficer' table. You can move, or remove it, as needed.
            this.table_ProductOfficerTableAdapter.Fill(this.marketOtomasyonuDataSetProductOfficer.Table_ProductOfficer);
            // TODO: This line of code loads data into the 'marketOtomasyonuDataSetCashier.Table_Cashier' table. You can move, or remove it, as needed.
            this.table_CashierTableAdapter.Fill(this.marketOtomasyonuDataSetCashier.Table_Cashier);
            Yenile();
        }
        private void CashierPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataGridViewRow satir = dataGridViewCashier.CurrentRow;
            SqlCommand yap = new SqlCommand();

            string ekle = "delete from Table_Cashier";
            selling.addDeleteEdit(yap, ekle);

            maskedTextBoxBarcode.Text = ""; // maskedTextBoxBarcode temizler
            textBoxSellingPiece.Text = ""; // textBoxSellingPiece temizler
            textBoxAmountTaken.Text = ""; // textBoxSellingPiece temizler
            textBoxProductPiece.Text = "";
            labelGrandTotal.Text = "00,00";
            labelTotal.Text = "00,00";
            labelExpirationdate.Text = "00.00.0000";
            toplam = 0;
            total = 0;
            groupBoxAmountTaken.Visible = false;
            buttonConfirm.Visible = false;
            Yenile();
        }
        private void Yenile()
        {
            //tabloya data çekme
            string ekle = "select *from Table_Cashier";
            SqlDataAdapter listeleyici = new SqlDataAdapter();
            dataGridViewCashier.DataSource = selling.listele(listeleyici, ekle);

            //tablonun yazı ayarları
            dataGridViewCashier.Columns[0].HeaderText = "Barkod No";
            dataGridViewCashier.Columns[1].HeaderText = "Adet";
        }
        public int sayac = 0;
        public double x = 0, y = 0, total = 0, toplam = 0, toplam1 = 0;
        public string sellpriece;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            sayac++;


            baglanti.Open();
            baglanti2.Open();
            if (maskedTextBoxBarcode.Text == "" || textBoxSellingPiece.Text == "")
            {
                MessageBox.Show("Tüm bilgileri eksiksiz doldurunuz.", "Eksik veri girişi",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komut = new SqlCommand("select * from Table_Cashier where productSellingBarcode like'%" + maskedTextBoxBarcode.Text + "%'", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    MessageBox.Show("Bu ürünü zaten eklediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string ekle = "insert into Table_Cashier (productSellingBarcode, sellingPiece) " +
                        "values(@productSellingBarcode, @sellingPiece )";

                    SqlCommand yap = new SqlCommand();

                    yap.Parameters.AddWithValue("@productSellingBarcode", maskedTextBoxBarcode.Text);
                    yap.Parameters.AddWithValue("@sellingPiece", textBoxSellingPiece.Text);
                    selling.addDeleteEdit(yap, ekle);
                    // her ürün eklediğinde girilen adet fiyatını bul 
                    baglanti3.Open();
                    SqlCommand sorgu3 = new SqlCommand("SELECT *FROM Table_ProductOfficer", baglanti3);
                    SqlDataReader oku3 = sorgu3.ExecuteReader();
                    while (oku3.Read() == true)
                    {
                        if (oku3["productBarcode"].ToString() == maskedTextBoxBarcode.Text)
                        {

                            sellpriece = oku3.GetValue(6).ToString();

                            x = Convert.ToDouble(textBoxSellingPiece.Text);
                            y = Convert.ToDouble(sellpriece);
                            total = y * x;
                            /// toplam fiyatını bul
                            toplam += total;
                            labelGrandTotal.Text = String.Format("{0:0.00}", Math.Round(toplam, 2).ToString());
                            labelTotal.Text = String.Format("{0:0.00}", Math.Round(total, 2).ToString());
                            break;
                        }
                    }
                    baglanti3.Close();
                    // her ürün eklediğinde son kullanma tarihini  bul 
                    baglanti4.Open();
                    SqlCommand sorgu4 = new SqlCommand("SELECT *FROM Table_ProductOfficer", baglanti4);
                    SqlDataReader oku4 = sorgu4.ExecuteReader();
                    while (oku4.Read() == true)
                    {
                        if (oku4["productBarcode"].ToString() == maskedTextBoxBarcode.Text)
                        {
                            string expirationdate;
                            expirationdate = oku4.GetValue(4).ToString();

                            labelExpirationdate.Text = expirationdate;
                            break;
                        }
                    }
                    baglanti4.Close();
                    // ürünü eklediğinde stoktan düş 
                    SqlCommand sorgu = new SqlCommand("SELECT *FROM Table_ProductOfficer", baglanti2);
                    SqlDataReader oku1 = sorgu.ExecuteReader();
                    while (oku1.Read() == true)
                    {
                        if (oku1["productBarcode"].ToString() == maskedTextBoxBarcode.Text)
                        {
                            string piece;
                            piece = oku1.GetValue(7).ToString();
                            int x, y;
                            x = Convert.ToInt32(textBoxSellingPiece.Text);
                            y = Convert.ToInt32(piece);
                            y = y - x;
                            piece = y.ToString();

                            textBoxProductPiece.Text = piece;

                            DatabaseConnect product = new DatabaseConnect();

                            string ekle1 = "update Table_ProductOfficer set productPiece=@productPiece WHERE productBarcode=@productBarcode";

                            SqlCommand yap1 = new SqlCommand();

                            yap1.Parameters.AddWithValue("@productBarcode", maskedTextBoxBarcode.Text);
                            yap1.Parameters.AddWithValue("@productPiece", textBoxProductPiece.Text);
                            product.addDeleteEdit(yap1, ekle1);
                        }
                    }

                    maskedTextBoxBarcode.Text = ""; // maskedTextBoxBarcode temizler
                    textBoxSellingPiece.Text = ""; // textBoxSellingPiece temizler

                    groupBoxAmountTaken.Visible = true;
                    buttonConfirm.Visible = true;
                    Yenile();


                }
            }
            baglanti.Close();
            baglanti2.Close();
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {

            if (maskedTextBoxBarcode.Text == "" || textBoxSellingPiece.Text == "")
            {
                MessageBox.Show("Tüm bilgileri eksiksiz doldurunuz.", "Eksik veri girişi",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("SELECT *FROM Table_Cashier", baglanti);
                SqlDataReader oku = sorgu.ExecuteReader();
                while (oku.Read() == true)
                {
                    if (oku["productSellingBarcode"].ToString() == maskedTextBoxBarcode.Text)
                    {
                        string piece;
                        piece = oku.GetValue(1).ToString();
                        int x, y;
                        y = Convert.ToInt32(textBoxProductPiece.Text); //stok 
                        x = Convert.ToInt32(piece); //girilmiş   
                        y = y + x;
                        piece = y.ToString();
                        textBoxProductPiece.Text = piece;
                        // total
                        baglanti4.Open();
                        SqlCommand sorgu4 = new SqlCommand("SELECT *FROM Table_ProductOfficer", baglanti4);
                        SqlDataReader oku4 = sorgu4.ExecuteReader();
                        while (oku4.Read() == true)
                        {
                            if (oku4["productBarcode"].ToString() == maskedTextBoxBarcode.Text)
                            {
                                double n, m;
                                n = x;
                                m = Convert.ToDouble(sellpriece);
                                total = n * m;
                                /// toplam fiyatını bul
                                toplam -= total;
                                labelTotal.Text = String.Format("{0:0.00}", Math.Round(total, 2).ToString());
                                labelGrandTotal.Text = String.Format("{0:0.00}", Math.Round(toplam, 2).ToString());

                                ///////////////////////////////////////////////////// yeni girilen güncelle
                                string ekle = "update Table_Cashier set sellingPiece=@sellingPiece WHERE productSellingBarcode=@productSellingBarcode";

                                SqlCommand yap = new SqlCommand();

                                yap.Parameters.AddWithValue("@productSellingBarcode", maskedTextBoxBarcode.Text);
                                yap.Parameters.AddWithValue("@sellingPiece", textBoxSellingPiece.Text);

                                selling.addDeleteEdit(yap, ekle);
                                Yenile();

                                ////////////////////////////////////////// yeni girilen stok ekle 
                                int x1, y1;
                                y1 = Convert.ToInt32(textBoxProductPiece.Text); //stok
                                x1 = Convert.ToInt32(textBoxSellingPiece.Text); //girilmiş
                                y1 = y1 - x1;
                                textBoxProductPiece.Text = y1.ToString();

                                // yeni girilen total toplam
                                double k;
                                k = x1;
                                total = k * m;
                                /// toplam fiyatını bul
                                toplam += total;
                                labelTotal.Text = String.Format("{0:0.00}", Math.Round(total, 2).ToString());
                                labelGrandTotal.Text = String.Format("{0:0.00}", Math.Round(toplam, 2).ToString());
                            }
                        }
                        baglanti4.Close();

                        //// stoğu kaydet
                        string ekle1 = "update Table_ProductOfficer set productPiece=@productPiece WHERE productBarcode=@productBarcode";
                        SqlCommand yap1 = new SqlCommand();
                        yap1.Parameters.AddWithValue("@productBarcode", maskedTextBoxBarcode.Text);
                        yap1.Parameters.AddWithValue("@productPiece", textBoxProductPiece.Text);
                        selling.addDeleteEdit(yap1, ekle1);
                        Yenile();
                    }
                }
                baglanti.Close();
                maskedTextBoxBarcode.Text = ""; // maskedTextBoxBarcode temizler
                textBoxSellingPiece.Text = ""; // textBoxSellingPiece temizler
                labelGrandTotal.Text = String.Format("{0:0.00}", Math.Round(toplam, 2).ToString());
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            sayac--;
            if (dataGridViewCashier.CurrentRow != null)
            {
                DataGridViewRow satir = dataGridViewCashier.CurrentRow;
                SqlCommand yap = new SqlCommand();

                string ekle = "delete from Table_Cashier where productSellingBarcode='" + satir.Cells[0].Value.ToString() + "'";
                selling.addDeleteEdit(yap, ekle);

                // her ürün eklediğinde girilen adet fiyatını bul 
                baglanti3.Open();
                SqlCommand sorgu3 = new SqlCommand("SELECT *FROM Table_ProductOfficer", baglanti3);
                SqlDataReader oku3 = sorgu3.ExecuteReader();
                while (oku3.Read() == true)
                {
                    if (oku3["productBarcode"].ToString() == maskedTextBoxBarcode.Text)
                    {
                        string sellpriece;
                        sellpriece = oku3.GetValue(6).ToString();
                        double x, y, total;
                        x = Convert.ToDouble(textBoxSellingPiece.Text);
                        y = Convert.ToDouble(sellpriece);
                        total = y * x;
                        /// toplam fiyatını bul
                        toplam += total;
                        labelGrandTotal.Text = String.Format("{0:0.00}", Math.Round(toplam, 2).ToString());
                        labelTotal.Text = String.Format("{0:0.00}", Math.Round(total, 2).ToString());
                        break;
                    }
                }
                baglanti3.Close();
                //stok işlemleri
                SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-N1JINFUV;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("SELECT *FROM Table_ProductOfficer", baglanti);
                SqlDataReader oku = sorgu.ExecuteReader();
                while (oku.Read() == true)
                {
                    if (oku["productBarcode"].ToString() == maskedTextBoxBarcode.Text)
                    {
                        string piece;
                        piece = oku.GetValue(7).ToString();
                        int x, y;
                        x = Convert.ToInt32(textBoxSellingPiece.Text);
                        y = Convert.ToInt32(piece);
                        y = y + x;
                        piece = y.ToString();

                        textBoxProductPiece.Text = piece;

                        DatabaseConnect product = new DatabaseConnect();

                        string ekle1 = "update Table_ProductOfficer set productPiece=@productPiece WHERE productBarcode=@productBarcode";

                        SqlCommand yap1 = new SqlCommand();

                        yap1.Parameters.AddWithValue("@productBarcode", maskedTextBoxBarcode.Text);
                        yap1.Parameters.AddWithValue("@productPiece", textBoxProductPiece.Text);
                        product.addDeleteEdit(yap1, ekle1);
                    }
                }
                baglanti.Close();
                maskedTextBoxBarcode.Text = ""; // maskedTextBoxBarcode temizler
                textBoxSellingPiece.Text = ""; // textBoxSellingPiece temizler
                labelTotal.Text = "00,00";
                labelGrandTotal.Text = "00,00";

                Yenile();
            }
            else
            {
                MessageBox.Show("Henüz Ürün Eklemediniz", "Silme başarısız.",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewCashier_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridViewCashier.CurrentRow;
            maskedTextBoxBarcode.Text = satir.Cells[0].Value.ToString();
            textBoxSellingPiece.Text = satir.Cells[1].Value.ToString();

            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-N1JINFUV;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("SELECT *FROM Table_ProductOfficer", baglanti);
            SqlDataReader oku = sorgu.ExecuteReader();
            while (oku.Read() == true)
            {
                if (oku["productBarcode"].ToString() == maskedTextBoxBarcode.Text)
                {
                    string piece;
                    piece = oku.GetValue(7).ToString();
                    textBoxProductPiece.Text = piece;

                }
            }
            baglanti.Close();
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            sayac = 0;
            if (textBoxAmountTaken.Text == "")
            {
                MessageBox.Show("Lütfen Alınan Para Miktarını Giriniz", "Eksik veri girişi",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double change, v, c;
                c = Convert.ToDouble(labelGrandTotal.Text);
                v = Convert.ToDouble(textBoxAmountTaken.Text);
                change = v - c;
                labelChange.Text = String.Format("{0:0.00}", Math.Round(change, 2).ToString());
                if (dataGridViewCashier.CurrentRow != null)
                {
                    DataGridViewRow satir = dataGridViewCashier.CurrentRow;
                    SqlCommand yap = new SqlCommand();

                    string ekle = "delete from Table_Cashier";
                    selling.addDeleteEdit(yap, ekle);

                    maskedTextBoxBarcode.Text = ""; // maskedTextBoxBarcode temizler
                    textBoxSellingPiece.Text = ""; // textBoxSellingPiece temizler
                    textBoxAmountTaken.Text = ""; // textBoxSellingPiece temizler
                    textBoxProductPiece.Text = "";
                    labelGrandTotal.Text = "00,00";
                    labelTotal.Text = "00,00";
                    labelExpirationdate.Text = "00.00.0000";
                    toplam = 0;
                    total = 0;
                    groupBoxAmountTaken.Visible = false;
                    buttonConfirm.Visible = false;
                    Yenile();
                }
                else
                {
                    MessageBox.Show("Lütfen Ürün Eklemeyin!", "Hata",
           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void maskedTextBoxBarcode_Click(object sender, EventArgs e)
        {
            maskedTextBoxBarcode.Select(0, 0);
        }

        private void buttonSellingCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= sayac; i++)
            {
                if (dataGridViewCashier.CurrentRow != null)
                {
                    DataGridViewRow satir = dataGridViewCashier.CurrentRow;
                    SqlCommand yap = new SqlCommand();

                    string ekle = "delete from Table_Cashier where productSellingBarcode='" + satir.Cells[0].Value.ToString() + "'";
                    selling.addDeleteEdit(yap, ekle);


                    SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-N1JINFUV;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
                    baglanti.Open();
                    SqlCommand sorgu = new SqlCommand("SELECT *FROM Table_ProductOfficer", baglanti);
                    SqlDataReader oku = sorgu.ExecuteReader();
                    while (oku.Read() == true)
                    {
                        if (oku["productBarcode"].ToString() == maskedTextBoxBarcode.Text)
                        {
                            string piece;
                            piece = oku.GetValue(7).ToString();
                            int x, y;
                            x = Convert.ToInt32(textBoxSellingPiece.Text);
                            y = Convert.ToInt32(piece);
                            y = y + x;
                            piece = y.ToString();

                            textBoxProductPiece.Text = piece;

                            DatabaseConnect product = new DatabaseConnect();

                            string ekle1 = "update Table_ProductOfficer set productPiece=@productPiece WHERE productBarcode=@productBarcode";

                            SqlCommand yap1 = new SqlCommand();

                            yap1.Parameters.AddWithValue("@productBarcode", maskedTextBoxBarcode.Text);
                            yap1.Parameters.AddWithValue("@productPiece", textBoxProductPiece.Text);
                            product.addDeleteEdit(yap1, ekle1);
                        }
                    }
                    baglanti.Close();

                    Yenile();
                }
                else
                {
                    MessageBox.Show("Henüz Ürün Eklemediniz", "Silme başarısız.",
           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
