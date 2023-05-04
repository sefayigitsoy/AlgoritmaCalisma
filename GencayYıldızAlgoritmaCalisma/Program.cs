using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GencayYıldızAlgoritmaCalisma
{
    internal class Program
    {

        // Kullanıcıdan Alinan 2 Sayinin Toplami
        static void Main(string[] args)
        {
            #region Kullanıcıdan Alinan 2 Sayinin Toplami
            //try
            //{
            //    int sayi1, sayi2;
            //    Console.WriteLine("Sayi1 Giriniz");
            //    sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Sayi2 Giriniz");
            //    sayi2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi1 + sayi2);
            //    Console.ReadLine();
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Lütfen Sayi Giriniz");
            //    Console.ReadLine();
            //}

            #endregion

            #region Kullanıcıdan alınan 2 sayinin karesi toplami
            //try
            //{
            //    int sayi1, sayi2;
            //    Console.WriteLine("Sayi 1 Giriniz");
            //    sayi1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Sayi2 Giriniz");
            //    sayi2 = int.Parse(Console.ReadLine());
            //    int sayi1karesi = sayi1 * sayi1;
            //    int sayi2karesi = (sayi2 * sayi2);
            //    Console.WriteLine("Girilen Sayilarin Kareleri Toplami = " + (sayi1karesi + sayi2karesi));
            //    Console.ReadLine();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Geçerli Değerler Giriniz");
            //    Console.ReadLine() ;
            //}
            #region Answer2
            //try
            //{
            //    int sayi1, sayi2;
            //    Console.WriteLine("Sayi 1 Giriniz");
            //    sayi1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Sayi2 Giriniz");
            //    sayi2 = int.Parse(Console.ReadLine());
            //    double sonuc = Math.Pow(sayi1, 2) + Math.Pow(sayi2, 2);
            //    Console.WriteLine("Sonuc = " + sonuc);
            //    Console.ReadLine();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Geçerli Değerler Giriniz");
            //    Console.ReadLine();
            //}
            #endregion
            #region Answer3 TekSatirda
            //Console.WriteLine("Birinci ve İkinci Sayiyi Giriniz");
            //Console.WriteLine("Sonuc= "+ (Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2)));
            //Console.ReadLine();
            #endregion
            #endregion

            #region 1'den 10a kadar olan sayilarin küplerinin toplami
            #region for Döngüsü ile
            //double toplamSonuc = 0;
            //for (int j = 1; j < 11; j++)
            //{
            //    toplamSonuc += Math.Pow(j, 3);
            //    Console.WriteLine(toplamSonuc);
            //}
            //Console.WriteLine("Toplam= " + toplamSonuc);
            //Console.ReadLine();
            #endregion
            #region while Döngüsü ile
            //double i = 0;
            //double toplam = 0;
            //while (i<10) { i++; toplam += Math.Pow(i, 3); }
            //Console.WriteLine(toplam);  
            //Console.ReadLine();
            #endregion
            #region Do-While Döngüsü ile
            //int sayac = 0;
            //double toplamSonuc = 0;
            //do
            //{
            //    sayac++;
            //    toplamSonuc += Math.Pow(sayac, 3);

            //} while (sayac<10);
            //Console.WriteLine(toplamSonuc);
            //Console.ReadLine();
            #endregion
            #endregion

            #region DogumTarihhiGirilenKisininYasHesabi
            //Console.WriteLine("Doğum Tarihinizi Giriniz...");
            //DateTime DogumTarihi = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine((DateTime.Now - DogumTarihi).Days / 365);
            //Console.ReadLine();
            #endregion
            #region Answer 2
            //Console.WriteLine("Lütfen doğum tarihinizi giriniz.");
            //DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
            //DateTime bugun = DateTime.Now;
            //int yas = bugun.Year - dogumTarihi.Year;
            //if (dogumTarihi > bugun.AddYears(-yas))
            //    yas--;
            //Console.WriteLine(yas);
            //Console.ReadLine();
            #endregion
            #region Answer 3
            //Console.WriteLine("Lütfen doğum tarihi giriniz.");
            //DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
            //int gun=(DateTime.Now-dogumTarihi).Days;
            //int yas=gun / 365;
            //int kalan=gun % 365;
            //Console.WriteLine($"Yas: {yas} | {yas + 1} yaşınıza kalan gün sayısı : {365+ (yas * 1/4) - kalan}");
            //Console.ReadLine();
            #endregion

            #region GirilenSayininFaktöriyeliniHesapla
            //try
            //{
            //    Console.WriteLine("Lütfen bir sayı giriniz.");
            //    int sayi = int.Parse(Console.ReadLine());
            //    int sonuc = 1;
            //    for (int i = sayi; i > 0; i--)
            //    {
            //        sonuc *= i;
            //    }
            //    Console.WriteLine(sonuc);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Sayi Giriniz");
            //}
            //Console.ReadLine();
            #endregion
            #region Answer2
            //Console.WriteLine("Lütfen bir sayı giriniz.");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc=1;
            //while (sayi>0)
            //{
            //    sonuc *= sayi;
            //    sayi--;
            //}
            //Console.WriteLine(sonuc);
            //Console.ReadLine() ;
            #endregion

            #region PozitifSayilardaCarpmaIsleminiToplamaylaBul
            #region WhileIle
            //int sayi1, sayi2;
            //int sonuc = 0;
            //int sayac = 0;
            //Console.WriteLine("1. Sayiyi Giiriniz");
            //sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2. Sayiyi Giriniz");
            //sayi2 = int.Parse(Console.ReadLine());
            //while (sayac < sayi2) { sayac++; sonuc += sayi1; }
            //Console.WriteLine(sonuc);
            //Console.Read();
            #endregion
            #region ForIle
            //Console.WriteLine("Lütfen birinci sayıyı giriniz.");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int carpmaSonucu = 0;
            //for (int i = 0; i < sayi1; i++)
            //{
            //    carpmaSonucu += sayi2;
            //}
            //Console.WriteLine(carpmaSonucu);
            //Console.Read();
            #endregion
            #region DoWhileIle
            //Console.WriteLine("Lütfen birinci sayıyı giriniz.");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int carpmaSonucu = 0;
            //int sayac = 0;
            //do
            //{
            //    sayac++;
            //    carpmaSonucu += sayi1;
            //} while (sayac<sayi2);
            //Console.WriteLine(carpmaSonucu);
            //Console.ReadLine();
            #endregion
            #region Answer4
            //Console.WriteLine("1. Sayiyi Giiriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2. Sayiyi Giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(Topla(sayi1,sayi2));
            //Console.ReadLine();
            #endregion
            #endregion
            #region PozitifSayilardaBölmeIsleminiCikarmaileBul
            //Console.WriteLine("Lütfen  sayı giriniz.");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bölen sayıyı giriniz.");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Bol(sayi1, sayi2));
            //Console.ReadLine();

            #endregion
            #region GirilenPozitifSayiniinKacBasamakliOldugunuSöyleyenUygulamayiYaziniz
            //Console.WriteLine("Sayi Girini:");
            //int sayi=int.Parse(Console.ReadLine());
            //int sayac=0;
            //for(; sayi>=10;)
            //{
            //    sayi/=10;
            //    sayac++;
            //}
            //Console.WriteLine(sayac+1);
            //Console.ReadLine();
            #endregion
        }

        static int Topla(int sayi1, int sayi2)
        {
            if (sayi2 > 1)
                return sayi1 + (Topla(sayi1, --sayi2));
            return sayi1;
            // Bir fonksiyon buradaki gibi kendi içerisinde kendini tekrar çağırıyorsa Recursive Fonksiyon denir.
        }

        static int Bol(int sayi1, int sayi2)
        {
            sayi1 -=sayi2;
            if (sayi1 >= sayi2)
                return 1 + Bol(sayi1, sayi2);
            return 1;
        }


    }
}
