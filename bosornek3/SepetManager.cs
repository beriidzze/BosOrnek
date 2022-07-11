using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bosornek3
{
    public class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi : "+ urun.Adi+","+urun.stokMiktar);
        }
        public void Ekle2(string Adi,double Fiyat,string Aciklama,int stokadet)// boyle yapmaya hic gerek yok 
        {                                                                      //class'tan olustursan daha iyi sikintida olmaz 
            Console.WriteLine("sepete eklendi : "+ Adi);
        }
    }
}
