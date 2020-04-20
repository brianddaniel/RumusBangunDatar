using System;
using System.Collections.Generic;
using System.Text;

namespace RumusBangunDatar
{
    class persegi
    {
        public void per()
        {
            Console.Write("Masukkan panjang: ");
            int panjang = int.Parse(Console.ReadLine());
            Console.Write("Masukkan lebar : ");
            int lebar = int.Parse(Console.ReadLine());

            double NilaiPersegi = panjang * lebar;
            Console.WriteLine("luas persegi adalah : " + (NilaiPersegi));

        }
    }
}