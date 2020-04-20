using System;
using System.Collections.Generic;
using System.Text;

namespace RumusBangunDatar
{
    class lingkaran
    {
        public void lin()
        {
            Console.Write("Masukkan nilai jarijari: ");
            int jarijari = int.Parse(Console.ReadLine());

            double NilaiLingkaran = (jarijari * jarijari) * 3.14;
            Console.WriteLine("Luas lingkaran adalah : " + (NilaiLingkaran));

        }
    }
}