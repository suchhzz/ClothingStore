using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.DataAccess.Entities
{
    public class ProductEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<ColorEntity> Colors { get; set; }
        public ICollection<SizeEntity> Sizes { get; set; }
        public ICollection<QualityEntity> Qualities { get; set; }
        public ICollection<ImageEntity> Images { get; set; }
    }
}
