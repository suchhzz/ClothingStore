using ClothingStore.Models.Abstracts;
using ClothingStore.Models.TempDb;
using ClothingStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MyClothingStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly TempProductDatabase _tempDatabase;
        public ProductController(IProductService productService, TempProductDatabase tempDatabase)
        {
            _productService = productService;
            _tempDatabase = tempDatabase;
        }
        public IActionResult Index()
        {
            var mainPageViewModel = new MainPageViewModel();

            mainPageViewModel.Products = _tempDatabase.GetAll();

            return View();
        }
    }
}
