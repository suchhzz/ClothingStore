using ClothingStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Models.Abstracts
{
    public interface IProductService
    {
        public Task<List<Product>> GetAllProducts();
        public Task<Guid> CreateProduct(Product product);
        public Task<Guid> UpdateProduct(Guid id, string title, string description, decimal price);
        public Task<Guid> DeleteProduct(Guid id);
    }
}
