using System;

namespace Pratik_Inheritance
{
    // BaseKisi sınıfı, diğer sınıflar için temel oluşturur
    public abstract class BaseKisi
    {
        // Temel özellikler
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // Kişiyi tanıtan virtual metot
        public virtual void Tanıt()
        {
          
            Console.WriteLine($"Adı: {Ad}\nSoyadı: {Soyad}");
        }
    }

    // Ogrenci sınıfı, BaseKisi'den miras alır
    public class Ogrenci : BaseKisi
    {
        // Öğrenciye özel özellik
        public int OgrenciNo { get; set; }

        // Öğrenciyi tanıtan override edilmiş metot
        public override void Tanıt()
        {
            Console.WriteLine($"Öğrencinin;\nAdı: {Ad}\nSoyadı: {Soyad}\nÖğrenci No'su: {OgrenciNo}");
        }

        // Yapıcı metot
        public Ogrenci(string ad, string soyad, int ogrenciNo)
        {
            Ad = ad;
            Soyad = soyad;
            OgrenciNo = ogrenciNo;
        }
    }

    // Ogretmen sınıfı, BaseKisi'den miras alır
    public class Ogretmen : BaseKisi
    {
        // Öğretmene özel özellik
        public int MaasBilgisi { get; set; }

        // Öğretmeni tanıtan override edilmiş metot
        public override void Tanıt()
        {
            Console.WriteLine($"Öğretmenin;\nAdı: {Ad}\nSoyadı: {Soyad}\nMaaş Bilgisi: {MaasBilgisi} TL");
        }

        // Yapıcı metot
        public Ogretmen(string ad, string soyad, int maasBilgisi)
        {
            Ad = ad;
            Soyad = soyad;
            MaasBilgisi = maasBilgisi;
        }
    }
}