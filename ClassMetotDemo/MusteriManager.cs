using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
        
    {
       
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(""+musteri.Id+ "  " +" " +musteri.Ad+" "+" "+musteri.Soyad+" "+"  "+musteri.Bakiye  );
        }
        public void Ekle(Musteri musteri)
        {
           
            Console.WriteLine("" + musteri.Id + " " + " " + musteri.Ad + " " + " " + musteri.Soyad + " " + " " + musteri.Bakiye+" "+"KİŞİ EKLENDİ!");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Adı:  " + musteri.Ad + " " + "Soyadı:  " + musteri.Soyad + " " + "Bakiyesi:  " + musteri.Bakiye+" "+"olan kişi silindi!");
        }



    }

}
