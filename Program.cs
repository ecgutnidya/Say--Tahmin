using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıTahmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                OyunuOyna();
                Console.Write("Oyunu tekrar oynamak ister misiniz? (e/h):");
                string cevap = Console.ReadLine();
                if (cevap.ToLower() != "e")
                {
                    break;
                }
            }
        }
        static void OyunuOyna()
        {
            Random rnd = new Random();
            int[] üretilensayi = new int[4];
            for (int i = 0; i < 4; i++)
            {
                int basamak = rnd.Next(1, 10);
                while (!üretilensayi.Contains(basamak))
                {
                    üretilensayi[i] = basamak;
                }
              
            }
            Console.WriteLine(string.Join("", üretilensayi));

            int hak = 10;
            while (hak > 0)
            {
                Console.Write("Tahmininizi girin: ");
                string tahmin = Console.ReadLine();
                if (tahmin.Length != 4)
                {
                    Console.WriteLine("Lütfen 4 basamaklı bir sayı girin.");
                    continue;

                }
                int[] tahminDizisi = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    tahminDizisi[i] = int.Parse(tahmin[i].ToString());
                }
                int dogruSayi = 0;
                int dogruYer = 0;
                int yanlisYer = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (üretilensayi.Contains(tahminDizisi[i]))
                    {
                        dogruSayi++;
                        if (üretilensayi[i] == tahminDizisi[i])
                        {
                            dogruYer++;

                        }
                        else
                        {
                            yanlisYer++;
                        }
                    }
                }
                if (dogruYer == 4)
                {
                    Console.WriteLine("Tebrikler! Sayıyı doğru tahmin ettiniz.");
                    break;
                }
                else
                {
                    if (yanlisYer == 0)
                    {
                        Console.WriteLine(dogruSayi + "tane doğru sayı var ama");
                        Console.WriteLine("hiçbir sayının yerini doğru bilemedinzi");
                    }
                    else
                    {
                        Console.WriteLine("toplam" + " " + dogruSayi + "sayı doğru" + " " + dogruYer + " sayının yeri doğru, " + yanlisYer + " sayı doğru ama yeri yanlış.");
                    }
                    hak--;
                    if (hak == 0)
                    {
                        Console.WriteLine("Üzgünüm, hakkınız bitti. Doğru cevap: " + string.Join("", üretilensayi));


                    }
                    


                }
            }


        }
    }
    }



