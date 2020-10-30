using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2;

            Console.Write("1.sayıyı girin:");
            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("2.sayıyı girin:");
            sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("islem turunu secin:");

            Console.Write("1)Toplama  2)Çıkarma   3)Çarpma   4)Bölme");


            string secenek = Console.ReadLine();

            switch (secenek)
            {
                case "1":
                    Console.WriteLine("İşlemin Sonucu = " + (sayi1 + sayi2));
                    break;
                case "2":
                    Console.WriteLine("İşlemin Sonucu = " + (sayi1 - sayi2));
                    break;
                case "3":
                    Console.WriteLine("İşlemin Sonucu = " + (sayi1 * sayi2));
                    break;
                case "4":
                    Console.WriteLine("İşlemin Sonucu = " + (sayi1 / sayi2));
                    break;

            }


            Console.ReadLine();
        }
    }
}
