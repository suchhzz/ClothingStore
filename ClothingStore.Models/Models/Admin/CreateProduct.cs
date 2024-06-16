using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Models.Models.Admin
{
    public class CreateProduct
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Colors { get; set; }
        public string Sizes { get; set; }
        public string Qualities { get; set; }
        public string Images { get; set; }
    }
}
