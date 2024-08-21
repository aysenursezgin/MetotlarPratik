

Console.WriteLine("----------------------------Geriye Değer Döndürmeyen Bir void metot.------------------------");
Console.WriteLine("-------------------------Ekrana sevdiğiniz bir şarkı sözünü yazdırsın.------------------------");

static void SarkiSozu()
{
    Console.WriteLine("İstikrarlı hayal hakikattir");
}


SarkiSozu();               // Metodu çağırıp sonucu alıyoruz


Console.WriteLine("---------------------------Geriye Tamsayı Döndüren Bir metot-----------------------");
Console.WriteLine("-------------------Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.---------------------");


// Rastgele bir sayı üreten ve 2'ye bölümünden kalanı döndüren metod
static int GetRandomNumberMod2()
{
    // Random sınıfını oluşturuyoruz
    Random random = new Random();

    // 0 ile 100 arasında rastgele bir sayı üretiyoruz
    int randomNumber = random.Next(0, 101);

    // Sayının 2'ye bölümünden kalanı hesaplıyoruz
    int remainder = randomNumber % 2;

    // Sonucu ekrana yazdırıyoruz
    Console.WriteLine("2'ye Bölümünden Kalan: " + remainder);

    // Hesaplanan kalanı döndürüyoruz
    return remainder;
}

int remainder = GetRandomNumberMod2();      // Metodu çağırıp sonucu alıyoruz


Console.WriteLine("------------------Parametre Alan ve Geriye Değer Döndüren Bir Metot------------------------");
Console.WriteLine("-------------Parametre olarak aldığı iki sayının çarpımını geriye dönsün.------------------------");


// İki sayı tanımlıyoruz
int sayi1 = 5;
int sayi2 = 10;

// Metodu çağırarak iki sayının çarpımını alıyoruz
int carpim = CarpimHesapla(sayi1, sayi2);

// Sonucu ekrana yazdırıyoruz
Console.WriteLine($"{sayi1} ve {sayi2} sayılarının çarpımı: " + carpim);

// İki sayının çarpımını hesaplayan ve döndüren metod
static int CarpimHesapla(int a, int b)
{
    // Çarpımı hesaplayıp döndürüyoruz
    return a * b;
}


Console.WriteLine("-----------Parametre Alan ve Geriye Değer Döndürmeyen bir Metot------------------");
Console.WriteLine("-----Parametre olarak isim ve soyisim bilgilerini alıp \" Hoş Geldiniz {isim} {soyisim} \" şeklinde ekrana bassın.----");

static void HosGeldinizMesaji(string name, string surname)
{

    // Metodu çağırarak hoş geldiniz mesajını ekrana yazdırıyoruz
    HosGeldinizMesaji(name, surname);

    // Mesajı oluşturuyor ve ekrana yazdırıyoruz
    Console.WriteLine($"Hoş Geldiniz {name} {surname}");
}

 HosGeldinizMesaji("Aysenur","Sezgin");
    




