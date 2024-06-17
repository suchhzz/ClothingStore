using ClothingStore.Models.Abstracts;
using ClothingStore.Models.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MyClothingStore.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;
        private readonly ILogger<AdminController> _logger;
        public AdminController(IAdminService adminService, ILogger<AdminController> logger)
        {
            _adminService = adminService;
            _logger = logger;

        }

        public async Task<IActionResult> Users()
        {
            return View();
        }
        public async Task<IActionResult> Products()
        {
            return View();  
        }
        public async Task<IActionResult> CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(AdminViewModel adminVM, string[] Sizes, string[] Qualities)
        {
            adminVM.CreateProduct.Sizes = string.Join(" ", Sizes);
            adminVM.CreateProduct.Qualities = string.Join(" ", Qualities);

            var createdId = await _adminService.CreateProduct(adminVM.CreateProduct);

            _logger.LogInformation("product created: " + createdId);

            return RedirectToAction(nameof(Products));
        }
        public async Task<IActionResult> OtherParameters()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateColor(string color)
        {
            return RedirectToAction(nameof(OtherParameters));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteColor(int id)
        {
            return RedirectToAction(nameof(OtherParameters));
        }

        [HttpPost]
        public async Task<IActionResult> CreateSize(string size)
        {
            return RedirectToAction(nameof(OtherParameters));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteSize(int id)
        {
            return RedirectToAction(nameof(OtherParameters));
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuality(string quality)
        {
            return RedirectToAction(nameof(OtherParameters));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteQuality(int id)
        {
            return RedirectToAction(nameof(OtherParameters));
        }


    }
}
