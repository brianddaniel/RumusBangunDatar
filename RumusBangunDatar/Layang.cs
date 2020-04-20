using System;
using System.Collections.Generic;
using System.Text;

namespace RumusBangunDatar
{
    class layang
    {
        public void lay()
        {
            Console.Write("Masukkan nilai d1: ");
            int d1 = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai d2 : ");
            int d2 = int.Parse(Console.ReadLine());

            double NilaiLayang = (d1 * d2) / 2;
            Console.WriteLine("Luas layang adalah : " + (NilaiLayang));

        }
    }
}