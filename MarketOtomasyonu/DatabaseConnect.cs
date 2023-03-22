using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu
{
    class DatabaseConnect
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-N1JINFUV;Initial Catalog=MarketOtomasyonu;Integrated Security=True");
        DataTable tablo;

        //database ekleme silme ve güncelleme işlemleri için
        public void addDeleteEdit(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        //listeleme işlemleri 
        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {

            baglanti.Open();
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
    }
}
