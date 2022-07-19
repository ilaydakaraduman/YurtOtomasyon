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
using System.Drawing.Drawing2D;
using YurtOtomasyonu2.Prosebuton;

namespace YurtOtomasyonu2
{
    public partial class PersonelEkle_Form : Form
    {
        public PersonelEkle_Form()
        {
            InitializeComponent();

        }
        int MudurId, MuhasebeId, GorevliId;
        string MudurResimYer = "";
        string MudurResimDestination = "";
        string GorevliResimYer = "";
        string GorevliResimDestination = "";
        string MuhasebeResimYer = "";
        string MuhasebeResimDestination = "";
        string PathMudur = "";
        string PathGorevli = "";
        string PathMuhasebe = "";
        string directory = AppDomain.CurrentDomain.BaseDirectory;
        public string MudurdgwTc, GorevlidgwTc, MuhasebedgwTc;
        bool MudurResimSecildiMi;
        bool GorevliResimSecildiMi;
        bool MuhasebeResimSecildiMi;
        GorevliEkleKod gorevliEkle = new GorevliEkleKod();
        MudurEkleKod mudurEkle = new MudurEkleKod();
        MuhasebeciEkleKod muhasebeciEkle = new MuhasebeciEkleKod();
        List<CheckBox> checkBoxes = new List<CheckBox>();
        string izinGunu = "";
        private void PersonelEkle_Form_Load(object sender, EventArgs e)
        {
            PathMudur = directory + @"ResimMudur\";
            PathGorevli = directory + @"ResimGorevli\";
            PathMuhasebe = directory + @"ResimMuhasebe\";
            Goruntule();
            CheckTopla();
           
        }
        void Goruntule()
        {
            dgwMudurGoruntule.DataSource = mudurEkle.GetAll();
            dgwGorevliEkle.DataSource = gorevliEkle.GetAll();
            dgwMuhasebeEkle.DataSource = muhasebeciEkle.GetAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool maasOdendiMi = false;
            if (checkMaasOdendi.Checked)
            {
                maasOdendiMi = true;
            }
            mudurEkle.Ekle(new Mudur
            {
                PersonelAd = tbxIsim.Text,
                PersonelSoyad = tbxSoyisim.Text,
                Adres = tbxAdres.Text,
                Ozgecmis = tbxOzgecmis.Text,
                Sifre = tbxSifre.Text,
                Diller = tbxDiller.Text,
                Maas = Convert.ToDouble(tbxMaas.Text),
                ikramiye = Convert.ToDouble(tbxIkramiye.Text),
                SgkNumara = tbxSgk.Text,
                Tc = tbxTc.Text,
                MaasOdendiMi = maasOdendiMi
            });
            MudurResimSec();
            if (MessageBox.Show("Müdürün bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Müdür Sistemimize Başarıyla Eklenmiştir");
            }
            Goruntule();


        }
      
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool maasOdendiMi = false;
            if (checkMaasOdendi.Checked)
            {
                maasOdendiMi = true;
            }
            mudurEkle.Guncelle(new Mudur
            {
                PersonelId = MudurId,
                PersonelAd = tbxIsim.Text,
                PersonelSoyad = tbxSoyisim.Text,
                Adres = tbxAdres.Text,
                Ozgecmis = tbxOzgecmis.Text,
                Sifre = tbxSifre.Text,
                Diller = tbxDiller.Text,
                Maas = Convert.ToDouble(tbxMaas.Text),
                ikramiye = Convert.ToDouble(tbxIkramiye.Text),
                SgkNumara = tbxSgk.Text,
                Tc = tbxTc.Text,
                MaasOdendiMi = maasOdendiMi

            });
            if (MudurResimSecildiMi)
            {
                File.Delete(PathMudur + tbxTc.Text + ".jpg");
                MudurResimSec(tbxTc.Text);
            }
            Goruntule();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            MudurId = Convert.ToInt32(dgwMudurGoruntule.CurrentRow.Cells[3].Value);
            mudurEkle.Cikar(MudurId);
            Goruntule();
        }


