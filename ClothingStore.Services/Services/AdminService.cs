using ClothingStore.DataAccess.Entities;
using ClothingStore.Models.Abstracts;
using ClothingStore.Models.Models;
using ClothingStore.Models.Models.Admin;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Services.Services
{
    public class AdminService : IAdminService
    {
        private readonly IProductService _productService;
        private readonly IOtherParametersService _otherParametersService;
        private readonly IImageService _imageService;
        public AdminService(IProductService productService, IOtherParametersService otherParametersService, IImageService imageService)
        {
            _productService = productService;
            _otherParametersService = otherParametersService;
            _imageService = imageService;
        }
        public async Task<Guid> CreateProduct(CreateProductModel createProduct)
        {
            var imagePath = await _imageService.SaveImages(createProduct.Images);

            var product = new Product(
                Guid.NewGuid(),
                createProduct.Title,
                createProduct.Description,
                createProduct.Price,
                createProduct.Colors.Split(" ").ToList(),
                createProduct.Sizes.ToList(),
                createProduct.Qualities.Select(int.Parse).ToList(),
                imagePath
            );

            await _productService.CreateProduct(product);

            return product.Id;
        }
        public async Task<List<ColorEntity>> GetColors()
        {
            return await _otherParametersService.GetColors();
        }
        public async Task<int> CreateColor(string color)
        {
            return await _otherParametersService.CreateColor(color);
        }
        public async Task<int> DeleteColor (int id)
        {
            return await _otherParametersService.DeleteColor(id);
        }
        public async Task<List<SizeEntity>> GetSizes()
        {
            return await _otherParametersService.GetSizes();
        }
        public async Task<int> CreateSize(string size)
        {
            return await _otherParametersService.CreateSize(size);
        }
        public async Task<int> DeleteSize (int id)
        {
            return await _otherParametersService.DeleteSize(id);
        }


        public async Task<List<QualityEntity>> GetQualities()
        {
            return await _otherParametersService.GetQualities();
        }
        public async Task<int> CreateQuality(string quality)
        {
            return await _otherParametersService.CreateQuality(int.Parse(quality));
        }
        public async Task<int> DeleteQuality(int id)
        {
            return await _otherParametersService.DeleteQuality(id);
        }
    }
}
