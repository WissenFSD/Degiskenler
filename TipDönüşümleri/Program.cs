

//string deger1 = "10";
//string deger2 = "20";


//string toplam =deger1+deger2;

//Console.WriteLine(toplam);

//// Convert.ToInt32 yöntemi, string değerindeki bir değişkenin değerini, int tipine dönüştürmek için kullanıılır
//int sayi1 = Convert.ToInt32(deger1) ;
//int sayi2 = Convert.ToInt32(deger2) ;

//int toplamSayi = sayi1 + sayi2;
//Console.WriteLine(toplamSayi);



Console.WriteLine("Birinci sayiyi giriniz ...");
string birinciSayi=Console.ReadLine();


Console.WriteLine("İkinci sayiyi giriniz ...");

string ikinciSayi = Console.ReadLine();

int sayi1 = Convert.ToInt32(birinciSayi);   
int sayi2 = Convert.ToInt32(ikinciSayi);

int toplam = sayi1 + sayi2;

Console.WriteLine("Birinci sayi {0}. İkinci Sayi {1}. Toplam : {2}", sayi1, sayi2,toplam);
