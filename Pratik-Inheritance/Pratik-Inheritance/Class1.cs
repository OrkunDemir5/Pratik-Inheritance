using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Inheritance
{
    class BaseKisi
    {
        // Properties 
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // kişi bilgisi yazdırma metodu
        public void KisiBilgisiYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }
    }

    // "BaseKisi" sınıfından miras alan Ogrenci sınıfı
    class Ogrenci : BaseKisi
    {
        // Ogrenci sınıfına özgü property
        public int OgrenciNo { get; set; }

        // Ogrenci bilgilerini yazdıran metot
        public void OgrenciBilgisiYazdir()
        {
            Console.WriteLine($"Öğrenci No: {OgrenciNo}");
            // KisiBilgisiYazdir metodu, miras alınan sınıftan çağrılıyor
            KisiBilgisiYazdir();
        }
    }

    // "BaseKisi" sınıfından miras alan Ogretmen sınıfı
    class Ogretmen : BaseKisi
    {
        // Ogretmen sınıfına özgü property
        public decimal Maas { get; set; }

        // Ogretmen bilgilerini yazdıran metot
        public void OgretmenBilgisiYazdir()
        {
            Console.WriteLine($"Maaş: {Maas} TL");
            // KisiBilgisiYazdir metodu, miras alınan sınıftan çağrılıyor
            KisiBilgisiYazdir();
        }
    }
}
