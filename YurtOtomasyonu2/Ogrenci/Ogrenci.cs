using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtOtomasyonu2.Ogrenci
{
    public class Ogrenci
    {
        private int _OgrenciId;
        private string _Ad;
        private string _Soyad;
        private string _Tc;
        private string _Adres;
        private string _Okul;
        private int _OdaNo;
        private int _OdaId;
        private bool _TaksitVarMı;
        private int _ToplamTaksitMiktari;
        private string _VeliAd;
        private string _VeliSoyad;
        private bool _ParaOdendiMi;
        private int _TaksitSayisi;

        public int OgrenciId { get { return _OgrenciId; } set { _OgrenciId = value; } }
        public string Ad { get { return _Ad; } set { _Ad = value; } }
        public string Soyad { get { return _Soyad; } set { _Soyad = value; } }
        public string Tc { get { return _Tc; } set { _Tc = value; } }
        public string Adres { get { return _Adres; } set { _Adres = value; } }
        public string Okul { get { return _Okul; } set { _Okul = value; } }
        public int OdaNo { get { return _OdaNo; } set { _OdaNo = value; } }
        public int OdaId { get { return _OdaId; } set { _OdaId = value; } }
        public bool TaksitVarMı { get { return _TaksitVarMı; } set { _TaksitVarMı = value; } }
        public int ToplamTaksitMiktari { get { return _ToplamTaksitMiktari; } set { _ToplamTaksitMiktari = value; } }
        public string VeliAd { get { return _VeliAd; } set { _VeliAd = value; } }
        public string VeliSoyad { get { return _VeliSoyad; } set { _VeliSoyad = value; } }
        public bool ParaOdendiMi { get { return _ParaOdendiMi; } set { _ParaOdendiMi = value; } }
        public int TaksitSayisi { get { return _TaksitSayisi; } set { _TaksitSayisi = value; } }
    }
}
    

