using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk Notu Giriniz:");
            int birinci = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Notu Giriniz:");
            int ikinci = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Üçüncü Notu Giriniz:");
            int üçünçü = Convert.ToInt32(Console.ReadLine());

            int sonuc = (birinci + ikinci + üçünçü) / 3;

            Console.WriteLine("\n");

            Console.WriteLine("Öğrencinin ortalaması: " + sonuc);

            Console.WriteLine("\n");

            if (sonuc >= 0 && sonuc<=100)
            {


                if (sonuc >= 80 && sonuc <= 100)
                { Console.WriteLine("Öğrencinin notu A"); }

                else if (sonuc >= 60 && sonuc < 80)
                { Console.WriteLine("Öğrencinin notu B"); }

                else if (sonuc >= 40 && sonuc < 60)
                { Console.WriteLine("Öğrencinin notu C"); }

                else
                { Console.WriteLine("Öğrencinin Notu D"); }

                Console.ReadLine();
            }

            else { Console.WriteLine( "Öğrencinin Notu Belirlenemedi Dogru veya Hatasız Not Girisi Yapiniz."  ); }
            Console.ReadLine(); 
           
    }
    }
}
