using ClothingStore.DataAccess.Entities;
using ClothingStore.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Services.Services
{
    public class OtherParametersService : IOtherParametersService
    {
        private readonly IOtherParametersRepository _otherParametersRepository;
        public OtherParametersService(IOtherParametersRepository otherParametersRepository)
        {
            _otherParametersRepository = otherParametersRepository;
        }

        public async Task<List<ColorEntity>> GetColors()
        {
            return await _otherParametersRepository.GetColors();
        }
        public async Task<int> CreateColor(string color)
        {
            return await _otherParametersRepository.CreateColor(color);
        }
        public async Task<int> DeleteColor(int id)
        {
            return await _otherParametersRepository.DeleteColor(id);
        }
        public async Task<List<SizeEntity>> GetSizes()
        {
            return await _otherParametersRepository.GetSizes();
        }
        public async Task<int> CreateSize(string size)
        {
            return await _otherParametersRepository.CreateSize(size);
        }
        public async Task<int> DeleteSize(int id)
        {
            return await _otherParametersRepository.DeleteSize(id);
        }
        public async Task<List<QualityEntity>> GetQualities()
        {
            return await _otherParametersRepository.GetQualities();
        }
        public async Task<int> CreateQuality(int quality)
        {
            return await _otherParametersRepository.CreateQuality(quality);
        }
        public async Task<int> DeleteQuality(int id)
        {
            return await _otherParametersRepository.DeleteQuality(id);
        }
    }
}
