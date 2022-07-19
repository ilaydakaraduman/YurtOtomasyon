using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtOtomasyonu2
{
    public abstract class Personel
    {
        private int _PersonelId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _Adres;
        private string _Tc;
        private string _Sifre;
        private double _Maas;
        private string _SgkNumara;
        private bool _MaasOdendiMi;
        public int PersonelId { get { return _PersonelId; } set { _PersonelId = value; } }
        public string PersonelAd { get { return _PersonelAd; } set { _PersonelAd = value; } }
        public string PersonelSoyad { get { return _PersonelSoyad; } set { _PersonelSoyad = value; } }
        public string Adres { get { return _Adres; } set { _Adres = value; } }
        public string Tc { get { return _Tc; } set { _Tc = value; } }
        public string Sifre { get { return _Sifre; } set { _Sifre = value; } }
        public double Maas { get { return _Maas; } set { _Maas = value; } }
        public string SgkNumara { get { return _SgkNumara; } set { _SgkNumara = value; } }
        public bool   MaasOdendiMi { get { return _MaasOdendiMi; } set { _MaasOdendiMi = value; } }



        public virtual bool MaasOde(Personel personel)
        {
            personel.MaasOdendiMi = true;
            return personel.MaasOdendiMi;
        }
    }
}
