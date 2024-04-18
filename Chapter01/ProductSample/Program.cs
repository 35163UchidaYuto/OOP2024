using SampleApp;
using System;

namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {

            Product karinto = new Product(123, "かりんとう", 180);
            Product daihuku = new Product(135, "大福", 200);
            Product dorayaki = new Product(98, "どら焼き", 210);

            int price = karinto.Price;//税抜きの金額
            int taxIncluded = karinto.GetPriceIncludingTax();//税込みの金額

            int daihukuprice = daihuku.Price;//税抜きの金額
            int daihukutaxIncluded = daihuku.GetPriceIncludingTax();//税込みの金額

            
            int dorayakiTax = dorayaki.GetTax();//税込みの金額

            Console.WriteLine(karinto.Name +"の税込金額"+ taxIncluded + "円【税抜き"+price+"円】");
            Console.WriteLine(daihuku.Name + "の税込金額" + daihukutaxIncluded + "円【税抜き" + daihukuprice + "円】");
            Console.WriteLine($"{dorayakiTax}");

        }
    }
}
