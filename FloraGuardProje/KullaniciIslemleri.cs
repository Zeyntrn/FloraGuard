using StokTakipSistemi;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloraGuardProje
{

    public class KullaniciIslemleri
    {
        private SqlConnection baglanti;

        public KullaniciIslemleri()
        {
            baglanti = SqlBaglanti.Instance.GetConnection();
        }


        public Kullanici GirisYap(string kullaniciAdi, string sifre)
        {
            using (var baglanti = SqlBaglanti.Instance.GetConnection())
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "SELECT * FROM Kullanicilar WHERE KullaniciAdi = @kadi AND Sifre = @sifre";
                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@kadi", kullaniciAdi);
                        komut.Parameters.AddWithValue("@sifre", sifre);

                        using (SqlDataReader reader = komut.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Kullanici
                                {
                                    KullaniciID = (int)reader["KullaniciID"],
                                    KullaniciAdi = reader["KullaniciAdi"].ToString(),
                                    Sifre = reader["Sifre"] != DBNull.Value ? reader["Sifre"].ToString() : null,
                                    Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : null,
                                    BildirimAktif = reader["BildirimAktif"] != DBNull.Value && Convert.ToBoolean(reader["BildirimAktif"]),
                                    EklenmeTarihi = reader["EklenmeTarihi"] != DBNull.Value ? Convert.ToDateTime(reader["EklenmeTarihi"]) : DateTime.MinValue,
                                    KullaniciTipi = reader["KullaniciTipi"] != DBNull.Value ? reader["KullaniciTipi"].ToString() : null
                                };
                            }
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Girişte hata oluştu: " + ex.Message, ex);
                }
            }
        }

        public bool KayitOl(Kullanici kullanici)
        {
            try
            {
                baglanti.Open();
                string query = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Email, BildirimAktif, EklenmeTarihi, KullaniciTipi) " +
                               "VALUES (@kadi, @sifre, @email, @bildirim, @ekleme, @tur)";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                cmd.Parameters.AddWithValue("@kadi", kullanici.KullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", kullanici.Sifre);
                cmd.Parameters.AddWithValue("@email", kullanici.Email);
                cmd.Parameters.AddWithValue("@bildirim", kullanici.BildirimAktif);
                cmd.Parameters.AddWithValue("@ekleme", kullanici.EklenmeTarihi);
                cmd.Parameters.AddWithValue("@tur", kullanici.KullaniciTipi);

                int sonuc = cmd.ExecuteNonQuery();
                return sonuc > 0;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool SifreGuncelle(string email, string yeniSifre)
        {
            try
            {
                baglanti.Open();
                string query = "UPDATE Kullanicilar SET Sifre = @sifre WHERE Email = @eposta";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                cmd.Parameters.AddWithValue("@sifre", yeniSifre);
                cmd.Parameters.AddWithValue("@eposta", email);

                int sonuc = cmd.ExecuteNonQuery();
                return sonuc > 0;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool KullaniciVarMi(string email)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Kullanicilar WHERE Email = @email", baglanti);
                cmd.Parameters.AddWithValue("@email", email);

                int sayi = (int)cmd.ExecuteScalar();
                return sayi > 0;
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
