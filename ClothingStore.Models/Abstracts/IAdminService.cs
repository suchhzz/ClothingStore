using ClothingStore.Models.Models.Admin;
using ClothingStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStore.DataAccess.Entities;

namespace ClothingStore.Models.Abstracts
{
    public interface IAdminService
    {
        public Task<Guid> CreateProduct(CreateProductModel createProduct);
        public Task<List<ColorEntity>> GetColors();
        public Task<int> CreateColor(string color);
        public Task<int> DeleteColor(int id);
        public Task<List<SizeEntity>> GetSizes();
        public Task<int> CreateSize(string size);
        public Task<int> DeleteSize(int id);
        public Task<List<QualityEntity>> GetQualities();
        public Task<int> CreateQuality(string quality);
        public Task<int> DeleteQuality(int id);
    }
}
