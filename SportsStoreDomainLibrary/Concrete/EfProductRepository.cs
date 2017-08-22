using SportsStoreDomainLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStoreDomainLibrary.Entities;

namespace SportsStoreDomainLibrary.Concrete
{
    public class EfProductRepository : IProductRepository
    {
        private SportsStoreDbContext _context;
        public EfProductRepository()
        {
            _context = new SportsStoreDbContext();
        }
        public IEnumerable<Product> Products
        {
            get
            {
                return _context.Products;
            }
        }

        public Product AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }
        public Product DeleteProduct(int productId)
        {
            Product prod = _context.Products.FirstOrDefault(p=>p.ProductId == productId);
            if (prod != null)
            {
                _context.Products.Remove(prod);
                _context.SaveChanges();
            }
            return prod;
        }

        public Product GetProduct(int productId)
        {
            return _context.Products.FirstOrDefault(p=>p.ProductId == productId);
        }

        public Product UpdateProduct(Product product)
        {
            _context.Entry<Product>(product).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            return product;
        }
    }
}
