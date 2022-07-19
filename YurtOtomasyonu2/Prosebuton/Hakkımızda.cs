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
    public partial class Hakkımızda : Form
    {
        public Hakkımızda()
        {
            InitializeComponent();
        }

        private void Hakkımızda_Load(object sender, EventArgs e)
        {
            label2.Text = "Bonheur Yurtları";
            label1.Text = " Öğrencilerine hem anne şefkati \n 5 yıldızlı oteliğin sağladığı konaklama imkanları \n Lezzetli yemek ve en iyi kadrosuyla sizlerle...";

        }
        public abstract class Genel
        {
            public string yazı1 = "  ";
            public string yazı2 = "  ";
            public string yazi, Baslik;
            public abstract void ozellikyaz();

        }
        public class Hakkimizda : Genel
        {
            public string _yazi;
            public override void ozellikyaz()
            {
                Baslik = "HAKKIMIZDA";
                yazi = _yazi;
            }
        }
        class Bizkimiz : Genel
        {
            public string _yazi;
            public override void ozellikyaz()
            {
                Baslik = "BİZ KİMİZ ?";
                yazi = _yazi;
            }
        }
        class Subeler : Genel
        {
            public string _yazi;
            public override void ozellikyaz()
            {
                Baslik = "ŞUBELERİMİZ";
                yazi = _yazi;
            }
        }


        private void HakkımzdaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Hakkimizda hakkimizda = new Hakkimizda();
            hakkimizda._yazi = "Anadolu'nun çeşitli kentlerinden gelen çocuklarımıza \n sıcak bir ev ortamı sağladığımıza emin oluruz,\n40'a yakın personelimizle öğrencilerimizin \n24 saat hizmetinde olduğumuz için,\nGece rahatsızlık geçiren çocuklarımız için \n 2 araç ve 3 personel tahsis ederek yardımcı olduğumuz için \n,Öğrencilerimizin okullarında % 98 oranında \n başarılı olmasını sağlıyacak ortamı yarattığımız için...";
            hakkimizda.ozellikyaz();
            label1.Text = hakkimizda._yazi;
            label2.Text = hakkimizda.Baslik;
        }

        private void BizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bizkimiz bizkimiz = new Bizkimiz();
            bizkimiz._yazi = "Sektörün, ilk özel kurumlarından biri olmamız \n hasebi ile  özel öğrenci yurtlarına  aşinalığın henüz \n yerleşmediği  1998 yılında, kız öğrencisini, kendi \n kızı gibi gören ve öyle kabul eden, \n güzide bir özel, vakıf, yurdu rektör yardımcısının,\n telefonla bizzat arayıp bize yönelttiği soru bu idi \n 1998 yılında, bir yığın resmi belgeler içeren \n bir sunum dosyasına üst kapak yaptığımız cevabi\n yazımızın ilgili paragrafını, yaklaşık \n 21 yıl sonra, noktasından virgülüne birebir aşağıya \n koyuyoruz.";

            bizkimiz.ozellikyaz();
            label1.Text = bizkimiz._yazi;
            label2.Text = bizkimiz.Baslik;
        }

        private void SubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subeler sube = new Subeler();
            sube._yazi = "İstanbul/Levent şubesi         Antalya/Akdeniz şubesi\n\n Ankara/Çayyolu şubesi         Trabzon/Karaca şubesi\n\n Eskiehir/Batıkent şubesi \n\n Adana/Çukurambar şubesi \n\n İzmir/Konak şubesi \n\n Bursa/Uludağ mahallesi";
            sube.ozellikyaz();
            label1.Text = sube._yazi;
            label2.Text = sube.Baslik;
        }
    }
}
