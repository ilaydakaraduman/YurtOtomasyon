using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YurtOtomasyonu2.Odalar;
using YurtOtomasyonu2.Prosebuton;

namespace YurtOtomasyonu2.Ogrenci
{
    public partial class Ogrenci_Form : Form
    {
        public Ogrenci_Form()
        {
            InitializeComponent();
        }
        int ogrenciId;
        public int ODAno;
        OgrenciEkleKod ogrenciKod = new OgrenciEkleKod();
        OdaEkleKod odaEkleKod = new OdaEkleKod();
        List<Button> butonlar = new List<Button>();
        List<Oda> odalar = new List<Oda>();
        bool taksitVarMi = false;
        bool odendiMi = false;
        string ResimYer = "";
        string ResimDestination = "";
        string Path = "";
        string directory = AppDomain.CurrentDomain.BaseDirectory;
        public string dgwTc;
        bool ResimSecildiMi;

        public void OgrenciGoruntule()
        {
            dgwOgrenci.DataSource = ogrenciKod.GetAll();
        }

        private void Ogrenci_Form_Load(object sender, EventArgs e)
        {
            Path = directory + @"ResimOgrenci\";
            OgrenciGoruntule();
            butonlarıDoldur();
            odalar = odaEkleKod.GetAll();
            OdaKategoriDoldur();
            ProgressBarBaslangıc();

        }

