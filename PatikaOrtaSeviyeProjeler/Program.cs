using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOrtaSeviyeProjeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AlanveCevreHesaplama();
            //NInteger();
            //MutlakKareAlma();
            //KarakterDegistirme();
            SessizHarf();
            Console.ReadLine();
        }

        private static void SessizHarf()
        {
            Console.Write("Metin Giriniz: ");
            string metin = Console.ReadLine().ToLower();
            string[] metinler = metin.Split(' ');
            string sessiz = ("bcçdfgğhjklmnprsştvyz");
            char[] sessizler = sessiz.ToCharArray();

            foreach (var item in metinler)
            {
                bool sessizMi = false;
                for (int i = 0; i < item.Length - 1; i++)
                {
                    if (sessizler.Contains(item[i]) && sessizler.Contains(item[i + 1]))
                    {
                        sessizMi = true; 
                        break;
                    }
                }
                Console.Write(sessizMi + " ");
            }
        }

        private static void KarakterDegistirme()
        {
            Console.WriteLine("Lütfen bir şeyler yazın: ");
            string input = Console.ReadLine();
            string[] inputWords = input.Split(' ');

            for (int i = 0; i < inputWords.Length; i++)
            {
                string word1 = inputWords[i].Remove(0, 1);

                Console.Write($"{word1}" + $"{inputWords[i][0]}" + " ");
            };
        }

        private static void MutlakKareAlma()
        {
            Console.Write("Lütfen aralarında boşluk bırakarak 'n' adet sayı giriniz: ");
            string[] input = Console.ReadLine().Split(' ');
            int sum = 0;
            int sum2 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (int.Parse(input[i]) < 67)
                {
                    sum += 67 - int.Parse(input[i]);
                }
                else
                {
                    int sub = Math.Abs(67 - int.Parse(input[i]));
                    sum2 += sub * sub;
                }
            }
            Console.WriteLine($"{sum} {sum2}");
        }

        private static void NInteger()
        {
            Console.Write("Lütfen aralarında boşluk bırakarak 'n' adet ikili tamsayı giriniz: ");
            string[] input = Console.ReadLine().Split(' ');
            int sum = 0;

            for (int i = 0; i < input.Length; i += 2)
            {
                int num1 = int.Parse(input[i]);
                int num2 = int.Parse(input[i + 1]);

                sum += num1 + num2;

                if (num1 == num2)
                {
                    Console.Write(sum * sum + " ");
                }
                else
                {
                    Console.Write(sum + " ");
                }
            }

        }

        private static void AlanveCevreHesaplama()
        {
            Console.WriteLine("\t\tAlan-Çevre Hesaplama Programı");
            Console.WriteLine("Lütfen hesaplama yapmak istediğiniz şekli seçiniz:\n1. Daire");
            Console.WriteLine("2. Üçgen\n3. Kare\n4. Dikdörtgen");
            Console.Write("Lütfen seçimi yapınız: ");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                AlanCevre.DaireHesap();
            }
            else if (secim == "2")
            {
                AlanCevre.UcgenHesap();
            }
            else if (secim == "3")
            {
                AlanCevre.KareHesap();
            }
            else if (secim == "4")
            {
                AlanCevre.DikdörtgenHesap();
            }
            else
            {
                Console.WriteLine("Yanlış giriş yaptınız!!!");
            }
        }
    }
}
