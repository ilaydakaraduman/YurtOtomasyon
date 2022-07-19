using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtOtomasyonu2
{
    public class MudurEkleKod : IMudurKod
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
            SqlCommand command = new SqlCommand("Delete from Mudur where PersonelId=@PersonelId", _connection);

            command.Parameters.AddWithValue("@PersonelId", id);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Ekle(Mudur mudur)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Mudur values(@PersonelAd,@PersonelSoyad,@Adres,@Tc,@Sifre,@Maas,@SgkNumara,@ikramiye,@Ozgecmis,@Diller,@MaasOdendiMi)", _connection);
            command.Parameters.AddWithValue("@PersonelAd", mudur.PersonelAd);
            command.Parameters.AddWithValue("@PersonelSoyad", mudur.PersonelSoyad);
            command.Parameters.AddWithValue("@Adres", mudur.Adres);
            command.Parameters.AddWithValue("@Ozgecmis", mudur.Ozgecmis);
            command.Parameters.AddWithValue("@Tc", mudur.Tc);
            command.Parameters.AddWithValue("@Sifre", mudur.Sifre);
            command.Parameters.AddWithValue("@Maas", mudur.Maas);
            command.Parameters.AddWithValue("@SgkNumara", mudur.SgkNumara);
            command.Parameters.AddWithValue("@Diller", mudur.Diller);
            command.Parameters.AddWithValue("@ikramiye", mudur.ikramiye);
            command.Parameters.AddWithValue("@MaasOdendiMi", mudur.MaasOdendiMi);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Guncelle(Mudur mudur)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Mudur set PersonelAd=@PersonelAd, PersonelSoyad=@PersonelSoyad, Adres=@Adres, Tc=@Tc,@Sifre=Sifre, Maas=@Maas ,SgkNumara=@SgkNumara, ikramiye=@ikramiye ,Ozgecmis=@Ozgecmis ,Diller=@Diller,MaasOdendiMi=@MaasOdendiMi  where PersonelId=@PersonelId", _connection);
            command.Parameters.AddWithValue("@PersonelId", mudur.PersonelId);
            command.Parameters.AddWithValue("@PersonelAd", mudur.PersonelAd);
            command.Parameters.AddWithValue("@PersonelSoyad", mudur.PersonelSoyad);
            command.Parameters.AddWithValue("@Adres", mudur.Adres);
            command.Parameters.AddWithValue("@Ozgecmis", mudur.Ozgecmis);
            command.Parameters.AddWithValue("@Tc", mudur.Tc);
            command.Parameters.AddWithValue("@Sifre", mudur.Sifre);
            command.Parameters.AddWithValue("@Maas", mudur.Maas);
            command.Parameters.AddWithValue("@SgkNumara", mudur.SgkNumara);
            command.Parameters.AddWithValue("@Diller", mudur.Diller);
            command.Parameters.AddWithValue("@ikramiye", mudur.ikramiye);
            command.Parameters.AddWithValue("@MaasOdendiMi", mudur.MaasOdendiMi);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public List<Mudur> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Mudur", _connection);

            SqlDataReader reader = command.ExecuteReader();
            List<Mudur> mudurler = new List<Mudur>();
            while (reader.Read())
            {
                Mudur mudur = new Mudur
                {
                    PersonelId = Convert.ToInt32(reader["PersonelId"]),
                    PersonelAd = reader["PersonelAd"].ToString(),
                    PersonelSoyad = reader["PersonelSoyad"].ToString(),
                    Adres = reader["Adres"].ToString(),
                    Ozgecmis = reader["Ozgecmis"].ToString(),
                    Tc = reader["Tc"].ToString(),
                    Sifre = reader["Sifre"].ToString(),
                    Maas = Convert.ToDouble(reader["Maas"]),
                    SgkNumara = reader["SgkNumara"].ToString(),
                    Diller = reader["Diller"].ToString(),
                    ikramiye = Convert.ToInt32(reader["ikramiye"]),
                    MaasOdendiMi=Convert.ToBoolean(reader["MaasOdendiMi"])

                };
                mudurler.Add(mudur);
            }
            reader.Close();
            _connection.Close();
            return mudurler;
        }
    }
}
