using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123;
            musteri1.Ad = "Berna";
            musteri1.Soyad = "özgen";
            musteri1.Bakiye = 10000;
           

            Musteri musteri2 = new Musteri();
            musteri2.Id = 124;
            musteri2.Ad = "melis";
            musteri2.Soyad = "özge";
            musteri2.Bakiye = 1200.12;


            Musteri musteri3 = new Musteri();
            musteri3.Id = 125;
            musteri3.Ad = "melisa";
            musteri3.Soyad = "deniz";
            musteri3.Bakiye= 1250.6;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("kişiler ekleniyor...");
            Console.WriteLine("---------------------------------------------");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("\n");


           
            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3};
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("kişiler listeleniyor...");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine(" Id"+"   "+"Adı"+"   "+"Soyadı"+"   "+"Bakiye");
            Console.WriteLine("---------------------------------------------");

            foreach (Musteri x in musteriler)
            {
                musteriManager.Listele(x);
            }

            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("kişiler siliniyor...");
            Console.WriteLine("---------------------------------------------");
            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.Delete(musteri3);
            
        


    }
    }
}
