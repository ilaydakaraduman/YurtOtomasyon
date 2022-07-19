using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YurtOtomasyonu2.Prosebuton;

namespace YurtOtomasyonu2.Odalar
{
    public partial class GorevliOdaForm : Form
    {
        OdaEkleKod odaEkleKod = new OdaEkleKod();
        List<Oda> odalar = new List<Oda>();
        public GorevliOdaForm()
        {
            InitializeComponent();
        }

        private void dgwOda_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GorevliOdaForm_Load(object sender, EventArgs e)
        {
            odalar = odaEkleKod.GetAll();
            foreach (var oda in odalar)
            {
                if(oda.TemizlendiMi)
                {
                    ListeTemiz.Items.Add(oda.OdaNo);
                }
                else
                {
                    liste.Items.Add(oda.OdaNo);
                }
            }
        }
        int secilen;
        private void btnListedenSil_Click(object sender, EventArgs e)
        {
            secilen = liste.SelectedIndex;
            liste.Items.RemoveAt(secilen);
        }

        private void btnOdaTemizle_Click(object sender, EventArgs e)
        {
            string temizlenecekOda= liste.SelectedItem.ToString();
            int secilenIndex = liste.SelectedIndex;
            foreach (var oda in odalar)
            {
                    
                    if (oda.OdaNo == Convert.ToInt32(temizlenecekOda))
                    {
                        odaEkleKod.Guncelle(new Oda
                        {
                            OdaId = oda.OdaId,
                            OdaNo = oda.OdaNo,
                            KalanIsim = oda.KalanIsim,
                            KisiSayisi = oda.KisiSayisi,
                            OdadakiKisiSayi = oda.OdadakiKisiSayi,
                            TemizlendiMi = true,


                        });
                    ListeTemiz.Items.Add(temizlenecekOda);
                    liste.Items.RemoveAt(secilenIndex);                    }


            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anagiris anagiris = new Anagiris();
            this.Hide();
            anagiris.ShowDialog();
           
        }
    }
}
