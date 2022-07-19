using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtOtomasyonu2
{
    public class MuhasebeciEkleKod:IMuhasebeciKod
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
            SqlCommand command = new SqlCommand("Delete from Muhasebe where PersonelId=@PersonelId", _connection);

            command.Parameters.AddWithValue("@PersonelId", id);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public void Ekle(Muhasebeci muhasebeci)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Muhasebe values(@PersonelAd,@PersonelSoyad,@Adres,@Tc,@Sifre,@Maas,@SgkNumara,@yıllıkizin,@Ozgecmis,@MaasOdendiMi)", _connection);
            command.Parameters.AddWithValue("@PersonelAd", muhasebeci.PersonelAd);
            command.Parameters.AddWithValue("@PersonelSoyad", muhasebeci.PersonelSoyad);
            command.Parameters.AddWithValue("@Adres", muhasebeci.Adres);
            command.Parameters.AddWithValue("@Ozgecmis", muhasebeci.Ozgecmis);
            command.Parameters.AddWithValue("@Tc", muhasebeci.Tc);
            command.Parameters.AddWithValue("@Sifre", muhasebeci.Sifre);
            command.Parameters.AddWithValue("@Maas", muhasebeci.Maas);
            command.Parameters.AddWithValue("@SgkNumara", muhasebeci.SgkNumara);
            command.Parameters.AddWithValue("@yıllıkizin", muhasebeci.yıllıkizin);
            command.Parameters.AddWithValue("@MaasOdendiMi", muhasebeci.MaasOdendiMi);

            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Guncelle(Muhasebeci muhasebeci)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Muhasebe set PersonelAd=@PersonelAd, PersonelSoyad=@PersonelSoyad, Adres=@Adres, Tc=@Tc ,Sifre=@Sifre , Maas=@Maas ,SgkNumara=@SgkNumara ,yıllıkizin=@yıllıkizin, Ozgecmis=@Ozgecmis,MaasOdendiMi=@MaasOdendiMi where PersonelId=@PersonelId", _connection);
            command.Parameters.AddWithValue("@PersonelId", muhasebeci.PersonelId);
            command.Parameters.AddWithValue("@PersonelAd", muhasebeci.PersonelAd);
            command.Parameters.AddWithValue("@PersonelSoyad", muhasebeci.PersonelSoyad);
            command.Parameters.AddWithValue("@Adres", muhasebeci.Adres);
            command.Parameters.AddWithValue("@Ozgecmis", muhasebeci.Ozgecmis);
            command.Parameters.AddWithValue("@Tc", muhasebeci.Tc);
            command.Parameters.AddWithValue("@Sifre", muhasebeci.Sifre);
            command.Parameters.AddWithValue("@Maas", muhasebeci.Maas);
            command.Parameters.AddWithValue("@SgkNumara", muhasebeci.SgkNumara);
            command.Parameters.AddWithValue("@yıllıkizin", muhasebeci.yıllıkizin);
            command.Parameters.AddWithValue("@MaasOdendiMi", muhasebeci.MaasOdendiMi);

            command.ExecuteNonQuery();

            _connection.Close();

        }

        public List<Muhasebeci> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Muhasebe", _connection);

            SqlDataReader reader = command.ExecuteReader();
            List<Muhasebeci> Muhasebeciler = new List<Muhasebeci>();
            while (reader.Read())
            {
                Muhasebeci muhasebeci = new Muhasebeci
                {
                    PersonelId = Convert.ToInt32(reader["PersonelId"]),
                    PersonelAd = reader["PersonelAd"].ToString(),
                    PersonelSoyad = reader["PersonelSoyad"].ToString(),
                    Adres = reader["Adres"].ToString(),
                    Tc = reader["Tc"].ToString(),
                    Sifre = reader["Sifre"].ToString(),
                    Maas = Convert.ToDouble(reader["Maas"]),
                    SgkNumara = reader["SgkNumara"].ToString(),
                    Ozgecmis = reader["Ozgecmis"].ToString(),
                    yıllıkizin = Convert.ToInt32(reader["yıllıkizin"]),
                   MaasOdendiMi = Convert.ToBoolean(reader["MaasOdendiMi"]),



                };
                Muhasebeciler.Add(muhasebeci);
            }
            reader.Close();
            _connection.Close();
            return Muhasebeciler;
        }
    }
}
