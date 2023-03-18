using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace TernaryOperatorOrnegi
{
    

    class Program
    {
        static void Main(string[] args)
        {
            //4 Farklı ürün ve açıklamaları//
            Product urun1 = new Product();
            urun1.ProductName = "S-POLO Çelik Saat";
            urun1.ProductPrice = "250 tl";
            urun1.ProductQuantity = 80;

            Product urun2 = new Product();
            urun2.ProductName = "MHK-Collection Avize";
            urun2.ProductPrice = "145 tl";
            urun2.ProductQuantity = 15;

            Product urun3 = new Product();
            urun3.ProductName = "HiPet-Kedi Şampuan";
            urun3.ProductPrice = "150 tl";
            urun3.ProductQuantity = 240;

            Product urun4 = new Product();
            urun4.ProductName = "BERSHKA-Beyaz Spor Ayakkabı";
            urun4.ProductPrice = "400 tl";
            urun4.ProductQuantity = 12;

            Product[] urunler = new Product[] { urun1, urun2, urun3, urun4 };

            //Forech döngüsü//
            foreach (var product in urunler)
            {
                Console.WriteLine(product.ProductName + " : " + product.ProductPrice + " : " + product.ProductQuantity);
            }

           
            //For döngüsü//
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].ProductName + " : " + urunler[i].ProductPrice + " : " + urunler[i].ProductQuantity );

            }

            //While döngüsü//
            int k = 0;
            while (k < urunler.Length)
            {
                Console.WriteLine(urunler[k].ProductName + " : " + urunler[k].ProductPrice + " : " + urunler[k].ProductQuantity);
                k++;
            }

            Console.ReadLine();
            
            
        }
    }

    //Class product oluşumu//
    class Product
    {
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public int ProductQuantity { get; set; }


    } 

         





}


// temary operatörü
int sayi1 = 10;
int sayi2 = 20;

string sonuc = (sayi1 > sayi2) ? "Sayi1, sayi2'den büyüktür" : "Sayi2, sayi1'den büyüktür";

Console.WriteLine(sonuc);
Console.ReadKey();

/// While Döngüsü
int i = 1;
while (i <= 5)
{
    Console.WriteLine("i = " + i);
    i++;
}
Console.WriteLine("Döngü Bitti!");


