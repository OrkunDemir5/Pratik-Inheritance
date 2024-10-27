using Pratik_Inheritance;

class Program
{
    static void Main(string[] args)
    {
        // Örnek bir öğrenci nesnesi oluşturulup, değerler atanır
        Ogrenci ogrenci = new Ogrenci{Ad = "Orkun",Soyad = "Demir",OgrenciNo = 12345};
        ogrenci.OgrenciBilgisiYazdir();
        Console.WriteLine();

        // Örnek bir öğretmen nesnesi oluşturulup, değerler atanır
        Ogretmen ogretmen = new Ogretmen{Ad = "Yılmaz",Soyad = "Kara",Maas = 7500};
        ogretmen.OgretmenBilgisiYazdir();
    }
}