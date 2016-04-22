using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Çapraz_Yazı_Yazdırma_v2._0_Corona
{
    class Program
    {
        static void Main(string[] args)
        {

            string kelime;
            int adet;

            Console.Write("Yazılmasını istediğiniz kelimeyi yazınız:");
            kelime = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Kaç Kere Yazılmasını İstiyorsunuz:");
            adet = int.Parse(Console.ReadLine());


            for (int i = 1; i <= adet; i++)
            {
                Console.WriteLine("{0," + (i + kelime.Length - 1) + "}", kelime);
            }
            Console.ReadKey();

        }
    }
}