        private void btnGorEkle_Click(object sender, EventArgs e)
        {
            foreach (var item in checkBoxes)
            {
                if (item.Checked)
                {
                    izinGunu = item.Text;
                }
            }


            gorevliEkle.Ekle(new Gorevli
            {
                PersonelAd = tbxGorIsim.Text,
                PersonelSoyad = tbxGorSoyisim.Text,
                Adres = tbxGorAdres.Text,
                Sifre = tbxGorSifre.Text,
                Tc = tbxGorTc.Text,
                SgkNumara = tbxGorSgk.Text,
                Maas = Convert.ToDouble(tbxGorMaas.Text),
                saatlikMesaiUcreti = Convert.ToDouble(tbxGorSaat.Text),
                izinGun = izinGunu,
                KadroluMu = RadioKadrolu.Checked,
                MesaiSaati = Convert.ToInt32(tbxMesaiSaati.Text),
                MaasOdendiMi = checkGorMaasOdendi.Checked,
            });
            GorevliResimSec();
            if (MessageBox.Show("Gorevli bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Gorevli Sistemimize Başarıyla Eklenmiştir");
            }
            Goruntule();
        }

        private void btnGorGuncelle_Click(object sender, EventArgs e)
        {

            foreach (var item in checkBoxes)
            {

                if (item.Checked)
                {
                    izinGunu = item.Text;
                }

            }



            gorevliEkle.Guncelle(new Gorevli
            {
                PersonelId = GorevliId,
                PersonelAd = tbxGorIsim.Text,
                PersonelSoyad = tbxGorSoyisim.Text,
                Adres = tbxGorAdres.Text,
                Sifre = tbxGorSifre.Text,
                Tc = tbxGorTc.Text,
                SgkNumara = tbxGorSgk.Text,
                Maas = Convert.ToDouble(tbxGorMaas.Text),
                saatlikMesaiUcreti = Convert.ToDouble(tbxGorSaat.Text),
                izinGun = izinGunu,
                KadroluMu = RadioKadrolu.Checked,
                MesaiSaati = Convert.ToInt32(tbxMesaiSaati.Text),
                MaasOdendiMi = checkGorMaasOdendi.Checked,

            });
            if (GorevliResimSecildiMi)
            {
                File.Delete(PathGorevli + tbxGorTc.Text + ".jpg");
                GorevliResimSec(tbxGorTc.Text);
            }
            if (MessageBox.Show("Gorevli bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Gorevli Sistemimize Başarıyla Guncellenmiştir");
            }
            Goruntule();

        }




        private void btnGorevliSil_Click(object sender, EventArgs e)
        {
            GorevliId = Convert.ToInt32(dgwGorevliEkle.CurrentRow.Cells[4].Value);
            gorevliEkle.Cikar(GorevliId);
            Goruntule();
        }

        private void btnMuhEkle_Click(object sender, EventArgs e)
        {

            muhasebeciEkle.Ekle(new Muhasebeci
            {
                PersonelAd = tbxMuhIsim.Text,
                PersonelSoyad = tbxMuhSoyIsim.Text,
                Adres = tbxMuhAdes.Text,
                Maas = Convert.ToDouble(tbxMuhMaas.Text),
                Ozgecmis = tbxMuhOzgecmis.Text,
                SgkNumara = TbxMuhsgk.Text,
                Sifre = tbxMuhSifre.Text,
                Tc = tbxMuhTc.Text,
                yıllıkizin = Convert.ToInt32(tbxMuhIzin.Text),
                MaasOdendiMi = checkMuhMaas.Checked,



            });
            MuhasebeResimSec();
            if (MessageBox.Show("Çalışanın bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Muhasebeci Sistemimize Başarıyla Eklenmiştir");
            }
            Goruntule();
        }

        private void btnMuhGuncelle_Click(object sender, EventArgs e)
        {
            bool maasOdendiMi = false;
            if (checkMaasOdendi.Checked)
            {
                maasOdendiMi = true;
            }

            muhasebeciEkle.Guncelle(new Muhasebeci
            {
                PersonelId = MuhasebeId,
                PersonelAd = tbxMuhIsim.Text,
                PersonelSoyad = tbxMuhSoyIsim.Text,
                Adres = tbxMuhAdes.Text,
                Maas = Convert.ToDouble(tbxMuhMaas.Text),
                Ozgecmis = tbxMuhOzgecmis.Text,
                SgkNumara = TbxMuhsgk.Text,
                Sifre = tbxMuhSifre.Text,
                Tc = tbxMuhTc.Text,
                yıllıkizin = Convert.ToInt32(tbxMuhIzin.Text),
                MaasOdendiMi = maasOdendiMi


            });
            if (MuhasebeResimSecildiMi)
            {
                File.Delete(PathMuhasebe + tbxMuhTc.Text + ".jpg");
                MuhasebeResimSec(tbxMuhTc.Text);
            }
            if (MessageBox.Show("Gorevli bütün bilgilerinin doğruluğundan emin misiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Gorevli Sistemimize Başarıyla Guncellenmiştir");
            }
            Goruntule();

        }

