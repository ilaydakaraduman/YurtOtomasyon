using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtOtomasyonu2
{
    interface IGorevliKod
    {
        List<Gorevli> GetAll();
        void Ekle(Gorevli görevli);
        void Guncelle(Gorevli görevli);
        void Cikar(int id);
    }
}
