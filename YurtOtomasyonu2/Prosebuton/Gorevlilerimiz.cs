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
    public partial class Gorevlilerimiz : Form
    {
        public Gorevlilerimiz()
        {
            InitializeComponent();
        }
        string directory = AppDomain.CurrentDomain.BaseDirectory;

        private void mudur1kadro_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.InitialDirectory = directory;
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            //  dosya.Title = " ";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pictureBox1.ImageLocation = DosyaYolu;
        }

        private void Btnmudur2kadro_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.InitialDirectory = directory;
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            // dosya.Title = "  ";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pictureBox2.ImageLocation = DosyaYolu;
        }

        private void btnmudur3kadro_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.InitialDirectory = directory;
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            // dosya.Title = " ";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pictureBox3.ImageLocation = DosyaYolu;

        }

        private void btngorevli1Degisiklik_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.InitialDirectory = directory;
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            // dosya.Title = " ";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pictureBox6.ImageLocation = DosyaYolu;
        }

        private void btngorevli2degisiklik_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.InitialDirectory = directory;
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            // dosya.Title = " ";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pictureBox5.ImageLocation = DosyaYolu;
        }

        private void btngorevli3degis_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.InitialDirectory = directory;
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            // dosya.Title = " ";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pictureBox4.ImageLocation = DosyaYolu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.InitialDirectory = directory;
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            // dosya.Title = "  ";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pictureBox9.ImageLocation = DosyaYolu;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.InitialDirectory = directory;
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            // dosya.Title = " ";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pictureBox8.ImageLocation = DosyaYolu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.InitialDirectory = directory;
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            // dosya.Title = "  ";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pictureBox7.ImageLocation = DosyaYolu;
        }

        private void Gorevlilerimiz_Load(object sender, EventArgs e)
        {

        }

        private void Gorevlilerimiz_Load_1(object sender, EventArgs e)
        {

        }
    }
}
