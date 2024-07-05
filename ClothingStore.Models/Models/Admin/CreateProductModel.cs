using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Models.Models.Admin
{
    public class CreateProductModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Colors { get; set; }
        public string[] Sizes { get; set; }
        public string[] Qualities { get; set; }
        public List<IFormFile> Images { get; set; } = new List<IFormFile>();
    }
}
