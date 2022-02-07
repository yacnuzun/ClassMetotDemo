using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Miko";
            musteri1.Soyad = "Gurler";
            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Selahittin";
            musteri2.Soyad = "Kısazade";
            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "İsmail";
            musteri3.Soyad = "Abi";
            Musteri [] musteriler=new Musteri[] { musteri1,musteri2,musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.View(musteri);
            }
            
            Console.Read();
        }
    }
}
