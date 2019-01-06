using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS_Training_For_OOP
{
    class Game:Oyuncu
    {
        public byte satir;
        public byte sutun;
        public static bool bitmedimi=true;
        public static bool kontrol = true;
        public static int kaldi = 0;
        //public char[,] masa =
        //{
        //    {'-','-','-'},
        //    {'-','-','-'},
        //    {'-','-','-'}
        //};
        public static char[,] masa = new char[3, 3];
        public void masaac()
        {
            for (int i = 0; i < masa.GetLength(0); i++)
            {
                for (int j = 0; j < masa.GetLength(1); j++)
                {
                    masa[i, j] = '-';
                }
            }
        }
        public int sira=1;
        public void EkraniGuncelle()
        {
            for (int i = 0; i < masa.GetLength(0); i++)
            {
                for (int j = 0; j < masa.GetLength(1); j++)
                {
                    Console.Write(masa[i,j]);
                }
                Console.WriteLine();
            }
        }
        public void Oyna()
        {
            masaac();
            while (bitmedimi)
            {
                OyuncuKayıt();
                do
                {
                    if (sira == 1)
                        Console.WriteLine("{0} adlı oyuncunun sırası", ad1);
                    else
                        Console.WriteLine("{0} adlı oyuncunun sırası", ad2);

                    try
                    {
                        Console.WriteLine("Satir Giriniz");
                        satir = Convert.ToByte(Console.ReadKey().KeyChar.ToString());
                        Console.WriteLine();
                        Console.WriteLine("Sütun Giriniz");
                        sutun = Convert.ToByte(Console.ReadKey().KeyChar.ToString());
                        Console.Clear();
                        if (sira == 1)
                        {
                            if (masa[satir, sutun] == '-')
                            {
                                masa[satir, sutun] = secim1;
                                OyunSonuKontrol();
                                sira = 2;
                            }
                        }
                        else if (sira == 2)
                        {

                            if (masa[satir, sutun] == '-')
                            {
                                masa[satir, sutun] = secim2;
                                OyunSonuKontrol();
                                sira = 1;
                            }
                        }
                        EkraniGuncelle();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.Clear();
                        EkraniGuncelle();
                        Console.WriteLine("Kardeşim 0-2 arası değer girmelisin. Ağzını yüzünü öperler.");

                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        EkraniGuncelle();
                        Console.WriteLine("Yapamazsın kardeşim");
                    }
                } while (kontrol);
            }
        }
        public bool OyunSonuKontrol()
        {
            if (kaldi == 8)
            {
                Console.WriteLine("Berabere Kaldınız");
                Console.WriteLine("Tekrar Oynamak istiyonmu");
                ConsoleKeyInfo cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.E)
                {
                    bitmedimi = true;
                    kaldi = 0;
                    masaac();
                }

                else
                {
                    bitmedimi = false;
                    kontrol = false;
                }

            }
            else if ((masa[0, 0] == masa[0, 1] && masa[0, 0] == masa[0, 2]) || (masa[0, 0] == masa[1, 0] && masa[0, 0] == masa[2, 0]) || (masa[0, 1] == masa[1, 1] && masa[0, 1] == masa[2, 1]) || (masa[0,2] == masa[1,2] && masa[0, 2] == masa[2, 2]))
            {
                if (sira==1)
                {
                    Console.WriteLine("{0}. Oyuncu kazandı", ad1);
                }
                else
                {
                    Console.WriteLine("{0}. Oyuncu kazandı", ad2);
                }
            }
            else
            {
                kaldi++;
            }
            return bitmedimi;
        }
    }
}
