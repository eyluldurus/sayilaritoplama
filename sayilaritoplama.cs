// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        int toplam = 0;
        
        for (int i = 1; i <= sayi; i++)
        {
            toplam += i;
        }

        Console.WriteLine("1'den " + sayi + "'ye kadar olan sayıların toplamı: " + toplam);
    }
}

