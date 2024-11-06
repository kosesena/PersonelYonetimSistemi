# PersonelYonetimSistemi
## Soru: Personel Yönetim Sistemi

Bir şirket için temel bir personel yönetim sistemi geliştireceksiniz. Bu sistemde personelin bilgilerini tutan ve yönetimi kolaylaştıran bir yapı kurmalısınız. Aşağıdaki özelliklere dikkat edin:

- **Personel** adında bir sınıf oluşturun. Bu sınıf aşağıdaki özellikleri içermelidir:

- **Ad** (string)
- **Soyad** (string)
- **Pozisyon** (string)
- **Maas** (double)
- **CalismaSuresi** (int) - yıl olarak çalışma süresini temsil eder.

- **Kapsülleme (Encapsulation)** ilkesine uygun olarak bu özellikleri get ve set metodları ile tanımlayın.

- **Maas** ve **CalismaSuresi** özelliklerinin değerleri negatif olamaz. Eğer negatif bir değer atanmak istenirse, hata mesajı verin.

- **Personel** sınıfında, personel bilgilerini ekrana yazdıran **PersonelBilgileri()** adında bir metot tanımlayın. Kapsamlı bir yapıcı metot (**constructor**) tanımlayın. Bu yapıcı metot, Ad, Soyad,Pozisyon, Maas ve CalismaSuresi özelliklerine değer atamak için kullanılacaktır.Yıllık ikramiyeleri hesaplayan **YillikIkramiye()** adında bir metot oluşturun. Bu metot:

- Pozisyon **“Yönetici”** ise yıllık maaşı %20’si kadar ikramiye döndürsün.Diğer pozisyonlar için %10 ikramiye döndürsün.

- **PersonelYonetimi** adında ayrı bir sınıf oluşturun. Bu sınıfta bir List<Personel> kullanarak birden fazla personel ekleyebileceğiniz bir yapı oluşturun.PersonelYonetimi sınıfında aşağıdaki metodları tanımlayın:

- **PersonelEkle(Personel personel)**: Yeni bir personel ekler.
- **TumPersonelleriListele()**: Tüm personel bilgilerini ekrana yazdırır.
- **PersonelAra(string ad)**: İsme göre arama yapar ve eşleşen personelin bilgilerini ekrana yazdırır.

- **Main** metodunda, **Personel** sınıfından birkaç örnek nesne oluşturun ve **PersonelYonetimi** sınıfına ekleyin. Ardından, **TumPersonelleriListele()** ve **PersonelAra()** metodlarını test edin.
