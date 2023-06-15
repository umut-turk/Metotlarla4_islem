using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("toplama icin 1  cıkarma icin 2  carpma icin 3  bolme icin 4 e basin");
            string secim = Console.ReadLine();
            int secim2 = Convert.ToInt32(secim);





            if (secim2 == 1)
            {
                Console.WriteLine("1. sayıyı  gırın");
                string sayı1 = Console.ReadLine();
                int sayı2 = Convert.ToInt32(sayı1);

                Console.WriteLine("2. sayıyı  gırın");
                string sayı3 = Console.ReadLine();
                int sayı4 = Convert.ToInt32(sayı3);
                topla(sayı2, sayı4);
            }




            else if (secim2 == 2)
            {
                Console.WriteLine("1. sayıyı  gırın");
                string sayı1 = Console.ReadLine();
                int sayı2 = Convert.ToInt32(sayı1);

                Console.WriteLine("2. sayıyı  gırın");
                string sayı3 = Console.ReadLine();
                int sayı4 = Convert.ToInt32(sayı3);
                cikarma(sayı2, sayı4);
            }




            else if (secim2 == 3)
            {
                Console.WriteLine("1. sayıyı  gırın");
                string sayı1 = Console.ReadLine();
                int sayı2 = Convert.ToInt32(sayı1);

                Console.WriteLine("2. sayıyı  gırın");
                string sayı3 = Console.ReadLine();
                int sayı4 = Convert.ToInt32(sayı3);
                carpma(sayı2, sayı4);
            }


            else if (secim2 == 4)
            {
                Console.WriteLine("1. sayıyı  gırın");
                string sayı1 = Console.ReadLine();
                int sayı2 = Convert.ToInt32(sayı1);

                Console.WriteLine("2. sayıyı  gırın");
                string sayı3 = Console.ReadLine();
                int sayı4 = Convert.ToInt32(sayı3);
                bolme(sayı2, sayı4);
            }
            else
            {
                Console.WriteLine("yanliş  işlem");
            }
            Console.ReadLine();
        }







        static void topla(int sayi1, int sayı2)
        {
            int sonuc = sayi1 + sayı2;
            Console.WriteLine("toplam" + " " + sonuc);
        }
        static void cikarma(int sayı1, int sayı2)
        {
            int sonuc = sayı1 - sayı2;
            Console.WriteLine("Sonuc=" + " " + sonuc);
        }

        static void carpma(int sayı1, int sayı2)
        {
            int sonuc = sayı1 * sayı2;
            Console.WriteLine("Sonuc=" + " " + sonuc);
        }

        static void bolme(int sayı1, int sayı2)
        {
            int sonuc = sayı1 / sayı2;
            Console.WriteLine("Sonuc=" + " " + sonuc);
        }
    }

}

