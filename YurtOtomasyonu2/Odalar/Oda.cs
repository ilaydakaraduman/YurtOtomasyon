using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtOtomasyonu2.Odalar
{
    public class Oda
    {
        private int _OdaId;
        private int _OdaNo;
        private int _KisiSayisi;
        private string _KalanIsim;
        private int _OdadakiKisiSayi;
        private bool _TemizlendiMi;
        public int OdaId { get { return _OdaId; } set { _OdaId = value; } }
        public int OdaNo { get { return _OdaNo; } set { _OdaNo = value; } }
        public int KisiSayisi { get { return _KisiSayisi; } set { _KisiSayisi = value; } }
        public string KalanIsim { get { return _KalanIsim; } set { _KalanIsim = value; } }
        public int OdadakiKisiSayi { get { return _OdadakiKisiSayi; } set { _OdadakiKisiSayi = value; } }
        public bool TemizlendiMi { get { return _TemizlendiMi; } set { _TemizlendiMi = value; } }
    }
}
