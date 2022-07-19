using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YurtOtomasyonu2.Odalar;

namespace YurtOtomasyonu2.Ogrenci
{
    public partial class OdaBilgisi : Form
    {
        public int odano;
        OdaEkleKod odaEkleKod = new OdaEkleKod();
        List<Oda> odalar = new List<Oda>();
        public OdaBilgisi()
        {
            InitializeComponent();
        }

        private void OdaBilgisi_Load(object sender, EventArgs e)
        {
            odalar = odaEkleKod.GetAll();
            isimAl(odano);
        }
        public void isimAl(int Odano)
        {
            //Console.WriteLine("efegrgrdg" + odano);
            foreach (var item in odalar)
            {
                if (item.OdaNo == odano)
                {
                    lblTop.Text = (item.KisiSayisi).ToString();
                    lbleklenecek.Text = (item.KisiSayisi - item.OdadakiKisiSayi).ToString();
                    lblKalan.Text = item.OdadakiKisiSayi.ToString();
                    string phrase = item.KalanIsim;
                    string[] words = phrase.Split(',');

                    foreach (var word in words)
                    {
                        Kisiler.Items.Add(word)
;
                    }
                }

            }
        }
        private void Kisiler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
