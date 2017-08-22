using SportsStoreDomainLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsStoreDomainLibrary.Entities;

namespace SportsStoreMVC5WebApp.Infrastructure
{
    public class MockProduct : IProductRepository
    {
        public IEnumerable<Product> Products
        {
            get {
                return new List<Product>
                {
                    new Product { ProductName="Kayak", Description="A boat for one person", Price=275.00m, Category="Watersports"},
                    new Product { ProductName="Unsteady Chair", Description="Secretly give your opponent a disadvantage", Price=29.95m, Category="Chess"},
                    new Product { ProductName="Lifejacket", Description="Protective and fashionable", Price=48.95m, Category="Watersports"},
                    new Product { ProductName="Spalding Ball", Description="NBA official Basketball", Price=160.00m, Category="Basketball"},
                    new Product { ProductName="Corner flags", Description="Give your playing field that professional touch", Price=34.95m, Category="Soccer"},
                    new Product { ProductName="Stadium", Description="Flat-packed 35,000-seat stadium", Price=79500.00m, Category="Soccer"},
                    new Product { ProductName="Ring Net", Description="NBA size ring nets", Price=60.00m, Category="Basketball"},
                    new Product { ProductName="Human Chess", Description="A fun game for the whole family", Price=75.00m, Category="Chess"},
                    new Product { ProductName="Bling-bling King", Description="Gold-plated, diamond-studded King", Price=1200.00m, Category="Chess"},
                    new Product { ProductName="Dark Night", Description="Titanium-plated Knight", Price=800.00m, Category="Chess"},
                    new Product { ProductName="Shoe", Description="Studded shoes", Price=950.00m, Category="Soccer"},
                    new Product { ProductName="Jersey", Description="Air Jersey", Price=1200.00m, Category="Soccer"}
                };
            }
        }
        public Product AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}