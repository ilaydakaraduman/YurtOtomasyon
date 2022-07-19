using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YurtOtomasyonu2.Odalar;
using YurtOtomasyonu2.Odemeler;
using YurtOtomasyonu2.Ogrenci;

namespace YurtOtomasyonu2
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PersonelEkle_Form());
        }
    }
}
