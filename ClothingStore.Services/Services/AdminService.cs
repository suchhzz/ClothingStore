using ClothingStore.Models.Abstracts;
using ClothingStore.Models.Models;
using ClothingStore.Models.Models.Admin;
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
        public AdminService(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<Guid> CreateProduct(CreateProduct createProduct)
        {
            var product = new Product(
                Guid.NewGuid(),
                createProduct.Title,
                createProduct.Description,
                createProduct.Price,
                createProduct.Colors.Split(" ").ToList(),
                createProduct.Sizes.Split(" ").ToList(),
                createProduct.Qualities.Split(" ").Select(int.Parse).ToList(),
                createProduct.Images.Split(" ").ToList()
            );

            await _productService.CreateProduct(product);

            return product.Id;
        }
    }
}
