using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler;
            isimler = new string[4];
            isimler[0] = "Ali";
            isimler[1] = "Veli";
            isimler[2] = "Ayşe";
            isimler[3] = "Ayla";

            int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            
          
            Array.Clear(rakamlar, 8,2);

            for (int i = 0; i < rakamlar.Length; i++)
            {
                Console.WriteLine(rakamlar[i]);
            }
            //sıralama komutu
            Array.Sort(isimler);

            //ters çevirme
            Array.Reverse(isimler);
            foreach (string eleman in isimler)
            {
                Console.WriteLine(eleman);
            }

           int sira = Array.IndexOf(isimler, "Ayla");
            Console.WriteLine("Ayla ismi, listenin {0}. indexindedir.", sira);

            int sonSira = Array.LastIndexOf(rakamlar, 0);
            Console.WriteLine("Listedeki son 0 sayısı {0}. indextedir.", sonSira);

            Console.ReadKey();

        }
    }
}
