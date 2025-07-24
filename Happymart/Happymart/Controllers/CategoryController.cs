using Microsoft.AspNetCore.Mvc;
using Happymart.Models;
namespace Happymart.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            var categories = new List<Category1>
            {
                new Category1{ id =1, name ="ELectronics" },
                new Category1{ id =2, name ="Clothes" },
                new Category1{ id =3, name ="Groceries" }
            };
            return View(categories);
        }
    }
}
