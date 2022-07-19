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
using YurtOtomasyonu2.Odemeler;

namespace YurtOtomasyonu2.Prosebuton
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }

        List<Mudur> mudurs = new List<Mudur>();
        List<Gorevli> gorevlis = new List<Gorevli>();
        List<Muhasebeci> muhasebecis = new List<Muhasebeci>();
        MuhasebeciEkleKod muhasebeciKod = new MuhasebeciEkleKod();
        MudurEkleKod mudurKod = new MudurEkleKod();
        GorevliEkleKod gorevliKod = new GorevliEkleKod();
        private void GirisFormu_Load(object sender, EventArgs e)
        {
            tbxSifre.PasswordChar = '*';
            mudurs = mudurKod.GetAll();
            gorevlis = gorevliKod.GetAll();
            muhasebecis = muhasebeciKod.GetAll();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            foreach (var mudur in mudurs)
            {
                if (mudur.Tc == tbxTc.Text && mudur.Sifre == tbxSifre.Text)
                {
                    PersonelEkle_Form personelEkle_Form = new PersonelEkle_Form();
                    this.Hide();
                    personelEkle_Form.Show();
                }

            }
            foreach (var gorevli in gorevlis)
            {
                if (gorevli.Tc == tbxTc.Text && gorevli.Sifre == tbxSifre.Text)
                {
                    GorevliOdaForm gorevliOdaForm = new GorevliOdaForm();
                    this.Hide();

                    gorevliOdaForm.Show();
                }

            }
            foreach (var muhasebeci in muhasebecis)
            {
                if (muhasebeci.Tc == tbxTc.Text && muhasebeci.Sifre == tbxSifre.Text)
                {
                    MuhasebeGiris muhasebeGiris = new MuhasebeGiris();
                    this.Hide();

                    muhasebeGiris.Show();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anagiris anagiris = new Anagiris();
            anagiris.Show();
            this.Hide();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

