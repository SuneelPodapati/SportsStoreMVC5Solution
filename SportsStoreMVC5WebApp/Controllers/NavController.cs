using LoggingLibrary;
using SportsStoreDomainLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStoreMVC5WebApp.Controllers
{
    public class NavController : Controller
    {
        private IProductRepository _productRepository;
        private ILogger _logger;
        public NavController(IProductRepository productRepository, ILogger logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }
        public PartialViewResult Menu(string category = null)
        {
            Stopwatch timeSpan = Stopwatch.StartNew();
            ViewBag.selectedCategory = category;
            var result = _productRepository.Products.Select(p => p.Category).Distinct().OrderBy(p => p);
            timeSpan.Stop();
            _logger.LogMessage("NavController", "Menu", timeSpan.Elapsed, "Got the Distinct of Categories");
            return PartialView(result);
        }
    }
}