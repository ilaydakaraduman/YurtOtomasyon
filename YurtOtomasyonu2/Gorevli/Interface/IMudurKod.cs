using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtOtomasyonu2
{
    interface IMudurKod
    {
        List<Mudur> GetAll();
        void Ekle(Mudur muhasebeci);
        void Guncelle(Mudur muhasebeci);
        void Cikar(int id);
    }
}
