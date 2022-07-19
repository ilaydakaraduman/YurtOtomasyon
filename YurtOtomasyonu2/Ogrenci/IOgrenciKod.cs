using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtOtomasyonu2.Ogrenci
{
    interface IOgernciKod
    {
        List<Ogrenci> GetAll();
        void Ekle(Ogrenci ogrenci);
        void Guncelle(Ogrenci ogrenci);
        void Cikar(int id);
        List<Ogrenci> OgrenciAra(string key);
    }
}
