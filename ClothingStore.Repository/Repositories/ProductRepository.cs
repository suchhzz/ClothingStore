using ClothingStore.DataAccess;
using ClothingStore.DataAccess.Entities;
using ClothingStore.Models.Models;
using ClothingStore.Models.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace ClothingStore.Repository.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ClothingStoreDbContext _context;
        public ProductRepository(ClothingStoreDbContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> Get()
        {
            var productEntities = await _context.Products
                .AsNoTracking()
                .ToListAsync();

            var products = productEntities
                .Select(p => Product.Create(p.Id, p.Title, p.Description, p.Price,
                    p.Colors.Select(c => c.Name).ToList(),
                    p.Sizes.Select(s => s.Name).ToList(),
                    p.Qualities.Select(q => q.Name).ToList(),
                    p.Images.Select(i => i.Image).ToList())
                .product).ToList();

            return products;
        }

        public async Task<Guid> Create(Product product)
        {
            var productEntity = new ProductEntity()
            {
                Id = product.Id,
                Title = product.Title,
                Description = product.Description,
                Price = product.Price,
            };

            foreach (var color in product.Colors)
            {
                var selectedColor = await _context.Colors.FirstOrDefaultAsync(c => c.Name == color);

                if (selectedColor == null)
                {
                    var newColor = new ColorEntity()
                    {
                        Name = color
                    };

                    await _context.Colors.AddAsync(newColor);
                    await _context.SaveChangesAsync();

                    selectedColor = newColor;
                }

                productEntity.Colors.Add(selectedColor);
            }

            foreach (var size in product.Sizes)
            {
                var selectedSize = await _context.Sizes.FirstOrDefaultAsync(s => s.Name == size);

                if (selectedSize == null)
                {
                    var newSize = new SizeEntity()
                    {
                        Name = size
                    };

                    await _context.Sizes.AddAsync(newSize);
                    await _context.SaveChangesAsync();

                    selectedSize = newSize;
                }

                productEntity.Sizes.Add(selectedSize);
            }

            foreach (var quality in product.Qualities)
            {
                var selectedQuality = await _context.Qualities.FirstOrDefaultAsync(q => q.Name == quality);

                if (selectedQuality == null)
                {
                    var newQuality = new QualityEntity()
                    {
                        Name = quality
                    };

                    await _context.Qualities.AddAsync(newQuality);
                    await _context.SaveChangesAsync();

                    selectedQuality = newQuality;
                }

                productEntity.Qualities.Add(selectedQuality);
            }

            productEntity.Images = new List<ImageEntity>();

            foreach (var image in product.Colors)
            {
                productEntity.Images.Add(new ImageEntity()
                {
                    Image = image,
                    Product = productEntity
                });
            };

            await _context.AddAsync(productEntity);
            await _context.SaveChangesAsync();

            return productEntity.Id;
        }

        public async Task<Guid> Update(Guid id, string title, string description, decimal price)
        {
            await _context.Products
                .Where(p => p.Id == id)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(p => p.Title, title)
                    .SetProperty(p => p.Description, description)
                    .SetProperty(p => p.Price, price));

            return id;
        }

        public async Task<Guid> Delete(Guid id)
        {
            await _context.Products
                .Where(p => p.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }
    }
}
