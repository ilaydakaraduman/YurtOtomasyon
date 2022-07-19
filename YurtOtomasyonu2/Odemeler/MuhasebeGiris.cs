using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonu2.Odemeler
{

    public partial class MuhasebeGiris : Form
    {
        GorevliEkleKod gorevliEkleKod = new GorevliEkleKod();
        MudurEkleKod mudurEkleKod = new MudurEkleKod();
        MuhasebeciEkleKod muhasebeciEkleKod = new MuhasebeciEkleKod();
        public MuhasebeGiris()
        {
            InitializeComponent();
        }

        private void MuhasebeGiris_Load(object sender, EventArgs e)
        {
            goruntule();

        }
        public void goruntule()
        {
            dgwGor.DataSource = gorevliEkleKod.GetAll();
            dgwMudur.DataSource = mudurEkleKod.GetAll();
            dgwMuh.DataSource = muhasebeciEkleKod.GetAll();
        }

        private void btnMuhGuncelle_Click(object sender, EventArgs e)
        {
            Muhasebeci muhasebeci = new Muhasebeci
            {
                yıllıkizin = Convert.ToInt32(dgwMuh.CurrentRow.Cells[0].Value.ToString()),
                Ozgecmis = dgwMuh.CurrentRow.Cells[1].Value.ToString(),
                PersonelId = Convert.ToInt32(dgwMuh.CurrentRow.Cells[2].Value.ToString()),
                PersonelAd = dgwMuh.CurrentRow.Cells[3].Value.ToString(),
                PersonelSoyad = dgwMuh.CurrentRow.Cells[4].Value.ToString(),
                Adres = dgwMuh.CurrentRow.Cells[5].Value.ToString(),
                Maas = Convert.ToDouble(dgwMuh.CurrentRow.Cells[8].Value.ToString()),
                SgkNumara = dgwMuh.CurrentRow.Cells[9].Value.ToString(),
                Sifre = dgwMuh.CurrentRow.Cells[7].Value.ToString(),
                Tc = dgwMuh.CurrentRow.Cells[6].Value.ToString(),
                MaasOdendiMi = Convert.ToBoolean(dgwMuh.CurrentRow.Cells[10].Value.ToString()),

            };
            muhasebeci.MaasOde(muhasebeci);
            muhasebeciEkleKod.Guncelle(muhasebeci);
            MessageBox.Show("İşlem Başarıyla Gerçekleşti");
            goruntule();
        }

        private void btnGorGuncelle_Click(object sender, EventArgs e)
        {
            Gorevli gorevli = new Gorevli
            {
                izinGun = dgwGor.CurrentRow.Cells[1].Value.ToString(),
                KadroluMu = Convert.ToBoolean(dgwGor.CurrentRow.Cells[2].Value.ToString()),
                MesaiSaati = Convert.ToInt32(dgwGor.CurrentRow.Cells[3].Value.ToString()),
                saatlikMesaiUcreti = Convert.ToInt32(dgwGor.CurrentRow.Cells[0].Value.ToString()),
                PersonelId = Convert.ToInt32(dgwGor.CurrentRow.Cells[4].Value.ToString()),
                PersonelAd = dgwGor.CurrentRow.Cells[5].Value.ToString(),
                PersonelSoyad = dgwGor.CurrentRow.Cells[6].Value.ToString(),
                Adres = dgwGor.CurrentRow.Cells[7].Value.ToString(),
                Maas = Convert.ToDouble(dgwGor.CurrentRow.Cells[10].Value.ToString()),
                SgkNumara = dgwGor.CurrentRow.Cells[11].Value.ToString(),
                Sifre = dgwGor.CurrentRow.Cells[9].Value.ToString(),
                Tc = dgwGor.CurrentRow.Cells[8].Value.ToString(),
                MaasOdendiMi = Convert.ToBoolean(dgwGor.CurrentRow.Cells[12].Value.ToString()),


            };
            gorevli.MaasOde(gorevli);
            gorevliEkleKod.Guncelle(gorevli);
            MessageBox.Show("İşlem Başarıyla Gerçekleşti");
            goruntule();
        }
        private void btnMudGuncelle_Click(object sender, EventArgs e)
        {
            Mudur mudur = new Mudur
            {
               
                Diller = dgwMudur.CurrentRow.Cells[2].Value.ToString(),
                ikramiye = Convert.ToDouble(dgwMudur.CurrentRow.Cells[0].Value.ToString()),
                Ozgecmis =  dgwMudur.CurrentRow.Cells[1].Value.ToString(),
                PersonelId = Convert.ToInt32(dgwMudur.CurrentRow.Cells[3].Value.ToString()),
                PersonelAd = dgwMudur.CurrentRow.Cells[4].Value.ToString(),
                PersonelSoyad = dgwMudur.CurrentRow.Cells[5].Value.ToString(),
                Adres = dgwMudur.CurrentRow.Cells[6].Value.ToString(),
                Maas = Convert.ToDouble(dgwMudur.CurrentRow.Cells[9].Value.ToString()),
                SgkNumara = dgwMudur.CurrentRow.Cells[10].Value.ToString(),
                Sifre = dgwMudur.CurrentRow.Cells[8].Value.ToString(),
                Tc = dgwMudur.CurrentRow.Cells[7].Value.ToString(),
                MaasOdendiMi = Convert.ToBoolean(dgwMudur.CurrentRow.Cells[11].Value.ToString()),
            };
            mudur.MaasOde(mudur);
            mudurEkleKod.Guncelle(mudur);
            MessageBox.Show("İşlem Başarıyla Gerçekleşti");
            goruntule();
        }
        

        private void dgwMuh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxMuhTopTutar.Text = dgwMuh.CurrentRow.Cells[8].Value.ToString();
            cbMuhMaas.Checked = Convert.ToBoolean(dgwMuh.CurrentRow.Cells[10].Value.ToString());
        }

        private void dgwGor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool KadroluMu = Convert.ToBoolean(dgwGor.CurrentRow.Cells[2].Value);
            double maas = Convert.ToDouble(dgwGor.CurrentRow.Cells[10].Value.ToString());
            int saatlikMesaiUcreti = Convert.ToInt32(dgwGor.CurrentRow.Cells[0].Value.ToString());
            int MesaiSaati = Convert.ToInt32(dgwGor.CurrentRow.Cells[3].Value.ToString());
            if(KadroluMu)
            {
                tbxGorTopTutar.Text = maas.ToString();
            }
            else
            {
                tbxGorTopTutar.Text = (Convert.ToDouble(saatlikMesaiUcreti * MesaiSaati) + maas).ToString();
            }
            cbGorOdendiMi.Checked = Convert.ToBoolean(dgwGor.CurrentRow.Cells[12].Value.ToString());

        }

        private void dgwMudur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double ikramiye = Convert.ToDouble(dgwMudur.CurrentRow.Cells[0].Value.ToString());
            double maas = Convert.ToDouble(dgwMudur.CurrentRow.Cells[9].Value.ToString());
            tbxMudToptutar.Text = (ikramiye + maas).ToString();
            cbMudurMaasOdendiMi.Checked = Convert.ToBoolean(dgwMudur.CurrentRow.Cells[11].Value.ToString());


        }


    }
}
