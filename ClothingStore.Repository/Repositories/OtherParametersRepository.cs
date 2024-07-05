using ClothingStore.DataAccess;
using ClothingStore.DataAccess.Entities;
using ClothingStore.Models.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Repository.Repositories
{
    public class OtherParametersRepository : IOtherParametersRepository
    {
        private readonly ClothingStoreDbContext _context;
        public OtherParametersRepository(ClothingStoreDbContext context)
        {
            _context = context;
        }

        public async Task<List<ColorEntity>> GetColors()
        {
            return await _context.Colors
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<int> CreateColor(string color)
        {
            var colorEntity = new ColorEntity()
            {
                Name = color
            };

            await _context.Colors.AddAsync(colorEntity);
            await _context.SaveChangesAsync();

            return colorEntity.Id;
        }

        public async Task<int> DeleteColor(int id)
        {
            await _context.Colors
                .Select(c => c.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }

        public async Task<List<SizeEntity>> GetSizes()
        {
            return await _context.Sizes
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<int> CreateSize(string size)
        {
            var sizeEntity = new SizeEntity()
            {
                Name = size
            };

            await _context.Sizes.AddAsync(sizeEntity);
            await _context.SaveChangesAsync();

            return sizeEntity.Id;
        }

        public async Task<int> DeleteSize(int id)
        {
            await _context.Sizes
                .Select(s => s.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }

        public async Task<List<QualityEntity>> GetQualities()
        {
            return await _context.Qualities
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<int> CreateQuality(int quality)
        {
            var qualityEntity = new QualityEntity()
            {
                Name = quality
            };

            await _context.Qualities.AddAsync(qualityEntity);
            await _context.SaveChangesAsync();

            return qualityEntity.Id;
        }

        public async Task<int> DeleteQuality(int id)
        {
            await _context.Qualities
                .Select(q => q.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }
    }
}
