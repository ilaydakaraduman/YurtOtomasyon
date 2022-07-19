using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtOtomasyonu2
{
    public class GorevliEkleKod : IGorevliKod
    {
        //Gorevli gorevli = new Gorevli();
        SqlConnection _connection = new SqlConnection(@"Data Source =(localdb)\MSSQLLocalDB; initial catalog=YurtOtomasyonu;integrated security=true");

        public void Cikar(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from GorevliN where PersonelId=@PersonelId", _connection);

            command.Parameters.AddWithValue("@PersonelId", id);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Ekle(Gorevli görevli)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into GorevliN values(@PersonelAd,@PersonelSoyad,@Adres,@Tc,@Sifre,@Maas,@SgkNumara,@saatlikMesaiUcreti,@izinGun,@KadroluMu,@MaasOdendiMi,@MesaiSaati)", _connection);
            command.Parameters.AddWithValue("@PersonelAd", görevli.PersonelAd);
            command.Parameters.AddWithValue("@PersonelSoyad", görevli.PersonelSoyad);
            command.Parameters.AddWithValue("@Adres", görevli.Adres);
            command.Parameters.AddWithValue("@Tc", görevli.Tc);
            command.Parameters.AddWithValue("@Sifre", görevli.Sifre);
            command.Parameters.AddWithValue("@Maas", görevli.Maas);
            command.Parameters.AddWithValue("@SgkNumara", görevli.SgkNumara);
            command.Parameters.AddWithValue("@izinGun", görevli.izinGun);
            command.Parameters.AddWithValue("@KadroluMu", görevli.KadroluMu);
            command.Parameters.AddWithValue("@saatlikMesaiUcreti", görevli.saatlikMesaiUcreti);
            command.Parameters.AddWithValue("@MaasOdendiMi", görevli.MaasOdendiMi);
            command.Parameters.AddWithValue("@MesaiSaati", görevli.MesaiSaati);
            command.ExecuteNonQuery();


            _connection.Close();
        }

        public List<Gorevli> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from GorevliN", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Gorevli> gorevliler = new List<Gorevli>();
            while (reader.Read())
            {
                Gorevli gorevli = new Gorevli
                {
                    PersonelId = Convert.ToInt32(reader["PersonelId"]),
                    PersonelAd = reader["PersonelAd"].ToString(),
                    PersonelSoyad = reader["PersonelSoyad"].ToString(),
                    Adres = reader["Adres"].ToString(),
                    Tc = reader["Tc"].ToString(),
                    Sifre = reader["Sifre"].ToString(),
                    Maas = Convert.ToDouble(reader["Maas"]),
                    SgkNumara = reader["SgkNumara"].ToString(),
                    izinGun = reader["izinGun"].ToString(),
                    KadroluMu = Convert.ToBoolean(reader["KadroluMu"]),
                    saatlikMesaiUcreti = Convert.ToDouble(reader["saatlikMesaiUcreti"]),
                    MaasOdendiMi=Convert.ToBoolean(reader["MaasOdendiMi"]),
                    MesaiSaati= Convert.ToInt32(reader["MesaiSaati"]),


                };
                gorevliler.Add(gorevli);
            }
            reader.Close();
            _connection.Close();
            return gorevliler;
        }

        public void Guncelle(Gorevli görevli)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update GorevliN set PersonelAd=@PersonelAd, PersonelSoyad=@PersonelSoyad, Adres=@Adres, Tc=@Tc ,Sifre=@Sifre, Maas=@Maas ,SgkNumara=@SgkNumara,saatlikMesaiUcreti=@saatlikMesaiUcreti,izinGun=@izinGun,KadroluMu=@KadroluMu,MaasOdendiMi=@MaasOdendiMi ,MesaiSaati=@MesaiSaati where PersonelId=@PersonelId", _connection);
            command.Parameters.AddWithValue("@PersonelId", görevli.PersonelId);
            command.Parameters.AddWithValue("@PersonelAd", görevli.PersonelAd);
            command.Parameters.AddWithValue("@PersonelSoyad", görevli.PersonelSoyad);
            command.Parameters.AddWithValue("@Adres", görevli.Adres);
            command.Parameters.AddWithValue("@Tc", görevli.Tc);
            command.Parameters.AddWithValue("@Sifre", görevli.Sifre);
            command.Parameters.AddWithValue("@Maas", görevli.Maas);
            command.Parameters.AddWithValue("@SgkNumara", görevli.SgkNumara);
            command.Parameters.AddWithValue("@izinGun", görevli.izinGun);
            command.Parameters.AddWithValue("@KadroluMu", görevli.KadroluMu);
            command.Parameters.AddWithValue("@saatlikMesaiUcreti", görevli.saatlikMesaiUcreti);
            command.Parameters.AddWithValue("@MaasOdendiMi", görevli.MaasOdendiMi);
            command.Parameters.AddWithValue("@MesaiSaati", görevli.MesaiSaati);

            command.ExecuteNonQuery();


            _connection.Close();
        }
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
    }
}
