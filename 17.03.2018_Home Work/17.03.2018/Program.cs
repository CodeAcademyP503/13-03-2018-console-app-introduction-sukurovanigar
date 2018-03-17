using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._03._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.  Ekrandan girilen ededin nece reqemli oldugunu ekrana yazdiran proqram yazin
            //Console.WriteLine("EDEDIN REQEMLERININ SAYI UCUN:");
            //Console.Write("Ededi daxil din: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int length = a.ToString().Length;
            //Console.WriteLine(length);
            //===========================================
            //2. Ekrandan girilen ededin reqemleri cemini ekrana yazdiran program yazin:
            //Console.WriteLine("TOPLAMAQ UCUN:");
            //Console.Write("Birinci ededi daxil edin: ");
            //var Birinci = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ikinci ededi daxil edin: ");
            //var Ikinci = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Cavab: " + (Birinci+Ikinci));
            //===============================================
            //===============================================
            //3.Ekrandan daxil olunan ifadenin daxilinde sait ve samitleri ayri ayri ekrana yazdiran program yazin:
            // 1-ci usul: Burada yalniz sait ve samitlerin sayini gosterir.. Bu ise tapsiriqa uygun gelmir.
            //Console.WriteLine("SAITLERE VE SAMITLERE BOLMEK UCUN:");
            //Console.Write("Ifadeni daxil edin: ");
            //int totalSaitler = 0;
            //int totalSamitler = 0;
            //int IfadeCount = 0, index = 0;
            //string Ifade = Console.ReadLine();
            //char[] saitler = { 'a', 'i', 'o', 'u', 'e', 'A', 'E', 'I', 'O', 'U' };
            //char[] samitler = { 'b', 'q', 'v', 'd', 'j', 'z', 'y', 'g', 'c', 'l', 'm', 'n', 'r', 'p', 'k', 'f', 'x', 't', 's', 'h','B', 'Q', 'V', 'D', 'J', 'Z', 'Y', 'G', 'C', 'L', 'M', 'N', 'R', 'P', 'K', 'F', 'X', 'T', 'S', 'H' };

            //for (int i = 0; i < Ifade.Length; i++)
            //{
            //    if (saitler.Contains(Ifade[i]))
            //    {
            //        totalSaitler++;
            //    }
            //    else if (samitler.Contains(Ifade[i]))
            //    {
            //        totalSamitler++;
            //    }

            //}
            //Console.WriteLine("Ifadenizdeki SAITLERin sayi: {0}", totalSaitler);
            //Console.WriteLine("Ifadenizdeki SAMITLERin sayi: {0}", totalSamitler);

            // 2-ci usul: Burada Ifadede sait ve samitlerin hem sayini hem de ayri-ayri sait ve ya samit oldugunu gosterir:
            //Console.WriteLine("SAITLERI VE SAMITLERI TAPMAQ UCUN:");
            //Console.Write("Ifadeni daxil edin: ");
            //int i, Count1 = 0, Count2 = 0;
            //String Ifade;
            //Ifade = Console.ReadLine();
            //for (i = 0; i < Ifade.Length; i++)
            //{
            //    if (Ifade[i] == 'a' || Ifade[i] == 'e' || Ifade[i] == 'i' || Ifade[i] == 'o' || Ifade[i] == 'u' || Ifade[i] == 'A' || Ifade[i] == 'E' || Ifade[i] == 'I' || Ifade[i] == 'O' || Ifade[i] == 'U')
            //    {
            //        ++Count1;
            //        Console.WriteLine(Ifade[i] + " - Saitdir");
            //    }
            //    else
            //    {
            //        ++Count2;
            //        Console.WriteLine(Ifade[i] + " - Samitdir");
            //    }
            //}
            //Console.WriteLine("Butun Samitlerin sayi : " + Count2);
            //Console.WriteLine("Butun Saitlerin sayi : " + Count1);
            //================================================
            // 4. Ekrandan daxil olunan cumlenin sozlerini tek tek ekrana cixaran program yazin:
            //Console.WriteLine("SOZLERINI TEK TEK CIXARSIN DEYE:");
            //Console.Write("Cumleni daxil edin:  ");
            //var cumle = Console.ReadLine();
            //string[] words = cumle.Split(' ');
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}
            //===================================================
            //5.Menim keywords adinda bir listim var:
            //List<string> keywords = new List<string>() { "Tenbel", "Kod yazmayan", "Yola Veren", "Esneyen", "Bekar" }
            //Ekrandan daxil olunan ifadede bu sozlerden her hansi biri kecirse ekranda "Siz losersiniz " deye error vermesini isteyirem.
            //Console.WriteLine(" --Tenbel, Kod yazmayan, Yola Veren, Esneyen, Bekar-- Ifadelerinden istifade etseniz ERROR cixaracaq.. Bunun ucun: ");
            //Error();
            //void Error() { 
            //Console.Write("Ifadenizi ve ya cumlenizi daxil edin: ");
            //List<string> keywords = new List<string>() { "Tenbel", "Kod yazmayan", "Yola Veren", "Esneyen", "Bekar" };
            //var Ifade = Console.ReadLine();
            //if (keywords.Any(Ifade.Contains))
            //{
            //    Console.WriteLine("________________________");
            //    Console.WriteLine("  ");
            //    Console.WriteLine("ERROR: Siz Loosersiniz!!");
            //    Console.WriteLine("________________________");
            //} else
            //{
            //    Console.WriteLine(" Error tapilmadi, Yeniden ceht edin.");
            //    Error(); 
            //}
            //}
            //=======================================================
            // 6. Ekrandan daxil edilen ifade icerisinde "tenbel" sozu varsa eyni ifadeni sadece tenbel sozunun evezine "loser" olaraq deyisdirerek yazdirmasini temin eden program yazin:
            //Console.WriteLine("Tenbel sozunu Looser ile evez etmek ucun:");
            //Console.Write("Ifadeni ve ya cumleni daxil edin: ");
            //var Ifade = Console.ReadLine();
            //if ( Ifade.Any( )) ede bilmedim :((
        }
    }
}