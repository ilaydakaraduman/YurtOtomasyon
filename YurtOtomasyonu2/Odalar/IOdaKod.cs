using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace YurtOtomasyonu2.Odalar
{
    public interface IOdaKod
    {
        List<Oda> GetAll();
        void Guncelle(Oda oda);

    }
}