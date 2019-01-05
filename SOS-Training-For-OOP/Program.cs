using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SOS_Training_For_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu o1 = new Oyuncu();
            Oyuncu o2 = new Oyuncu();
            Game g = new Game();
            g.Oyna();
        }
    }
}
