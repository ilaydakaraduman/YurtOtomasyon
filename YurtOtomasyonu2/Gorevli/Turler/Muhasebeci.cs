using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtOtomasyonu2
{
    public class Muhasebeci : Personel {

        private int _yıllıkizin;
        private string _Ozgecmis;
        public int yıllıkizin { get { return _yıllıkizin; } set { _yıllıkizin = value; } }
        public string Ozgecmis { get { return _Ozgecmis; } set { _Ozgecmis = value; } }

        public override bool MaasOde(Personel personel)
        {
            personel.MaasOdendiMi = true;
            return base.MaasOde(personel);
        }
    }
}
