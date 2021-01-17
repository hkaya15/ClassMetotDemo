using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public static List<Musteri> musteriListesi = new List<Musteri>();
        
        public void CustomerAdd(Musteri musteri)
        {
            musteriListesi.Add(musteri);
            Console.WriteLine(musteri.Ad+musteri.Soyad+"Eklendi");
            
 

        }

        public void CustomerList()
        {
            Console.WriteLine("Müşteri Listesi");
            foreach (Musteri musteriler in musteriListesi)
            {
                Console.WriteLine(musteriler.Id);
                Console.WriteLine(musteriler.Ad);
                Console.WriteLine(musteriler.Soyad);
                Console.WriteLine(musteriler.Balance);

                Console.WriteLine("********");
            }
        }

        public void CustomerDelete(int Id)
        {
            foreach (var item in musteriListesi)
            {
                if (item.Id == Id)
                {
                    musteriListesi.Remove(item);
                    Console.WriteLine("Müşteri Silindi");
                    break;
                }

            }
            
        }
    }
}
