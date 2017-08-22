using SportsStoreDomainLibrary.Entities;
using SportsStoreMVC5WebApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsStoreMVC5WebApp.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public GPager GPager { get; set; }

        //Bug
    }
}