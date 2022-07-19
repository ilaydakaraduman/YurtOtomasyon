using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtOtomasyonu2
{
    public class Gorevli : Personel
    {
        private double _saatlikMesaiUcreti;
        private string _izinGun;
        private bool _KadroluMu;
        private int _MesaiSaati;
        public double saatlikMesaiUcreti { get { return _saatlikMesaiUcreti; } set { _saatlikMesaiUcreti = value; } }
        public string izinGun { get { return _izinGun; } set { _izinGun = value; } }
        public bool KadroluMu { get { return _KadroluMu; } set { _KadroluMu = value; } }
        public int MesaiSaati { get { return _MesaiSaati; } set { _MesaiSaati = value; } }

        public override bool MaasOde(Personel personel)
        {
            personel.MaasOdendiMi = true;
            return base.MaasOde(personel);
        }

    }
}
