using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS_Training_For_OOP
{
    class Oyuncu
    {
        public string ad1;
        public static char secim1;
        public byte puan1;
        public string ad2;
        public static char secim2;
        public byte puan2;

        public void OyuncuKayıt()
        {
            Console.WriteLine("1.Oyunucu Adınızı Giriniz");
            ad1 = Console.ReadLine();
                try
                {
                    Console.WriteLine("X/O tarafınızı seçiniz");
                    secim1 = char.Parse(Console.ReadLine().ToUpper());
                }
                catch (FormatException)
                {

                    Console.WriteLine("X yada O girin");
                }
                
            
            Console.WriteLine("2.Oyuncu Adınızı Giriniz");
            ad2 = Console.ReadLine();
            if (secim1 == 'X')
                secim2 = 'O';
            else
                secim2 = 'O';
            Console.Clear();
        }
    }
}
