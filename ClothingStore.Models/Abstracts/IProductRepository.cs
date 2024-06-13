using ClothingStore.DataAccess;
using ClothingStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Models.Abstracts
{
    public interface IProductRepository
    {
        public Task<List<Product>> Get();
        public Task<Guid> Create(Product product);
        public Task<Guid> Update(Guid id, string title, string description, decimal price);
        public Task<Guid> Delete(Guid id);

    }
}
