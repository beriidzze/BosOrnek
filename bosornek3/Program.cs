using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bosornek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya";
            urun1.stokMiktar = 65;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Adana";
            urun2.stokMiktar = 89;

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(".'.'.'.'.'.'.'.'.'.'.'.'.'.'.'.'.");
            }
            
            Console.WriteLine("______metotlar______");
            SepetManager sepetManadger = new SepetManager();
            sepetManadger.Ekle(urun1);
            sepetManadger.Ekle(urun2);

            sepetManadger.Ekle2("armut",45,"kirmiz armut",15);
            sepetManadger.Ekle2("elam", 65, "kirmiz elam",45);
            sepetManadger.Ekle2("helva", 33, "yesil helva",1);


            Console.ReadLine();
        }
    }
}
