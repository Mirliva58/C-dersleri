using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region temel diziler (ders6 başlangıç)
            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "mavi";
            //colors[2] = "yeşil";
            //colors[3] = "turuncu";
            //Console.WriteLine(colors[2]);
            //string[] cities = new string[5];
            //cities[0] = "milano";
            //cities[1] = "budapeşte";
            //cities[2] = "lyon";
            //cities[3] = "kahire";
            //cities[4] = "üsküp";
            //Console.WriteLine(cities[3]);
            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[9] = 5;
            //Console.WriteLine(numbers[7]);
            #endregion
            #region dizideki tüm elemanları listeleme
            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //int[] numbers = { 1, 5, 96, 75, 126, 635, 488, 520, 7456, 2367, 1120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //char[] symbols = { 'A', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}
            //int[] myArray = { 47, 86, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);
            //------------------------------------------------------------------------

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion
            #region dizi metotları
            //string[] costumers = { "ali", "buse", "ayşegül", "merve", "kaya", "çınar" };
            //int index = Array.IndexOf(costumers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 9, 63, 74, 25, 22, 36 };
            //Console.WriteLine("dizinin en büyük elemanı: "+ numbers.Max()+ "dizinin en küçük elemanı: "+numbers.Min());


            #endregion
            #region kullanıcıdan değer alma (ders6 sonu)
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"lütfen {i + 1}. şehrini giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            //------------------------------------------------------------------------

            //int[] numbers = {10,20,30,40,50};
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);
            //------------------------------------------------------------------------

            //int[] numbers = { 21,42,33,54,55,66,897,748,39,220};
            //Console.WriteLine("Çift sayılar: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //    Console.WriteLine();
            //    Console.WriteLine("Tek sayılar:");

            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if (numbers[i] % 2 == 1)
            //            Console.WriteLine(numbers[i]);
            //    }
            #endregion
        }
    }
}
