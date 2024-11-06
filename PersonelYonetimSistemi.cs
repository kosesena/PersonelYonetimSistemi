using ConsoleApp15;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Personel
    {
        // Özellikler
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Pozisyon { get; set; }
        private double maas;
        private int calismaSuresi;

        // Kapsülleme: Maas ve CalismaSuresi için get ve set metodları
        public double Maas
        {
            get { return maas; }
            set
            {
                if (value >= 0)
                    maas = value;
                else
                    throw new ArgumentException("Maaş negatif olamaz.");
            }
        }

        public int CalismaSuresi
        {
            get { return calismaSuresi; }
            set
            {
                if (value >= 0)
                    calismaSuresi = value;
                else
                    throw new ArgumentException("Çalışma süresi negatif olamaz.");
            }
        }

        // Yapıcı Metot
        public Personel(string ad, string soyad, string pozisyon, double maas, int calismaSuresi)
        {
            Ad = ad;
            Soyad = soyad;
            Pozisyon = pozisyon;
            Maas = maas;
            CalismaSuresi = calismaSuresi;
            
        }

        // Personel bilgilerini yazdıran metot
        public void PersonelBilgileri()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Pozisyon: {Pozisyon}, Maaş: {Maas}, Çalışma Süresi: {CalismaSuresi}");
        }

        // Yıllık ikramiye hesaplayan metot
        public void YillikIkramiyeHesapla()
        {
            if (Pozisyon == "Yönetici")
                Maas += Maas * 0.20;
            else
                Maas += Maas * 0.10;
        }
    }
}

public class PersonelYonetimi
{
    private List<Personel> personelListesi = new List<Personel>();

    // Yeni personel ekleme metodu
    public void PersonelEkle(Personel personel)
    {
        personelListesi.Add(personel);
    }

    // Tüm personeli listeleme metodu
    public void TumPersonelleriListele()
    {
        foreach (var personel in personelListesi)
        {
            personel.PersonelBilgileri();
        }
    }

    // İsme göre personel arama metodu
    public Personel PersonelAra(string ad)
    {
        return personelListesi.FirstOrDefault(p => p.Ad == ad);
    }
}
class Program
{
    static void Main()
    {
        // Personel nesneleri oluşturma
        Personel personel1 = new Personel("Sena", "Köse", "Yönetici", 150000, 5);
        Personel personel2 = new Personel("Ayşenur", "Köse", "Eczacı", 150000, 3);

        // PersonelYonetimi nesnesi oluşturma ve personel ekleme
        PersonelYonetimi yonetim = new PersonelYonetimi();
        yonetim.PersonelEkle(personel1);
        yonetim.PersonelEkle(personel2);
        // İkramiyesiz başlangıç maaşlarını gösterme
        Console.WriteLine("Başlangıç maaşları: ");
        personel1.PersonelBilgileri();
        personel2.PersonelBilgileri();

        // İkramiyeleri maaşa ekleme
        personel1.YillikIkramiyeHesapla();
        personel2.YillikIkramiyeHesapla();
       
        // Tüm personeli listeleme
        yonetim.TumPersonelleriListele();

        // Belirli bir personeli arama
        Personel bulunanPersonel = yonetim.PersonelAra("Ayşenur");
        if (bulunanPersonel != null)
        {
            Console.WriteLine("Personel Bulundu:");
            bulunanPersonel.PersonelBilgileri();
        }
        else
        {
            Console.WriteLine("Personel bulunamadı.");
        }

        //Programın kapanamasını önlemek için sonsuz bir döngü 
        Console.WriteLine("Program kapanmasın diye bekleme döngüsüne girildi.");

        while (true)
        {
            // Döngü içine bir bekleme yapabilirsiniz veya bir tuşa basıldığında döngüden çıkabilirsiniz.
        }
    }
}

