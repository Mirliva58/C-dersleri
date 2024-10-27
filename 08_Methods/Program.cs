using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar (ders8 başlangıç)
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();
            //------------------------------------------------------------------------

            //void Sum () 
            //{ 
            //int x =1; 
            //int y = 2;
            //int z = x+y;
            //Console.WriteLine(z);
            //}
            //Sum ();
            //------------------------------------------------------------------------


            #endregion
            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(String CustomerName) 
            //{ 
            // Console.WriteLine(CustomerName);
            //}
            //WriteMethod("Ali Yıldırım");
            //------------------------------------------------------------------------

            //void CustomerCard(string name,string Surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + ""+Surname);
            //}
            //CustomerCard("Mehmet" , " Yıldız");
            //CustomerCard("Ayşegül", " Kaya");
            //------------------------------------------------------------------------
            #endregion
            #region Geriye Değer Döndürmeyen İnt Parametreli Metotlar

            //void Sum (int number1, int number2, int number3)
            //{
            //    int result = number1 + number2+number3;
            //    Console.WriteLine(result);
            //}
            //Sum(1, 3, 5);

            #endregion
            #region Geriye Değer Döndüren Metotlar 

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();
            //------------------------------------------------------------------------

            //string StudentCard()
            //{
            //    string name = "ali";
            //    string surname = "kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            //------------------------------------------------------------------------
            #endregion
            #region Geriye Değer Döndüren String Parametreli Metotlar 
            //string CountryCard (string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: "+flagColor;
            //    return cardInfo;
            //}
            //string x, y,z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();
            //Console.WriteLine(CountryCard(x,y,z));
            //Console.WriteLine(CountryCard("Fransa", "Paris", "Mavi-Kırmızı-Beyaz"));
            #endregion
            #region Geriye Değer Döndüren İnt Parametreli Metotlar
            //int Sum (int number1, int number2) 
            //{ 
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(55, 123));
            //Console.WriteLine(Sum(64, 44));
            //----------------------------------------------------------------
            #endregion
            #region Örnek Uygulama (ders8 sonu)

            //string ExamResult (string student, int exam1, int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student+ " Sınavı Geçti"+ " ortalama: "+result;
            //    }
            //    else
            //    {
            //        return student+ " başarısız oldu"+" ortalama: "+result;
            //    }   
            //}
            //    Console.WriteLine(ExamResult("Ali", 45, 61, 51));
            //Console.WriteLine(ExamResult("Mehmet", 33, 21, 77));
            #endregion
        }
    }
}
