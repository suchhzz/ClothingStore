using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Models.Models
{
    public class Product
    {
        public Product(Guid id, string title, string description, decimal price, List<string> colors, List<string> sizes, List<int> qualities, List<string> images)
        {
            Id = id;
            Title = title; 
            Description = description;
            Price = price;
            Colors = colors;
            Sizes = sizes;
            Qualities = qualities;
            Images = images;
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<string> Colors { get; set; }
        public List<string> Sizes { get; set; }
        public List<int> Qualities { get; set; }
        public List<string> Images { get; set; }

        public static (Product product, string error) Create(Guid id, string title, string description, decimal price, List<string> colors, List<string> sizes, List<int> qualities, List<string> images)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
            {
                error = "title and description can not be empty";
            }

            var product = new Product(id, title, description, price, colors, sizes, qualities, images);

            return (product, error);
        }
    }
}
