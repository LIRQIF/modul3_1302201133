using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var buah = new KodeBuah(Buah.Kurma);
            Console.WriteLine($"Nama Buah\t: {buah.buah}");
            Console.WriteLine($"Kode Buah\t: {buah.getKodeBuah()}");

            var game = new PosisiKarakterGame();
            game.tombolW();
            game.tombolS();
            game.tombolS();
            game.tombolS();
        }
    }
}