        private void btnMuhSil_Click(object sender, EventArgs e)
        {
            MuhasebeId = Convert.ToInt32(dgwMuhasebeEkle.CurrentRow.Cells[2].Value);
            muhasebeciEkle.Cikar(MuhasebeId);
            Goruntule();
        }

        void CheckTopla()
        {
            checkBoxes.Add(checkCars);
            checkBoxes.Add(checkPazartesi);
            checkBoxes.Add(checkSali);
            checkBoxes.Add(checkPersembe);
            checkBoxes.Add(checkCmt);
            checkBoxes.Add(checkCuma);
            checkBoxes.Add(checkPzr);
            checkBoxes.Add(checkGorMaasOdendi);
        }
        public void CheckBosalt()
        {
            foreach (var item in checkBoxes)
            {
                item.Checked = false;
            }
        }
        private void dgwMudurGoruntule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MudurId = Convert.ToInt32(dgwMudurGoruntule.CurrentRow.Cells[3].Value);
            tbxIsim.Text = dgwMudurGoruntule.CurrentRow.Cells[4].Value.ToString();
            tbxSoyisim.Text = dgwMudurGoruntule.CurrentRow.Cells[5].Value.ToString();
            tbxAdres.Text = dgwMudurGoruntule.CurrentRow.Cells[6].Value.ToString();
            tbxTc.Text = dgwMudurGoruntule.CurrentRow.Cells[7].Value.ToString();
            tbxSifre.Text = dgwMudurGoruntule.CurrentRow.Cells[8].Value.ToString();
            tbxMaas.Text = dgwMudurGoruntule.CurrentRow.Cells[9].Value.ToString();
            tbxSgk.Text = dgwMudurGoruntule.CurrentRow.Cells[10].Value.ToString();
            tbxIkramiye.Text = dgwMudurGoruntule.CurrentRow.Cells[0].Value.ToString();
            tbxOzgecmis.Text = dgwMudurGoruntule.CurrentRow.Cells[1].Value.ToString();
            tbxDiller.Text = dgwMudurGoruntule.CurrentRow.Cells[2].Value.ToString();
            checkMaasOdendi.Checked = Convert.ToBoolean(dgwMudurGoruntule.CurrentRow.Cells[11].Value);
            pcbResim.ImageLocation = PathMudur + dgwMudurGoruntule.CurrentRow.Cells[7].Value.ToString() + ".jpg";


        }
        private void dgwGorevliEkle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CheckBosalt();
            foreach (var item in checkBoxes)
            {
                if (item.Text == dgwGorevliEkle.CurrentRow.Cells[1].Value.ToString())
                {


                    item.Checked = true;
                }


            }
            if (Convert.ToBoolean(dgwGorevliEkle.CurrentRow.Cells[2].Value) == true)
            {
                RadioKadrolu.Checked = true;
            }
            else
            {
                RadioKadrolu.Checked = false;
            }
            if (Convert.ToBoolean(dgwGorevliEkle.CurrentRow.Cells[2].Value) == false)
            {
                Part.Checked = true;
            }
            else
            {
                Part.Checked = false;
            }
            GorevliId = Convert.ToInt32(dgwGorevliEkle.CurrentRow.Cells[4].Value);
            tbxGorIsim.Text = dgwGorevliEkle.CurrentRow.Cells[5].Value.ToString();
            tbxGorSoyisim.Text = dgwGorevliEkle.CurrentRow.Cells[6].Value.ToString();
            tbxGorAdres.Text = dgwGorevliEkle.CurrentRow.Cells[7].Value.ToString();
            tbxGorTc.Text = dgwGorevliEkle.CurrentRow.Cells[8].Value.ToString();
            tbxGorSifre.Text = dgwGorevliEkle.CurrentRow.Cells[9].Value.ToString();
            tbxGorMaas.Text = dgwGorevliEkle.CurrentRow.Cells[10].Value.ToString();
            tbxGorSgk.Text = dgwGorevliEkle.CurrentRow.Cells[11].Value.ToString();
            tbxGorSaat.Text = dgwGorevliEkle.CurrentRow.Cells[0].Value.ToString();
            tbxMesaiSaati.Text = dgwGorevliEkle.CurrentRow.Cells[3].Value.ToString();
            checkGorMaasOdendi.Checked = Convert.ToBoolean(dgwGorevliEkle.CurrentRow.Cells[12].Value);
            pcbGorevli.ImageLocation = PathGorevli + dgwGorevliEkle.CurrentRow.Cells[8].Value.ToString() + ".jpg";



        }
       

        private void dgwMuhasebeEkle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MuhasebeId = Convert.ToInt32(dgwMuhasebeEkle.CurrentRow.Cells[2].Value);
            tbxMuhIsim.Text = dgwMuhasebeEkle.CurrentRow.Cells[3].Value.ToString();
            tbxMuhSoyIsim.Text = dgwMuhasebeEkle.CurrentRow.Cells[4].Value.ToString();
            tbxMuhAdes.Text = dgwMuhasebeEkle.CurrentRow.Cells[5].Value.ToString();
            tbxMuhTc.Text = dgwMuhasebeEkle.CurrentRow.Cells[6].Value.ToString();
            tbxMuhSifre.Text = dgwMuhasebeEkle.CurrentRow.Cells[7].Value.ToString();
            tbxMuhMaas.Text = dgwMuhasebeEkle.CurrentRow.Cells[8].Value.ToString();
            TbxMuhsgk.Text = dgwMuhasebeEkle.CurrentRow.Cells[9].Value.ToString();
            tbxMuhIzin.Text = dgwMuhasebeEkle.CurrentRow.Cells[0].Value.ToString();
            tbxMuhOzgecmis.Text = dgwMuhasebeEkle.CurrentRow.Cells[1].Value.ToString();
            checkMuhMaas.Checked = Convert.ToBoolean(dgwMuhasebeEkle.CurrentRow.Cells[10].Value);
            pcbMuhasebe.ImageLocation = PathMuhasebe + dgwMuhasebeEkle.CurrentRow.Cells[6].Value.ToString() + ".jpg";



        }
        public void MudurResimSec(string resim)
        {
            MudurResimDestination = PathMudur + resim + ".jpg";
            File.Copy(MudurResimYer, MudurResimDestination);

        }
        public void MudurResimSec()
        {
            string resim = tbxTc.Text;
            MudurResimDestination = PathMudur + resim + ".jpg";
            File.Copy(MudurResimYer, MudurResimDestination);


        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                dialog.Filter = "Image Files(*.JPG;)|*.JPG;";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    MudurResimYer = dialog.FileName;
                    pcbResim.ImageLocation = MudurResimYer;

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
                    MudurResimSecildiMi = true;
                    MudurResimYer = dialog.FileName;
                    pcbResim.ImageLocation = MudurResimYer;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGorResimEkle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                dialog.Filter = "Image Files(*.JPG;)|*.JPG;";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    GorevliResimYer = dialog.FileName;
                    pcbGorevli.ImageLocation = GorevliResimYer;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGorResimGunc_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.JPG;)|*.JPG;";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    GorevliResimSecildiMi = true;
                    GorevliResimYer = dialog.FileName;
                    pcbGorevli.ImageLocation = GorevliResimYer;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMuhResEkle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                dialog.Filter = "Image Files(*.JPG;)|*.JPG;";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    MuhasebeResimYer = dialog.FileName;
                    pcbMuhasebe.ImageLocation = MuhasebeResimYer;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnMuhResimGuncele_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.JPG;)|*.JPG;";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MuhasebeResimSecildiMi = true;
                    MuhasebeResimYer = dialog.FileName;
                    pcbMuhasebe.ImageLocation = MuhasebeResimYer;


                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGeriMud_Click(object sender, EventArgs e)
        {
            Anagiris anagiris = new Anagiris();
            anagiris.ShowDialog();
            this.Hide();
        }

        private void btnGeriGorevli_Click(object sender, EventArgs e)
        {
            Anagiris anagiris = new Anagiris();
            anagiris.ShowDialog();
            this.Hide();
        }

        private void btnMuhGeri_Click(object sender, EventArgs e)
        {
            Anagiris anagiris = new Anagiris();
            anagiris.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void GorevliResimSec(string resim)
        {
            GorevliResimDestination = PathGorevli + resim + ".jpg";
            File.Copy(GorevliResimYer, GorevliResimDestination);

        }
        public void GorevliResimSec()
        {
            string resim = tbxGorTc.Text;
            GorevliResimDestination = PathGorevli + resim + ".jpg";
            File.Copy(GorevliResimYer, GorevliResimDestination);


        }
        public void MuhasebeResimSec(string resim)
        {
            MuhasebeResimDestination = PathMuhasebe + resim + ".jpg";
            File.Copy(MuhasebeResimYer, MuhasebeResimDestination);

        }
        public void MuhasebeResimSec()
        {
            string resim = tbxMuhTc.Text;
            MuhasebeResimDestination = PathMuhasebe + resim + ".jpg";
            File.Copy(MuhasebeResimYer, MuhasebeResimDestination);


        }





    }
}
