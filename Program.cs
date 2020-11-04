using System;

namespace Tugas1
{
    class Program
    {
        static void Main(string[] args)
        {
            About cNama = new About();

            Console.WriteLine("NPM"     +" : "+ cNama.NPM);
            Console.WriteLine("Nama"    +" : "+ cNama.Nama);
            Console.WriteLine("Tugas"   +" : "+ cNama.Tugas);
            Console.WriteLine("Tanggal" +" : "+ cNama.Tanggal);
            Console.WriteLine("----------------------------"); 
            Console.WriteLine("----------------------------"); 

            Kucing cKucing = new Kucing();
            Singa cSinga = new Singa();
            Sapi cSapi  = new Sapi();

            Console.WriteLine("Singa Dapat" + " " + cSinga.Roar); 

            Console.WriteLine("----------------------------"); 

            Console.WriteLine("Kucing Mempunyai" + " " + cKucing.Cakar);
            Console.WriteLine("dan");
            cKucing.TulangBelakang();

            Console.WriteLine("----------------------------"); 

            Console.WriteLine("Sapi Mempunyai" + " " + cSapi.Kulit);
            Console.WriteLine("dan");
            cSapi.Menyusui();
        }
    }
}
