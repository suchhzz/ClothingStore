using ClothingStore.Models.Abstracts;
using ClothingStore.Models.Models.Admin;
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
        public async Task<IActionResult> CreateProduct(CreateProductModel createProduct)
        {
            var createdId = await _adminService.CreateProduct(createProduct);

            _logger.LogInformation("product created: " + createdId);

            return RedirectToAction(nameof(Products));
        }
        public async Task<IActionResult> OtherParameters()
        {
            var otherParameters = new OtherParametersModel()
            {
                Colors = await _adminService.GetColors(),
                Sizes = await _adminService.GetSizes(),
                Qualities = await _adminService.GetQualities()
            };
               
            return View(otherParameters);
        }

        [HttpPost]
        public async Task<IActionResult> CreateColor(string color)
        {
            var createdColorId = await _adminService.CreateColor(color);

            return RedirectToAction(nameof(OtherParameters));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteColor(int id)
        {
            var deletedColorId = await _adminService.DeleteColor(id);

            return RedirectToAction(nameof(OtherParameters));
        }

        [HttpPost]
        public async Task<IActionResult> CreateSize(string size)
        {
            var createdSizeId = await _adminService.CreateSize(size);

            return RedirectToAction(nameof(OtherParameters));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteSize(int id)
        {
            var deletedSizeId = await _adminService.DeleteSize(id);

            return RedirectToAction(nameof(OtherParameters));
        }

        [HttpPost]
        public async Task<IActionResult> CreateQuality(string quality)
        {
            var createdQualityId = await _adminService.CreateQuality(quality);

            return RedirectToAction(nameof(OtherParameters));
        }
        [HttpPost]
        public async Task<IActionResult> DeleteQuality(int id)
        {
            var deletedQualityId = await _adminService.DeleteQuality(id);

            return RedirectToAction(nameof(OtherParameters));
        }


    }
}
