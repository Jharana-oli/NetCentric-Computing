using Happymart.Models;
using Microsoft.AspNetCore.Mvc;

namespace Happymart.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>
            {
                new Product { id = 1, name = "Apple iPhone 14", price = 999, category = "Electronics" },
                new Product { id = 2, name = "Nike Shoes", price = 149, category = "Clothing" },
                new Product { id = 3, name = "Organic Rice", price = 25, category = "Grocery" }
            };
        public IActionResult Index()
        {
            return View(products);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
          public IActionResult Add(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
                product.id = products.Count + 1;
            products.Add(product);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.id == id);
            if (product != null)
            {
                products.Remove(product);
            }
            return RedirectToAction("Index");
        }

    }
}
