using ClothingStore.Models.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace MyClothingStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
