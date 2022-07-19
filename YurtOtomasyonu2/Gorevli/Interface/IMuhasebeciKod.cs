using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtOtomasyonu2
{
    interface IMuhasebeciKod
    {
        List<Muhasebeci> GetAll();
        void Ekle(Muhasebeci muhasebeci);
        void Guncelle(Muhasebeci muhasebeci);
        void Cikar(int id);
    }
}
