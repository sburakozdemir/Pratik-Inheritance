# Pratik-Inheritance

Bu proje, C# programlama dilinde inheritance (kalıtım) kavramını öğrenmek ve uygulamak için tasarlanmış basit bir örnektir. Proje, bir temel sınıf (`BaseKisi`) ve ondan türetilen iki alt sınıf (`Ogrenci` ve `Ogretmen`) içerir.

## Proje İçeriği

Proje aşağıdaki bileşenleri içerir:

1. `BaseKisi`: Temel kişi sınıfı
2. `Ogrenci`: `BaseKisi`'den türetilen öğrenci sınıfı
3. `Ogretmen`: `BaseKisi`'den türetilen öğretmen sınıfı
4. Örnek kullanımı gösteren bir `Main` metodu

## Sınıf Yapısı

### BaseKisi
- Özellikler: `Ad`, `Soyad`
- Metotlar: `Tanıt()`

### Ogrenci
- Ek Özellikler: `OgrenciNo`
- Override Metotlar: `Tanıt()`

### Ogretmen
- Ek Özellikler: `MaasBilgisi`
- Override Metotlar: `Tanıt()`

## Nasıl Çalışır?

1. `BaseKisi` sınıfı, temel özellikleri ve metotları tanımlar.
2. `Ogrenci` ve `Ogretmen` sınıfları, `BaseKisi`'den miras alır ve kendi özel özelliklerini ve davranışlarını ekler.
3. Her sınıf, `Tanıt()` metodunu kendi ihtiyaçlarına göre override eder.
4. `Main` metodunda, örnek nesneler oluşturulur ve `Tanıt()` metodu çağrılarak bilgiler ekrana yazdırılır.
