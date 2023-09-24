using System;

namespace Benim;
class Program
{
    static void Main(string[] args)
    {
        //Ekrandan okunan iki tam sayı (int) için basit işlemler yaparak ekrana sonuçları basan kod yazınız. Bu işlemler toplama, çıkarma, çarpma, bölme ve kalan işlemleridir.
        Console.WriteLine("Dört İşlem Problemi");
        Console.WriteLine("----------------------");
        Console.WriteLine("Birinci Sayıyı Giriniz");
        int sayi1 = Convert.ToInt32( Console.ReadLine());
        Console.Clear();
        Console.WriteLine("İkinci Sayıyı Giriniz");
        int sayi2 = Convert.ToInt32( Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Birinci Sayı ile ikinci sayının toplamı = {sayi1+sayi2}");
        Console.WriteLine($"Birinci Sayı ile ikinci sayının Çarpımı = {sayi1*sayi2}");
        Console.WriteLine($"Birinci Sayı ile ikinci sayının Bölümü = {sayi1/sayi2}");
        Console.WriteLine($"Birinci Sayı ile ikinci sayının Farkı = {sayi1-sayi2}");


    }
}
