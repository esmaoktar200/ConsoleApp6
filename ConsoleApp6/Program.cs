//kullanıcıdan bir sayı iste girilen sayının çift mi tek mi olduğunu bul
//klavyede n harfine basana kadar oyun tekrar etsin



//string deger = "";
//int sayi;
//do
//{
//    Console.Write("Bir sayı giriniz:");
//    deger = Console.ReadLine();
//    if (int.TryParse(deger, out sayi))
//    {


//        if (sayi % 2 == 0)
//        {
//            Console.WriteLine("Girdiğiniz sayı çifttir.");
//        }
//        else
//        {
//            Console.WriteLine("Girdiğiniz sayı tektir.");
//        }
//    }

//}
//while (deger != "N" && deger != "n");

//bu kodu nesne tabanlı hale getir:




using System;

class SayiKontrol
{
    string deger = "";
    int sayi;

    public void sayiGir()
    {
        do
        {
            Console.Write("Bir sayı giriniz: ");
            deger = Console.ReadLine();

            if (deger != "N" && deger != "n")
            {
                sayimiKontrolEt();
            }

        } while (deger != "N" && deger != "n");
    }

    public void sayimiKontrolEt()
    {
        if (int.TryParse(deger, out sayi))
        {
            tekmiCiftmi();
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
        }
    }

    public void tekmiCiftmi()
    {
        if (sayi % 2 == 0)
        {
            Console.WriteLine("Girdiğiniz sayı çifttir.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayı tektir.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SayiKontrol nesne = new SayiKontrol();
        nesne.sayiGir();
    }
}
