using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtOtomasyonu2.Odalar
{
    public class OdaEkleKod : IOdaKod
    {
        SqlConnection _connection = new SqlConnection(@"Data Source =(localdb)\MSSQLLocalDB; initial catalog=YurtOtomasyonu;integrated security=true");
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<Oda> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Odalar", _connection);

            SqlDataReader reader = command.ExecuteReader();
            List<Oda> odalar = new List<Oda>();
            while (reader.Read())
            {
                Oda oda = new Oda
                {
                    OdaId = Convert.ToInt32(reader["OdaId"]),
                    OdaNo = Convert.ToInt32(reader["OdaNo"]),
                    KalanIsim = reader["KalanIsim"].ToString(),
                    KisiSayisi = Convert.ToInt32(reader["KisiSayisi"]),
                    OdadakiKisiSayi = Convert.ToInt32(reader["OdadakiKisiSayi"]),
                    TemizlendiMi = Convert.ToBoolean(reader["TemizlendiMi"]),


                };
                odalar.Add(oda);
            }
            reader.Close();
            _connection.Close();
            return odalar;
        }

        public void Guncelle(Oda oda)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Odalar set  OdaNo=@OdaNo, KisiSayisi=@KisiSayisi, KalanIsim=@KalanIsim ,OdadakiKisiSayi=@OdadakiKisiSayi,TemizlendiMi=@TemizlendiMi where OdaId=@OdaId", _connection);
            command.Parameters.AddWithValue("@OdaId", oda.OdaId);
            command.Parameters.AddWithValue("@OdaNo", oda.OdaNo);
            command.Parameters.AddWithValue("@KisiSayisi", oda.KisiSayisi);
            command.Parameters.AddWithValue("@KalanIsim", oda.KalanIsim);
            command.Parameters.AddWithValue("@OdadakiKisiSayi", oda.OdadakiKisiSayi);
            command.Parameters.AddWithValue("@TemizlendiMi", oda.TemizlendiMi);
            
            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