        private void dgwOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ogrenciId = Convert.ToInt32(dgwOgrenci.CurrentRow.Cells[0].Value.ToString());
            tbxIsim.Text = dgwOgrenci.CurrentRow.Cells[1].Value.ToString();
            tbxSoyisim.Text = dgwOgrenci.CurrentRow.Cells[2].Value.ToString();
            tbxTc.Text = dgwOgrenci.CurrentRow.Cells[3].Value.ToString();
            tbxAdres.Text = dgwOgrenci.CurrentRow.Cells[4].Value.ToString();
            tbxOkul.Text = dgwOgrenci.CurrentRow.Cells[5].Value.ToString();
            int index = cmbOda.FindString(dgwOgrenci.CurrentRow.Cells[6].Value.ToString());;
            cmbOda.SelectedIndex = index;
            var.Checked = Convert.ToBoolean(dgwOgrenci.CurrentRow.Cells[8].Value);
            tbxToplamTaksit.Text = dgwOgrenci.CurrentRow.Cells[9].Value.ToString();
            tbxVeliAd.Text = dgwOgrenci.CurrentRow.Cells[10].Value.ToString();
            tbxVeliSoyad.Text = dgwOgrenci.CurrentRow.Cells[11].Value.ToString();
            checkOdendi.Checked = Convert.ToBoolean(dgwOgrenci.CurrentRow.Cells[12].Value);
            tbxtaksitSayi.Text = dgwOgrenci.CurrentRow.Cells[13].Value.ToString();
            pcbResim.ImageLocation = Path + dgwOgrenci.CurrentRow.Cells[3].Value.ToString() + ".jpg";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            odaReset();
            if (var.Checked)
            {
                taksitVarMi = true;
            }
            else
            {
                taksitVarMi = false;
            }
            if (checkOdendi.Checked)
            {
                odendiMi = true;
            }
            ogrenciKod.Ekle(new Ogrenci
            {
                Ad = tbxIsim.Text.Trim(),
                Soyad = tbxSoyisim.Text.Trim(),
                Adres = tbxAdres.Text.Trim(),
                Okul = tbxOkul.Text.Trim(),
                TaksitSayisi = Convert.ToInt32(tbxtaksitSayi.Text),
                TaksitVarMı = taksitVarMi,
                Tc = tbxTc.Text.Trim(),
                ToplamTaksitMiktari = Convert.ToInt32(tbxToplamTaksit.Text),
                VeliAd = tbxVeliAd.Text,
                VeliSoyad = tbxVeliSoyad.Text,
                ParaOdendiMi = odendiMi,
                OdaNo = Convert.ToInt32(cmbOda.Text),
                OdaId = Convert.ToInt32(cmbOda.Text),
            });
            ResimSec();
            foreach (var oda in odalar)
            {
                if (oda.OdaNo == Convert.ToInt32(cmbOda.SelectedValue))
                {
                    oda.OdadakiKisiSayi++;
                    oda.KalanIsim += tbxIsim.Text + ",";
                    odaEkleKod.Guncelle(new Oda
                    {
                        OdaId = oda.OdaId,
                        OdaNo = oda.OdaNo,
                        KalanIsim = oda.KalanIsim,
                        KisiSayisi = oda.KisiSayisi,
                        OdadakiKisiSayi = oda.OdadakiKisiSayi,
                    });
                } 
            }
            if (MessageBox.Show("Öğrencinin bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Öğrenci Sistemimize Başarıyla Eklenmiştir");
            }
            OgrenciGoruntule();
            odaKontrol();
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            odaReset();
            ogrenciId = Convert.ToInt32(dgwOgrenci.CurrentRow.Cells[0].Value);
            if (var.Checked)
            {
                taksitVarMi = true;
            }
            else
            {
                taksitVarMi = false;
            }
            if (checkOdendi.Checked)
            {
                odendiMi = true;
            }
            ogrenciKod.Guncelle(new Ogrenci
            {
                OgrenciId = ogrenciId,
                Ad = tbxIsim.Text.Trim(),
                Soyad = tbxSoyisim.Text,
                Adres = tbxAdres.Text,
                Okul = tbxOkul.Text,
                TaksitSayisi = Convert.ToInt32(tbxtaksitSayi.Text),
                TaksitVarMı = taksitVarMi,
                Tc = tbxTc.Text.Trim(),
                ToplamTaksitMiktari = Convert.ToInt32(tbxToplamTaksit.Text),
                VeliAd = tbxVeliAd.Text,
                VeliSoyad = tbxVeliSoyad.Text,
                ParaOdendiMi = odendiMi,

            });
            if (ResimSecildiMi)
            {
                File.Delete(Path + tbxTc.Text + ".jpg");
                ResimSec(tbxTc.Text);
            }
            if (MessageBox.Show("Öğrencinin bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Öğrenci Sistemimize Başarıyla Guncellenmiştir");
            }
            OgrenciGoruntule();
            odaKontrol();
        }


        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbxSearch.Text != "")
                {
                    dgwOgrenci.DataSource = ogrenciKod.OgrenciAra(tbxSearch.Text);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        string yeniOda;
        private void btnSil_Click(object sender, EventArgs e)
        {
            odaReset();
            if (MessageBox.Show("Öğrenciyi silmek istediğinize emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Öğrenci Sistemimize Başarıyla Silinmiştir");
            }
            foreach (var oda in odalar)
            {
                foreach (var ogrenci in ogrenciKod.GetAll())
                {
                    if (ogrenci.OgrenciId == ogrenciId)
                    {
                        if (ogrenci.OdaId == oda.OdaId)
                        {
                            oda.OdadakiKisiSayi--;
                            string odadakiIsimler = oda.KalanIsim;
                            string[] odadakiler = odadakiIsimler.Split(',');

                            foreach (var kisi in odadakiler)
                            {
                                if (kisi != ogrenci.Ad && kisi != "")
                                {
                                    yeniOda += kisi + ",";
                                }
                            }
                            oda.KalanIsim = yeniOda;
                            ogrenciKod.Cikar(ogrenciId);
                            odaEkleKod.Guncelle(new Oda
                            {
                                OdaId = oda.OdaId,
                                KisiSayisi = oda.KisiSayisi,
                                OdadakiKisiSayi = oda.OdadakiKisiSayi,
                                KalanIsim = oda.KalanIsim,
                                OdaNo = oda.OdaNo,
                            });
                        }
                    }
                }


            }
            odaKontrol();
            OgrenciGoruntule();
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                dialog.Filter = "Image Files(*.JPG;)|*.JPG;";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    ResimYer = dialog.FileName;
                    pcbResim.ImageLocation = ResimYer;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResimGuncel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.JPG;)|*.JPG;";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ResimSecildiMi = true;
                    ResimYer = dialog.FileName;
                    pcbResim.ImageLocation = ResimYer;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ResimSec(string resim)
        {
            ResimDestination = Path + resim + ".jpg";
            File.Copy(ResimYer, ResimDestination);

        }
        public void ResimSec()
        {
            string resim = tbxTc.Text;
            ResimDestination = Path + resim + ".jpg";
            File.Copy(ResimYer, ResimDestination);


        }
        int sayac = 1;
        public void butonlarıDoldur()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    Button btn = new Button();
                    btn.Text = sayac.ToString();
                    btn.Name = sayac.ToString();
                    btn.BackColor = Color.Green;
                    btn.Size = new Size(60, 60);
                    btn.Location = new Point(j * 100, 65 * i + 50);

                    butonlar.Add(btn);
                    sayac++;
                    this.splitContainer1.Panel2.Controls.Add(btn);
                    btn.Click += new EventHandler(b_Click);
                }
            }
        }
        private void b_Click(object sender, EventArgs e)
        {
            OdaBilgisi odaBilgisi = new OdaBilgisi();
            odaBilgisi.Dock = DockStyle.Fill;
            odaBilgisi.TopLevel = false;
            odaBilgisi.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(odaBilgisi);
            ODAno = Convert.ToInt32(((Button)sender).Text);
            odaBilgisi.odano = ODAno;
            odaBilgisi.Show();
        }

        public void odaKontrol()
        {
            foreach (var buton in butonlar)
            {
                foreach (var oda in odalar)
                {
                    if (buton.Name.ToString() == oda.OdaNo.ToString())
                    {
                        if (oda.KisiSayisi == oda.OdadakiKisiSayi)
                        {
                            buton.BackColor = Color.Red;


                        }
                    }
                }

            }
        }
        public void odaReset()
        {
            foreach (var buton in butonlar)
            {
                buton.BackColor = Color.Green;

            }
        }

        private void btnOdaGoruntule_Click(object sender, EventArgs e)
        {
            odaKontrol();
        }
        public void OdaKategoriDoldur()
        {
            cmbOda.DataSource = odaEkleKod.GetAll();
            cmbOda.DisplayMember = "OdaNo";
            cmbOda.ValueMember = "OdaId";
        }
        public void ProgressBarBaslangıc()
        {

        }
        private void tbxtaksitSayi_TextChanged(object sender, EventArgs e)
        {
            ProgressBarHesapla();
        }

        private void ProgressBarHesapla()
        {

            pbKalan.Maximum = Convert.ToInt32(tbxToplamTaksit.Text);
            pbKalan.Minimum = 0;
            if(tbxtaksitSayi.Text != "")
            {
                pbKalan.Value = Convert.ToInt32(tbxtaksitSayi.Text);

            }

            //sayac = Convert.ToInt32(tbxtaksitSayi.Text);
            //pbKalan.Value = pbKalan.Value + 1;

            //sayac++;


            lblKalanTaksit.Text = (pbKalan.Maximum - pbKalan.Value).ToString();
            //tbxtaksitSayi.Text = sayac.ToString(); 

            if (pbKalan.Value == pbKalan.Maximum) 

            {
                checkOdendi.Checked = true;
                MessageBox.Show("Taksidiniz Bitmiştir."); 

            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anagiris anagiris = new Anagiris();
            anagiris.ShowDialog();
            this.Hide();
        }
    }
}

