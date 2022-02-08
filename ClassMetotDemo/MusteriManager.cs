using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri,int musteriId,string musteriAd,string musteriSoyad)
        {
            musteri.Id = musteriId;
            musteri.Ad = musteriAd;
            musteri.Soyad = musteriSoyad;
            Console.WriteLine(musteriAd+" "+musteriSoyad+" Added!!");
        }

        public void View(Musteri[] musteriler)
        {
            foreach (Musteri m in musteriler)
            { 
                Console.WriteLine(m.Id+ "\n" + m.Ad+"\n"+m.Soyad);
                Console.WriteLine("------------------");
            }
            
        }
        public void Delete(Musteri[] musteriler)
        {
            Console.WriteLine(musteriler+" Deleted!!");
        }
    }
}
