using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtOtomasyonu2
{
    public class Mudur : Personel
    {
        private double _ikramiye;
        private string _Ozgecmis;
        private string _Diller;


        public double ikramiye { get { return _ikramiye; } set { _ikramiye = value; } }
        public string Ozgecmis { get { return _Ozgecmis; } set { _Ozgecmis = value; } }
        public string Diller { get { return _Diller; } set { _Diller = value; } }

        public override bool MaasOde(Personel personel)
        {
            personel.MaasOdendiMi = true;
            return base.MaasOde(personel);
        }
    }
}
