using ClothingStore.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Models.Abstracts
{
    public interface IOtherParametersService
    {
        public Task<List<ColorEntity>> GetColors();
        public Task<int> CreateColor(string color);
        public Task<int> DeleteColor(int id);
        public Task<List<SizeEntity>> GetSizes();
        public Task<int> CreateSize(string size);
        public Task<int> DeleteSize(int id);
        public Task<List<QualityEntity>> GetQualities();
        public Task<int> CreateQuality(int quality);
        public Task<int> DeleteQuality(int id);
    }
}
