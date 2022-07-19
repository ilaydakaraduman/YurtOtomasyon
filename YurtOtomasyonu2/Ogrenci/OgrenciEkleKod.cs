using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtOtomasyonu2.Ogrenci
{
    public class OgrenciEkleKod : IOgernciKod
    {
        SqlConnection _connection = new SqlConnection(@"Data Source =(localdb)\MSSQLLocalDB; initial catalog=YurtOtomasyonu;integrated security=true");
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public void Cikar(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Ogrenci where OgrenciId=@OgrenciId", _connection);

            command.Parameters.AddWithValue("@OgrenciId", id);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Ekle(Ogrenci ogrenci)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Ogrenci values(@Ad,@Soyad,@Tc,@Adres,@Okul,@OdaNo,@TaksitVarMı,@ToplamTaksitMiktari,@VeliAd,@VeliSoyad,@ParaOdendiMi,@TaksitSayisi,@OdaId)", _connection);
            command.Parameters.AddWithValue("@Ad", ogrenci.Ad);
            command.Parameters.AddWithValue("@Soyad", ogrenci.Soyad);
            command.Parameters.AddWithValue("@Tc", ogrenci.Tc);
            command.Parameters.AddWithValue("@OdaId", ogrenci.OdaId);
            command.Parameters.AddWithValue("@Adres", ogrenci.Adres);
            command.Parameters.AddWithValue("@Okul", ogrenci.Okul);
            command.Parameters.AddWithValue("@OdaNo", ogrenci.OdaNo);
            command.Parameters.AddWithValue("@TaksitVarMı", ogrenci.TaksitVarMı);
            command.Parameters.AddWithValue("@ToplamTaksitMiktari", ogrenci.ToplamTaksitMiktari);
            command.Parameters.AddWithValue("@VeliAd", ogrenci.VeliAd);
            command.Parameters.AddWithValue("@VeliSoyad", ogrenci.VeliSoyad);
            command.Parameters.AddWithValue("@ParaOdendiMi", ogrenci.ParaOdendiMi);
            command.Parameters.AddWithValue("@TaksitSayisi", ogrenci.TaksitSayisi);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Guncelle(Ogrenci ogrenci)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Ogrenci set Ad=@Ad, Soyad=@Soyad, Tc=@Tc, Adres=@Adres, Okul=@Okul ,OdaNo=@OdaNo ,TaksitVarMı=@TaksitVarMı ,ToplamTaksitMiktari=@ToplamTaksitMiktari ,VeliAd=@VeliAd,VeliSoyad=@VeliSoyad,ParaOdendiMi=@ParaOdendiMi,TaksitSayisi=@TaksitSayisi,OdaId=@OdaId where OgrenciId=@OgrenciId", _connection);
            command.Parameters.AddWithValue("@OgrenciId", ogrenci.OgrenciId);
            command.Parameters.AddWithValue("@Ad", ogrenci.Ad);
            command.Parameters.AddWithValue("@Soyad", ogrenci.Soyad);
            command.Parameters.AddWithValue("@Tc", ogrenci.Tc);
            command.Parameters.AddWithValue("@Adres", ogrenci.Adres);
            command.Parameters.AddWithValue("@Okul", ogrenci.Okul);
            command.Parameters.AddWithValue("@OdaNo", ogrenci.OdaNo);
            command.Parameters.AddWithValue("@TaksitVarMı", ogrenci.TaksitVarMı);
            command.Parameters.AddWithValue("@ToplamTaksitMiktari", ogrenci.ToplamTaksitMiktari);
            command.Parameters.AddWithValue("@VeliAd", ogrenci.VeliAd);
            command.Parameters.AddWithValue("@VeliSoyad", ogrenci.VeliSoyad);
            command.Parameters.AddWithValue("@ParaOdendiMi", ogrenci.ParaOdendiMi);
            command.Parameters.AddWithValue("@TaksitSayisi", ogrenci.TaksitSayisi);
            command.Parameters.AddWithValue("@OdaId", ogrenci.TaksitSayisi);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public List<Ogrenci> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Ogrenci", _connection);

            SqlDataReader reader = command.ExecuteReader();
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            while (reader.Read())
            {
                Ogrenci ogrenci = new Ogrenci
                {
                    OgrenciId = Convert.ToInt32(reader["OgrenciId"]),
                    Ad = reader["Ad"].ToString(),
                    Soyad = reader["Soyad"].ToString(),
                    Tc = reader["Tc"].ToString(),
                    Adres = reader["Adres"].ToString(),
                    Okul = reader["Okul"].ToString(),
                    OdaNo = Convert.ToInt32(reader["OdaNo"]),
                    TaksitVarMı = Convert.ToBoolean(reader["TaksitVarMı"]),
                    ToplamTaksitMiktari = Convert.ToInt32(reader["ToplamTaksitMiktari"]),
                    VeliAd = reader["VeliAd"].ToString(),
                    VeliSoyad = reader["VeliSoyad"].ToString(),
                    ParaOdendiMi = Convert.ToBoolean(reader["ParaOdendiMi"]),
                    TaksitSayisi = Convert.ToInt32(reader["TaksitSayisi"]),
                    OdaId = Convert.ToInt32(reader["OdaId"]),


                };
                ogrenciler.Add(ogrenci);
            }
            reader.Close();
            _connection.Close();
            return ogrenciler;
        }

        public List<Ogrenci> OgrenciAra(string key)
        {

            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Ogrenci where Ad like '%" + key + "%'", _connection);

            SqlDataReader reader = command.ExecuteReader();
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            while (reader.Read())
            {
                Ogrenci ogrenci = new Ogrenci
                {
                    OgrenciId = Convert.ToInt32(reader["OgrenciId"]),
                    Ad = reader["Ad"].ToString(),
                    Soyad = reader["Soyad"].ToString(),
                    Tc = reader["Tc"].ToString(),
                    Adres = reader["Adres"].ToString(),
                    Okul = reader["Okul"].ToString(),
                    OdaNo = Convert.ToInt32(reader["OdaNo"]),
                    TaksitVarMı = Convert.ToBoolean(reader["TaksitVarMı"]),
                    ToplamTaksitMiktari = Convert.ToInt32(reader["ToplamTaksitMiktari"]),
                    VeliAd = reader["VeliAd"].ToString(),
                    VeliSoyad = reader["VeliSoyad"].ToString(),
                    ParaOdendiMi = Convert.ToBoolean(reader["ParaOdendiMi"]),
                    TaksitSayisi = Convert.ToInt32(reader["TaksitSayisi"]),
                    OdaId = Convert.ToInt32(reader["OdaId"]),
                };
                ogrenciler.Add(ogrenci);
            }
            reader.Close();
            _connection.Close();
            return ogrenciler;

        }
    }
}


