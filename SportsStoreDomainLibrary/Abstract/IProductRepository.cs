using SportsStoreDomainLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStoreDomainLibrary.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        Product GetProduct(int productId);
        Product AddProduct(Product product);
        Product UpdateProduct(Product product);
        Product DeleteProduct(int productId);
    }
}
