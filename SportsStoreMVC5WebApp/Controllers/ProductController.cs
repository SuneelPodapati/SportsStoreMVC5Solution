using LoggingLibrary;
using SportsStoreDomainLibrary.Abstract;
using SportsStoreMVC5WebApp.Infrastructure;
using SportsStoreMVC5WebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStoreMVC5WebApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;
        private ILogger _logger;
        private int _pageSize;
        public ProductController(IProductRepository productRepository, ILogger logger)
        {
            _productRepository = productRepository;
            _logger = logger;
            _pageSize = 4;
        }
        public ViewResult List(int page = 1)
        {

            Stopwatch timeSpan = Stopwatch.StartNew();
            var productsList = _productRepository.Products.OrderBy(p => p.ProductId);
            var productsListViewModel = new ProductsListViewModel
            {
                Products = productsList.Skip((page - 1) * _pageSize)
                .Take(_pageSize),
                GPager = new GPager(productsList.Count(), page, _pageSize)
            };

            timeSpan.Stop();
            _logger.LogMessage("ProductController", "List", timeSpan.Elapsed, "Getting 4 Records at a time and doing Paging");
            return View(productsListViewModel);

            #region Raw Paging
            //Stopwatch timeSpan = Stopwatch.StartNew();
            //var productsList = _productRepository.Products
            //    .OrderBy(p=>p.ProductId)
            //    .Skip((page -1) * _pageSize)
            //    .Take(_pageSize);
            //timeSpan.Stop();
            //_logger.LogMessage("ProductController", "List", timeSpan.Elapsed, "Getting 4 Records at a time from the products");
            //return View(productsList); 
            #endregion

            #region Without Paging
            //Stopwatch timeSpan = Stopwatch.StartNew();
            //var result = _productRepository.Products;
            //timeSpan.Stop();
            //_logger.LogMessage("ProductController", "List", timeSpan.Elapsed, "Getting all the products");
            //return View(result); 
            #endregion
        }
    }
}