using HalkBankCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalkBankListDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new HalkBankList();
            list.Ekle("Salih");
            list.Ekle("Engin");
            list.Ekle("Mustafa");
            list.Ekle("Ahmet");

            list[2] = "Mehmet";

            list.Sil(3);

            Console.WriteLine("Eleman Sayısı:{0}", list.ElemanSayisi);

   
            foreach (var eleman in list)
            {
                Console.WriteLine(eleman);
            }
            list.KosulluSil(isim => isim == "Mehmet");

            foreach (var eleman in list)
            {
                Console.WriteLine(eleman);
            }
            Console.WriteLine("Eleman Sayısı:{0}", list.ElemanSayisi);

            Console.ReadLine();
        }
    }
}
