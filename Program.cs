


Console.WriteLine(Gunler.Cuma);
Console.WriteLine((int)Gunler.Cuma);//Cuma gününün numerik değerini öğrenme


// Enum kullanılarak hava durumu bildirimi yapan kod bloğu
int sicaklik =32;
if(sicaklik<= (int)HavaDurumu.Normal)
{
    Console.WriteLine("DIşarıya Çıkmak İçin Havanın Biraz Daha Isınmasını Bekle");
}else if (sicaklik>=(int)HavaDurumu.Sıcak)
{
    Console.WriteLine("Dışarıya Çıkmak İçin Çok Sıcak Bir Gün");
}else if (sicaklik>=(int)HavaDurumu.Normal&&sicaklik<(int)HavaDurumu.ÇokSıcak)
{
    Console.WriteLine("Hadi Dışarıya Çıkalım");
}


// Değerleri 1 artar üzerine gelince değerini söterir.
enum Gunler 
{
    Pazartesi,
    Salı=5,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}






enum HavaDurumu
{
    Soguk = 5,
    Normal =20,
    Sıcak=25,
    ÇokSıcak=30
}