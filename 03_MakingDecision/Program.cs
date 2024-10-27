using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else (ders3 başlangıç)
            //Console.Write("lütfen şifreyi giriniz:  ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("şifre doğru!");

            //}
            //else
            //{
            //    Console.WriteLine("şifre yanlış!");
            //}

            //string capital, country;
            //Console.WriteLine("Başkenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.WriteLine("Ülkeyi giriniz:  ");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country == "türkiye") 
            //{
            //    Console.WriteLine("bilgiler doğru! ");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}

            //int exam1, exam2, exam3, average;

            //Console.WriteLine("sınav1 : ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("sınav2 : ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("sınav3 : ");
            //exam3 = int.Parse(Console.ReadLine());
            //average = (exam1 + exam2 + exam3)/3;
            //Console.WriteLine("sınavların ortalaması: " + average);
            //string result = "hata";
            //if (average > 0 & average <= 50)
            //{
            //    result = ("sonuç vasat");
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = ("sonuç orta");
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = ("sonuç iyi");
            //}
            //if (average > 84)
            //{
            //    result = ("sonuç çok iyi");
            //}
            //Console.WriteLine(result);
            //------------------------------------------------------------------------

            //string city;
            //Console.WriteLine("lütfen şehir giriniz: ");
            //city = Console.ReadLine();
            //if (city == "adana" | city == "bursa" | city == "sivas")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil!");
            //}
            #endregion
            #region mod işlemleri
            //Console.WriteLine("bir sayı giriniz: ");
            //int number;
            //number = int.Parse(Console.ReadLine());
            //int result = number %5 ;
            //Console.WriteLine("girilen sayının mod 5'i : ");
            //Console.WriteLine(result);

            #endregion
            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'g' | team == 'G')
            //{ Console.Write("Galatasaray");}
            //if (team == 'f' | team == 'F')
            //{Console.Write("Fenerbahçe");}
            //if (team == 'b' | team == 'B')
            //{Console.Write("Beşiktaş");}
            #endregion
            #region Örnek Proje Uygulaması
            //Console.WriteLine(" ***** C# Eğitim Kampı Restoran ***** ");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğiniz menüyü seçin: ");
            //menuItem = Console.ReadLine();
            //if ( menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--Ana Yemekler ----------- ");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine(" ------------ Ana Yemekler ------------ ");
            //    Console.WriteLine(); }
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------- Çorbalar ----------- ");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorba");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine("----------- Çorbalar ----------- ");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------- Pizzalar ----------- ");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("----------- Pizzalar ----------- ");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------- İçecekler ----------- ");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Kola");
            //    Console.WriteLine("----------- İçecekler ----------- ");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------- Tatlılar ----------- ");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Baklava");
            //    Console.WriteLine("3-Künefe");
            //    Console.WriteLine("----------- Tatlılar ----------- ");
            //    Console.WriteLine();
            //}
            #endregion
            #region Switch Case
            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber) 
            //{ 
            //case 1: Console.Write("Ocak"); break;
            //case 2: Console.Write("Şubat"); break;
            //case 3: Console.Write("Mart"); break;
            //case 4: Console.Write("Nisan"); break;
            //case 5: Console.Write("Mayıs"); break;
            //case 6: Console.Write("Haziran"); break;
            //case 7: Console.Write("Temmuz"); break;
            //case 8: Console.Write("Ağustos"); break;
            //case 9: Console.Write("Eylül"); break;
            //case 10: Console.Write("Ekim"); break;
            //case 11: Console.Write("Kasım"); break;
            //case 12: Console.Write("Aralık"); break;
            //default: Console.Write("Hatalı veri girişi");break;
            //}

            #endregion
            #region Switch Case Hesap Makinesi (ders3 sonu)
            //int number1, number2, result;
            //char symbol;
            //Console.Write("1. Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());
            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("toplam: "+result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("bölüm: " + result);
            //        break;
            //}
            #endregion
        }
    }
}
