using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switcg_case_uyh
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bakiye = 500;

            Console.WriteLine("Banka Hesabınıza Hos Geldınız");
            Console.WriteLine("Bakiye Görüntülemek İçin 1'i...");
            Console.WriteLine("Bakiye Yüklemek İçin 2'ye...");
            Console.WriteLine("Nakit Para İçin 3'e TIKLAYNIZ");

            string secim = Console.ReadLine();

            switch(secim)

                {   case "1":
                    Console.WriteLine("Güncel Bakiyeniz:"+bakiye);
                    Console.ReadLine();
                    break;

                    case "2":
                    Console.WriteLine("Yüklemek İstediğiniz Miktarı Giriniz:");
                    int ekpara = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Güncel Bakiyeniz:"+(ekpara+bakiye));
                    break;

                    case "3":
                    Console.WriteLine("Çekmek İstediğiniz Miktarı Giriniz");
                    int çekpara = Convert.ToInt32(Console.ReadLine());

                    if(çekpara>bakiye)
                    {
                        Console.WriteLine("O parayı çekmek istiyosan daha cok yatırman lazım fukara KOPEK ");                      
                    }
                    else
                    {
                        Console.WriteLine("Güncel Bakiyeniz:"+(bakiye-çekpara));
                    }
                        break;

                default:
                    Console.WriteLine("Hatali Tuşlama Yaptınız.");
                    break;

            }
        }
    }
}
