using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOrtaSeviyeProjeler
{
    class AlanCevre
    {
        public static void DaireHesap()
        {
            Console.WriteLine("Neyi hesaplamak istersin;\n1. Alan\n2. Çevre");
            string secim = Console.ReadLine();
            double alan = 0;
            double cevre = 0;

            if (secim == "1")
            {
                Console.Write("Alan hesaplamak için dairenin yarıçapını yazınız: ");
                double yarıcap = double.Parse(Console.ReadLine());
                alan = Math.PI * (yarıcap * yarıcap);
                Console.WriteLine($"Dairenin alanı ==> {alan}");
            }
            else if (secim == "2")
            {
                Console.Write("Çevre hesaplamak için dairenin yarıçapını yazınız: ");
                double yarıcap = double.Parse(Console.ReadLine());
                cevre = 2 * Math.PI * yarıcap;
                Console.WriteLine($"Dairenin cevresi ==> {cevre}");
            }
        }
        public static void UcgenHesap()
        {
            Console.WriteLine("Neyi hesaplamak istersin;\n1. Alan\n2. Çevre");
            string secim = Console.ReadLine();
            double alan = 0;
            int cevre = 0;

            if (secim == "1")
            {
                Console.Write("Alan hesaplamak için üçgenin yüksekliğini yazınız: ");
                double yukseklik = double.Parse(Console.ReadLine());
                Console.Write("Üçgenin uzunluğunu yazınız: ");
                double uzunluk = double.Parse(Console.ReadLine());
                alan = (uzunluk * yukseklik) / 2;
                Console.WriteLine($"Üçgenin alanı ==> {alan}");
            }
            else if (secim == "2")
            {
                Console.Write("Çevre hesaplamak için üçgenin kenar uzunluklarını yazınız: ");
                int kenar1 = int.Parse(Console.ReadLine());
                int kenar2 = int.Parse(Console.ReadLine());
                int kenar3 = int.Parse(Console.ReadLine());
                cevre = kenar1 + kenar2 + kenar3;
                Console.WriteLine($"Üçgenin cevresi ==> {cevre}");
            }
        }
        public static void KareHesap()
        {
            Console.WriteLine("Neyi hesaplamak istersin;\n1. Alan\n2. Çevre");
            string secim = Console.ReadLine();
            double alan = 0;
            int cevre = 0;

            if (secim == "1")
            {
                Console.Write("Alan hesaplamak için karenin bir kenar uzunluğunu yazınız: ");
                double uzunluk = double.Parse(Console.ReadLine());
                alan = uzunluk * uzunluk;
                Console.WriteLine($"Karenin alanı ==> {alan}");
            }
            else if (secim == "2")
            {
                Console.Write("Çevre hesaplamak için karenin kenar uzunluklarını yazınız: ");
                int uzunluk = int.Parse(Console.ReadLine());
                cevre = uzunluk * 4;
                Console.WriteLine($"Karenin cevresi ==> {cevre}");
            }
        }
        public static void DikdörtgenHesap()
        {
            Console.WriteLine("Neyi hesaplamak istersin;\n1. Alan\n2. Çevre");
            string secim = Console.ReadLine();
            double alan = 0;
            int cevre = 0;

            if (secim == "1")
            {
                Console.Write("Alan hesaplamak için dikdörtgenin geniş kenarı yazınız: ");
                int yukseklik = int.Parse(Console.ReadLine());
                Console.Write("Uzun kenar: ");
                int uzunluk = int.Parse(Console.ReadLine());
                alan = yukseklik * uzunluk;
                Console.WriteLine($"Dikdörtgenin alanı ==> {alan}");
            }
            else if (secim == "2")
            {
                Console.Write("Alan hesaplamak için dikdörtgenin geniş kenarı yazınız: ");
                int yukseklik = int.Parse(Console.ReadLine());
                Console.Write("Uzun kenar: ");
                int uzunluk = int.Parse(Console.ReadLine());
                cevre = (yukseklik * 2) * (uzunluk * 2);
                Console.WriteLine($"Dikdörtgenin cevresi ==> {cevre}");
            }
        }
    }
}
