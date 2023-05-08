using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Kalan Hesaplama İçin Bölünen Sayıyı Giriniz: ");
            int bolunen = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kalan Hesaplmaa İçin Bölen Sayıyı Giriniz:");
            int bolen = Convert.ToInt32(Console.ReadLine());
            int kalan = bolunen % bolen;

            Console.WriteLine("{0} sayısının {1}e'e bölümünden kalan : {2} dir", bolunen, bolen, kalan);

            Console.ReadKey();
        }
    }
}

