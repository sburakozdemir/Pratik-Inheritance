using System;
using Pratik_Inheritance;

class Program
{
    static void Main(string[] args)
    {
        // Örnek bir öğretmen nesnesi oluştur ve bilgilerini yazdır
        Ogretmen ogretmen1 = new Ogretmen("Ali", "Dursun", 25000);
        ogretmen1.Tanıt();

        Console.WriteLine(); // Boş satır ekle

        // Örnek bir öğrenci nesnesi oluştur ve bilgilerini yazdır
        Ogrenci ogrenci1 = new Ogrenci("Berk", "Bayındır", 198001);
        ogrenci1.Tanıt();
    }
}