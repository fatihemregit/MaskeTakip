using Business.Concrete;
using Entities.Concrete;

namespace WorkAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            SelamVer("Fatih");
            SelamVer("Engin");
            SelamVer();
            Vatandas vatandas = new Vatandas();

            int sonuc = Topla(6,58);
            //diziler /Arrays
            string ogrenci1 = "Fatih";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[]
            {
                ogrenci1,
                ogrenci2,
                ogrenci3
            };
            ogrenciler = new string[4];
            ogrenciler[3] = "emre";
            //referans veri tipi : Arrray,Class,İnterface,Abstract
            
            
            for (int i = 0;i < ogrenciler.Length;i++) {
                Console.WriteLine(ogrenciler[0]);
            }
            string[] sehirler1 = new string[] { 
                "Ankara",
                "İstanbul",
                "izmir"
            };
            string[] sehirler2 = new string[]
            {
                "Bursa",
                "Antalya",
                "Diyarbakır"
            };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
            //değer veri tipi : int , double ,bool
            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;

            foreach (string sehir in sehirler1) {
                Console.WriteLine(sehir);

            }
            List<string> yeniSehirler1 = new List<string>() { 
                "Ankara 1",
                "İstanbul 1",
                "İzmir 1"
            };
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1) {
                Console.WriteLine(sehir);
            }

            Person person1 = new Person();
            person1.FirstName = "FATİH EMRE";
            person1.LastName = "KILINÇ";
            person1.DateOfBirthYear = 2024;
            person1.NationalIdentity = 11111111110;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();
        }

        static void SelamVer(String isim = "isimsiz")
        {
            //net8.0 da böyle de oluyor
            Console.WriteLine($"Merhaba {isim}");
        }
        static int Topla(int sayi1 = 5,int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Selam";

            double tutar = 100000; // dbden gelir
            int sayi = 100;
            bool girisYapmisMi = false;



            Console.WriteLine(tutar * 1.8);

            Console.WriteLine(tutar * 1.8);
        }
    }

    public class Vatandas
    {
        //public değişkenler büyük yazılır
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
         

    }

}
