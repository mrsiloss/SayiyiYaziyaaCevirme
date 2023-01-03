using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıyıYazıyaCevirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 0, sonuc1 = 0;
            short x;
            string s = "";
            string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] Yüzler = { "Yüz", "İkiyüz", "Üçyüz", "Dörtyüz", "Beşyüz", "Altıyüz", "Yediyüz", "Sekizyüz", "Dokuzyüz" };
            Console.Write("Bir sayı giriniz: ");
            x = short.Parse(Console.ReadLine());
            if (x / 100 >= 1)
            {
                s = Yüzler[(x / 100) - 1];
            }
            sonuc = (x / 100);
            sonuc = sonuc * 100;
            sonuc1 = x - sonuc;

            if (sonuc1 / 10 >= 1)
            {
                s = s + Onlar[(sonuc1 / 10) - 1];
            }
            if (sonuc1 % 10 != 0)
            {
                s = s + Birler[(sonuc1 % 10) - 1];
            }
            Console.WriteLine(s);
            Console.ReadKey(true);
        }
    }
}
