using Microsoft.AspNetCore.Mvc;
using ScarpeCo.Models;
using ScarpeCo.Repositories;

namespace ScarpeCo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = ProductRepository.GetAll();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = ProductRepository.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}

