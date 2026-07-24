using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakalimm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //console.writeLine ile acıklama yapıyoruz.
            //Ardından String veri tipinde, kullanıcıdan değer almak istiyorum.
            //Alınacak degerın adını secenek olarak belırledım ve Console.ReadLine fonksıyonu ile kullanıcadan degerımı alıyorum.
            Console.WriteLine("Safak sayara hos geldiniz!");
            Console.WriteLine("Askerlik doneminizi seciniz:");
            Console.WriteLine("Bir sene askerlik yapacaksaniz 1'i tuslayiniz.");
            Console.WriteLine("Altı ay askerlik yapacaksaniz 2'yi tuslayiniz.");
            string secenek = Console.ReadLine();


            //İf else yapısını kullanarak kullanıcıdan aldıgım degeri yonlendırıyorum.

            //Kullanıcıdan tekrar bir deger alıp bır yıldan cıkarıyorum.

            if (secenek == "1")
            {
                Console.WriteLine("Yapilan askerlik gunu:");
                int g_sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("kalan askerlik gunu:" + (365 - g_sayi));
                Console.WriteLine("Hayrlı Tezkereler...");
                Console.ReadLine();
            }

            //Kullanıcıdan tekrar bir deger alıp altı aydan cıkarıyorum.

            else if (secenek == "2")

            {
                Console.WriteLine("Yapilan askerlik gunu:");
                int g_sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kalan askerlik gunu:" + (180 - g_sayi1));
                Console.WriteLine("Hayrlı Tezkereler...");
                Console.ReadLine();
            }

            //Son olarak else blokumu kullanarak kullanıcının hatalarını soyluyorum.
            else { Console.WriteLine("Geçerli veya Hatasız tuslama yapiniz."); }
            Console.ReadLine();





        }
    }
}
