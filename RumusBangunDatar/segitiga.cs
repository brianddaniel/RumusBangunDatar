using System;
using System.Collections.Generic;
using System.Text;

namespace RumusBangunDatar
{
    class segitiga
    {
        public void seg()
        {
            Console.Write("Masukkan nilai alas: ");
            int alas = int.Parse(Console.ReadLine());
            Console.Write("Masukkan nilai tinggi : ");
            int tinggi = int.Parse(Console.ReadLine());

            double NilaiSegitiga = (alas * tinggi) / 2;
            Console.WriteLine("Luas segitiga adalah : " + (NilaiSegitiga));

        }
    }
}