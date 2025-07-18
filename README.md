# Student Grade Management System

Bu proje, öğrencilerin notlarını takip etmek ve yönetmek için geliştirilmiş basit bir konsol uygulamasıdır.

## Özellikler

- Öğrenci ekleme (ID ve isim ile)
- Öğrenciye ders bazında not ekleme veya güncelleme
- Öğrencilerin ortalama notlarını görüntüleme
- Öğrencilerin tüm not kayıtlarını detaylı listeleme

## Kullanılan Veri Yapısı

- Her öğrenci, `Student` sınıfı ile temsil edilir.
- Öğrencinin ID ve adı saklanır.
- Dersler ve notlar `Dictionary<string, int>` yapısı ile tutulur.
- Ortalama not, öğrenciye ait notların ortalaması olarak hesaplanır.

## Kurulum ve Çalıştırma

1. Projeyi Visual Studio'da açın.  
2. .NET 6.0 SDK veya üzeri yüklü olmalıdır.  
3. Projeyi derleyip çalıştırın.  
4. Konsol ekranındaki menüden yapmak istediğiniz işlemi seçin.

## Kullanım

- Menüden `1` ile öğrenci ekleyin.  
- Menüden `2` ile öğrenciye ders notu ekleyin veya güncelleyin.  
- Menüden `3` ile öğrencilerin ortalama notlarını görüntüleyin.  
- Menüden `4` ile tüm öğrencilerin detaylı not kayıtlarını listeleyin.  
- Menüden `5` ile programdan çıkabilirsiniz.

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır.  
Açık kaynaklı ve özgür kullanım, değiştirme ve dağıtım hakkı verir.  
Detaylar için [MIT Lisansı](https://opensource.org/licenses/MIT) sayfasına bakabilirsiniz.

---

## Proje Geliştirme Notu

Bu proje, [Foundations of Coding Back-End] kapsamında öğrenim sürecinde ödev olarak verilmiştir.  
Öğrenme ve uygulama amaçlı hazırlanmış temel bir örnek projedir.

