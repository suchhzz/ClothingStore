using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.DataAccess.Entities
{
    public class QualityEntity
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public ICollection<ProductEntity> Products { get; set; }
    }
}
