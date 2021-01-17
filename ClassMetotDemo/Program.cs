using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Musteri musteri = new Musteri();
                MusteriManager musteriManager = new MusteriManager();
                Console.WriteLine("1-Müşteri Ekle");
                Console.WriteLine("2-Müşteri Listesi");
                Console.WriteLine("3-Müşteri Sil");
                Console.WriteLine("4-Çıkış");
                var secim = Console.ReadLine();
                var sonuc = Convert.ToInt32(secim);


                if (sonuc == 1)
                {
             
                        Console.WriteLine("Müşteri ID : ");
                        var id1 = Console.ReadLine();
                        var id = Convert.ToInt32(id1);
                        Console.WriteLine("Müşteri Adı : ");
                        var ad = Console.ReadLine();
                        Console.WriteLine("Müşteri Soyad : ");
                        var soyad = Console.ReadLine();
                        Console.WriteLine("Müşteri Bakiye : ");
                        var bakiye1 = Console.ReadLine();
                        var bakiye = Convert.ToDouble(bakiye1);

                        musteri.Id = id;
                        musteri.Ad = ad;
                        musteri.Soyad = soyad;
                        musteri.Balance = bakiye;

                        musteriManager.CustomerAdd(musteri);

                   






                }
                else if (sonuc == 2)
                {
                    musteriManager.CustomerList();
                }
                else if (sonuc == 3)
                {
                    Console.WriteLine("Silmek istediğiniz Müşteri ID'si : ");
                    var id1 = Console.ReadLine();
                    var id = Convert.ToInt32(id1);
                    musteriManager.CustomerDelete(id);
                }
                else if (sonuc == 4)
                {
                    Console.WriteLine("Çıkış Yapılıyor");
                    break;

                }
                else
                {
                    Console.WriteLine("Geçersiz İşlem");
                }
            }
           
            
            
                
               
            
        }
        
    }
}
