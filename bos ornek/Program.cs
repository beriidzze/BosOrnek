using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bos_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sayilar = new string[] {"bir","iki","uc","bes","alti","yedi" };
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.WriteLine("___________________________________________________");
            foreach (string sayi in sayilar) //sayi yerine istedigini yazabilirsin
            {
                Console.WriteLine(sayi);
            }
            Console.ReadLine();
        }
    }
}
