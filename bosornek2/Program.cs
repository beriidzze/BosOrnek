using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bosornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.adi = "islam";
            kurs1.proje = "c#";
            kurs1.izlenme = 500;
            
            kurs kurs2 = new kurs();
            kurs2.adi = "musa";
            kurs2.proje = "java";
            kurs2.izlenme = 1000;

            kurs kurs3 = new kurs();
            kurs3.adi = "beridze";
            kurs3.proje = "c++";
            kurs3.izlenme = 1350;

            //Console.WriteLine(kurs1.adi+","+kurs2.adi);

            kurs[] kurslar = new kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.proje+":"+kurs.adi);
            }
            
            Console.ReadLine();
        }
        class kurs
        {
            public string adi { get; set; }
            public string proje { get; set; }
            public int izlenme { get; set; }
        }
        
    }
}
