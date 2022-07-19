using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonu2.Prosebuton
{
    public partial class Anagiris : Form
    {
        public Anagiris()
        {
            InitializeComponent();
        }


        private void kADROMUZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gorevlilerimiz gorev = new Gorevlilerimiz();
            this.Hide();
            gorev.Show();
        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkımızda hak = new Hakkımızda();
            this.Hide();
            hak.Show();
        }

        private void mÜDÜRGİRİŞİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirisFormu girisFormu = new GirisFormu();
            this.Hide();
            girisFormu.ShowDialog();

        }

        private void gÖREVLİGİRİŞİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirisFormu girisFormu = new GirisFormu();
            this.Hide();
            girisFormu.ShowDialog();
        }

        private void mUHASEBEGİRİŞİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirisFormu girisFormu = new GirisFormu();
            this.Hide();

            girisFormu.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void gİRİŞLERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iLETİŞİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İletisim iletisim = new İletisim();
            this.Hide();
            iletisim.Show();
        }

        private void yURDUMUZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yurdumuz yurdumuz = new Yurdumuz();
            this.Hide();
            yurdumuz.Show();
        }

        private void Anagiris_Load(object sender, EventArgs e)
        {

        }
    }
}

