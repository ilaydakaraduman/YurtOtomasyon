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
    public partial class OdaForm : Form
    {
        OdaEkleKod odaEkleKod = new OdaEkleKod();
        public OdaForm()
        {
            InitializeComponent();
        }

       

        private void dgwOda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void OdaGetir()
        {
            dgwOda.DataSource = odaEkleKod.GetAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            odaEkleKod.Guncelle(new Oda
            {
                OdaId = Convert.ToInt32(dgwOda.CurrentRow.Cells[0].Value),
                KisiSayisi = Convert.ToInt32(tbxKisiSayi.Text),
                KalanIsim = tbxKisiler.Text,
                OdaNo = Convert.ToInt32(tbxOdaNo.Text),
                OdadakiKisiSayi = Convert.ToInt32(tbxKalan.Text),
                TemizlendiMi = cbxTemizMi.Checked,
                 
            });
            OdaGetir();
        }

        private void dgwOda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxKisiSayi.Text =dgwOda.CurrentRow.Cells[2].Value.ToString();
            tbxKisiler.Text = dgwOda.CurrentRow.Cells[3].Value.ToString();
            tbxOdaNo.Text = dgwOda.CurrentRow.Cells[1].Value.ToString();
            tbxKalan.Text = dgwOda.CurrentRow.Cells[4].Value.ToString();
            cbxTemizMi.Checked = Convert.ToBoolean(dgwOda.CurrentRow.Cells[5].Value);


        }

        private void OdaForm_Load(object sender, EventArgs e)
        {
            OdaGetir();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anagiris anagiris = new Anagiris();
            anagiris.ShowDialog();
            this.Hide();
        }
    }
}
