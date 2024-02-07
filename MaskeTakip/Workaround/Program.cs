using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas = new Vatandas();

            SelamVer(isim: "Ali");
            SelamVer(isim: "Aslı");
            SelamVer(isim: "Akif");
            SelamVer();
            int sonuc = Topla(9, 17);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Ali";
            ogrenciler[1] = "Ayşe";
            ogrenciler[2] = "Fatma";

            ogrenciler = new string[4];
            ogrenciler[3] = "Nursima";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Bayburt", "Ankara", "İstanbul" };
            string[] sehirler2 = new[] { "Trabzon", "Gümüşhane", "Erzurum" };

            sehirler2 = sehirler1;
            sehirler1[0] = "İzmir";
            Console.WriteLine(sehirler2[0]);


            Person person1 = new Person();
            person1.FirstName = "Ahmet";
            person1.LastName = "Kaya";
            person1.DateOfBirthYear = 2005;
            person1.NationalIdentity =923572349562;

            Person person2 = new Person();
            person2.FirstName = "Nursima";

            foreach (string s in sehirler1)
            {
                Console.WriteLine(s);
            }
            //MyList
            List<string> ysehirler1 = new List<string> { "Bursa", "Kocaeli", "Mersin" };
            ysehirler1.Add(item: "Muğla");
            foreach (var sehir in ysehirler1)
            {
                Console.WriteLine(sehir);
            }


            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person1);

            Person person = new Person();
            Console.ReadLine();
        }
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }
        static int Topla(int sayi1 = 3, int sayi2 = 6)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }
        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Ali";
            string soyad = "Kaya";
            int dogumYili = 2002;
            long tcNo = 12901038212;

            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
        }
    }
    //pascal Casing

    public class Vatandas
        {
     public string  Ad { get; set; }

     public string Soyad { get; set;}

     public int DogumYili{ get; set;}

     public long TcNo { get; set;}  


    }
}
