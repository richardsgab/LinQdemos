﻿namespace LinQDemoNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Buyer> buyers = new List<Buyer>()
            {
                new Buyer() { Name = "Rik", District = "Brussel", Age = 22},
                new Buyer() { Name = "Hugo", District = "Antwerpen", Age = 40},
                new Buyer() { Name = "Salvatore", District = "Brussel", Age = 30 },
                new Buyer() { Name = "Olesia", District = "Antwerpen", Age = 35 },
                new Buyer() { Name = "Zak", District = "Antwerpen", Age = 40 },
                new Buyer() { Name = "Eveliene", District = "Kortrijk", Age = 22 },
                new Buyer() { Name = "Dritan", District = "Antwerpen", Age = 30 },
                new Buyer() { Name = "Gabriela", District = "Gent", Age = 35 },
                new Buyer() { Name = "Santiago", District = "Brussel", Age = 40 }
        };
            List<Supplier> suppliers = new List<Supplier>()
            {
                new Supplier() { Name = "Harrison Ford", District = "Brussel", Age = 22 },
                new Supplier() { Name = "Charles Bronson", District = "Kortrijk", Age = 40 },
                new Supplier() { Name = "Tina Turner", District = "Antwerpen", Age = 35 },
                new Supplier() { Name = "Liam Neeson", District = "Brugge", Age = 30 }
            };

            //JOIN
            var innerJoin = suppliers.Join(buyers, s => s.District, b => b.District,(s, b) => new//anonieme class
                                            {
                                                SupplierName = s.Name,
                                                BuyerName = b.Name,
                                                DistrictName = s.District
                                            });
            foreach( var inner in innerJoin )
            {
                Console.WriteLine($" District : {inner.DistrictName}  Supplier : {inner.SupplierName}  Buyer : {inner.BuyerName}");
            }
        }
    }
}
