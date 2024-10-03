using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double_Değişkenler
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);


            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("---- elma birim fiyati: " + applePrice +"TL");
            //Console.WriteLine("---- portakal birim fiyati: " + orangePrice + "TL");
            //Console.WriteLine("---- çilek birim fiyati: " + strawberryPrice + "TL");
            //Console.WriteLine("---- patates birim fiyati: " + potatoPrice + "TL");
            //Console.WriteLine("---- domates birim fiyati: " + tomatoPrice + "TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;
            //Console.WriteLine();

            //Console.WriteLine("---- elma için ödemeniz gereken fiyat: " + appleTotalPrice + "TL");
            //Console.WriteLine("---- portakal için ödemeniz gereken fiyat: " + orangeTotalPrice + "TL");
            //Console.WriteLine("---- çilek için ödemeniz gereken fiyat: " + strawberryTotalPrice + "TL");
            //Console.WriteLine("---- patates için ödemeniz gereken fiyat: " + potatoTotalPrice + "TL");
            //Console.WriteLine("---- domates için ödemeniz gereken fiyat: " + tomatoTotalPrice + "TL");
            //double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine("toplam ödemeniz gereken tutar: " + totalPrice + "TL");

            #endregion

            #region  Char_Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);




            #endregion

            #region klavyeden veri girişleri string değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string customerName;
            //string customerSurname;
            //string customerDistrict;
            //string customerCity;
            //string customerAge;
            //string customerIdentityNumber;

            //Console.Write("yolcu adı: ");

            //customerName = Console.ReadLine();

            //Console.Write("yolcu soyadı: ");

            //customerSurname = Console.ReadLine();

            //Console.Write("ilçe bilgisi: ");
            //customerDistrict = Console.ReadLine();

            //Console.Write("şehir bilgisi: ");
            //customerCity = Console.ReadLine();

            //Console.Write("yolcu yaş bilgisi: ");
            //customerAge = Console.ReadLine();

            //Console.Write("yolcu TC: ");
            //customerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("---------------------------");
            //Console.WriteLine("yolcu TC: " + customerIdentityNumber +" " + "yolcu: " + customerName + " " + customerSurname + " " + customerDistrict + " " + customerCity + " " + customerAge);




            #endregion

            #region klavyeden  tam sayı girişleri ve dönüşümleri

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount =int.Parse( Console.ReadLine());

            //Console.Write("lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount =int.Parse( Console.ReadLine());

            //Console.Write("lütfen aldığınız koltuk sayısını giriniz: ");
            //chairCount =int.Parse( Console.ReadLine());

            //Console.Write("lütfen aldığınız tv sayısını giriniz: ");
            //tvCount =int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;
            //Console.WriteLine();
            //Console.WriteLine("alışverişiniz toplam fiyatı: "+totalPrice+" TL");








            #endregion

            #region klavyeden ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("lütfen 1. sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("lütfen 3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("sınav ortalamanız: " + result);


            #endregion

            #region klavyeden karakter girişleri

            //char gender;

            //Console.Write("lütfen cinsiyet giriniz: ");
            //gender =char.Parse(Console.ReadLine());


            //Console.WriteLine("seçtiğiniz cinsiyet: "+gender);


            #endregion

            Console.Read();

        }
    }
}
