using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri[] musteriler)
        {
            Console.WriteLine(musteriler+" Added!!");
        }

        public void View(Musteri [] musteriler)
        {
            Console.WriteLine(musteriler);
        }
        public void Delete(Musteri[] musteriler)
        {
            Console.WriteLine(musteriler+" Deleted!!");
        }
    }
}
