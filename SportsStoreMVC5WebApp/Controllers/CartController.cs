using LoggingLibrary;
using SportsStoreDomainLibrary.Abstract;
using SportsStoreDomainLibrary.Entities;
using SportsStoreMVC5WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStoreMVC5WebApp.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository _productRepository;
        private ILogger _logger;
        public CartController(IProductRepository productRepository, ILogger logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        private Cart GetCart()
        {
            Cart cart = (Cart) Session["cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["cart"] = cart;
            }
            return cart;
        }

        public ActionResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel { Cart = GetCart(), ReturnUrl = returnUrl });
        }
        public ViewResult Summary(){ return View(GetCart()); }

        public RedirectToRouteResult AddToCart(int? productId, string returnUrl)
        {
            Product prod = _productRepository.Products.FirstOrDefault(p => p.ProductId == productId);
            if (prod != null)
            {
                GetCart().AddItem(prod, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToRouteResult RemoveFromCart(int productId, string returnUrl)
        {
            Product prod = _productRepository.Products.FirstOrDefault(p => p.ProductId == productId);
            if (prod != null)
            {
                GetCart().RemoveLine(prod);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public ViewResult Checkout() { return View(); }

        [HttpPost]
        public ViewResult Checkout(string name)
        {
            GetCart().Clear();
            return View("Thankyou");
        }

        //public ContentResult AddToCart(int? productId, string returnUrl)
        //{
        //    return Content("<h1>ProductId: " + productId + ", ReturnUrl: " + returnUrl + "</h1>");
        //}
    }
}