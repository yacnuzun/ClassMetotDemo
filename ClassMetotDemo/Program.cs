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
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri1 = new Musteri();
            musteriManager.Add(musteri1, 1, "Miko", "Gurler");
            Musteri musteri2 = new Musteri();
            musteriManager.Add(musteri2,2,"Selahittin","Zorlu");
            Musteri musteri3 = new Musteri();
            musteriManager.Add(musteri3,3,"İsmail","Abi");
            
            
            musteriManager.View();
            musteriManager.Delete(2);
            musteriManager.View();
            
            Console.Read();
        }
    }
}
