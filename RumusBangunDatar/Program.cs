using System;

namespace RumusBangunDatar
{
    class Program
    {
        static void Main(string[] args)
        {
            persegi a = new persegi();
            segitiga b = new segitiga();
            layang c = new layang();
            lingkaran d = new lingkaran();

            Console.WriteLine("=================================");
            Console.WriteLine(" PROGRAM MENGHITUNG BANGUN DATAR ");
            Console.WriteLine("=================================\n");
            Console.WriteLine("a. Menghitung persegi");
            Console.WriteLine("b. Menghitung segitiga");
            Console.WriteLine("c. Menghitung layang");
            Console.WriteLine("d. Menghitung lingkaran");
            Console.WriteLine(" masukkan pilihan : ");
            char pilih = Char.Parse(Console.ReadLine());


            if (pilih == 'a')
            {
                Console.WriteLine();
                a.per();
            }
            if (pilih == 'b')
            {
                Console.WriteLine();
                b.seg();
            }
            if (pilih == 'c')
            {
                Console.WriteLine();
                c.lay();
            }
            if (pilih == 'd')
            {
                Console.WriteLine();
                d.lin();
            }


            Console.WriteLine("\nprogram selesai - Terima Kasih");

        }
    }
}