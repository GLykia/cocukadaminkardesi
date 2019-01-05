using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS_Training_For_OOP
{
    class Game:Oyuncu
    {
        public int satir;
        public int sutun;
        public static bool bitmedimi=true;
        public static bool kontrol = true;
        public static int kaldı = 0;
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
                        satir = int.Parse(Console.ReadLine());
                        Console.WriteLine("Sütun Giriniz");
                        sutun = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (sira == 1)
                        {
                            if (masa[satir, sutun] == '-')
                            {
                                masa[satir, sutun] = 'X';
                                sira = 2;
                                OyunSonuKontrol();
                            }
                        }
                        else if (sira == 2)
                        {

                            if (masa[satir, sutun] == '-')
                            {
                                masa[satir, sutun] = '0';
                                sira = 1;
                                OyunSonuKontrol();
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
            if (kaldı == 8)
            {
                Console.WriteLine("Berabere Kaldınız");
                Console.WriteLine("Tekrar Oynamak istiyonmu");
                ConsoleKeyInfo cki = Console.ReadKey();
                if (cki.Key==ConsoleKey.E)
                {
                    bitmedimi = true;
                    kaldı = 0;
                    masaac();
                }
                else
                {
                    bitmedimi = false;
                    kontrol = false;
                }
                
            }
            else
            {
                kaldı++;
            }
            return bitmedimi;
        }
    }
}
