using Business.Concrete;
using Entities.Concrete;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            SelamVer(isim:"Engin");
            SelamVer(isim:"Ahmet");
            SelamVer(isim:"Yusuf");
            SelamVer();

            int sonuc = Topla(6,58);
            //Diziler /Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Mustafa";
            string ogrenci3 = "Ahmet";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2); 
            //Console.WriteLine(ogrenci3);
            
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Mustafa";
            ogrenciler[2] = "Ahmet";

            ogrenciler = new string[4];
            ogrenciler[3] = "Salih";

            for(int i = 0; i < ogrenciler.Length; i++) 
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            Person person1 = new Person();
            person1.FirstName = "Yusuf";
            person1.LastName = "DOĞAN";
            person1.DateOfBirthYear = 1989;
            person1.NationalIdentity = 12345678910;

            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }


            List<string> yeniSehirler1 = new List<string> {"Ankara1","İstanbul1","İzmir1" };
            yeniSehirler1.Add("Adana1");
            foreach(var sehir in yeniSehirler1)
            { 
                Console.WriteLine(sehir); 
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();

        }
        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1=5, int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;  

            Console.WriteLine("Toplam Değer: " + sonuc);
            return sonuc;
        }
            
    }
}
       


