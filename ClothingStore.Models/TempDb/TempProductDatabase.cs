using ClothingStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Models.TempDb
{
    public class TempProductDatabase
    {
        private List<Product> productList;

        public TempProductDatabase()
        {
            productList = new List<Product>
            {
                new Product (
                    Guid.NewGuid(),
                    "T-shirt",
                    "best t-shirt for you",
                    120,
                    new List<string> { "Red", "Black", "Gray" },
                    new List<string> { "XS", "S", "M", "L" },
                    new List<int> { 1, 2, 3, 5 },
                    new List<string> {
                        "C:\\Users\\jenje\\source\\repos\\MyClothingStore\\MyClothingStore\\wwwroot\\imageTest\\0001-1.jpg",
                        "C:\\Users\\jenje\\source\\repos\\MyClothingStore\\MyClothingStore\\wwwroot\\imageTest\\0001-4.jpg",
                        "C:\\Users\\jenje\\source\\repos\\MyClothingStore\\MyClothingStore\\wwwroot\\imageTest\\0001-5.jpg"
                    }),

                new Product (
                    Guid.NewGuid(),
                    "Shoes",
                    "comfortable shoes",
                    340,
                    new List<string> { "Black", "Brown" },
                    new List<string> { "34", "43", "41" },
                    new List<int> { 4, 5 },
                    new List<string> {
                        "C:\\Users\\jenje\\source\\repos\\MyClothingStore\\MyClothingStore\\wwwroot\\imageTest\\shoe_pic1.jpg",
                        "C:\\Users\\jenje\\source\\repos\\MyClothingStore\\MyClothingStore\\wwwroot\\imageTest\\shoe_pic2.jpg",
                        "C:\\Users\\jenje\\source\\repos\\MyClothingStore\\MyClothingStore\\wwwroot\\imageTest\\shoe_pic3.jpg"
                    }),

                new Product (
                    Guid.NewGuid(),
                    "Bag",
                    "stylish woman bag",
                    120,
                    new List<string> { "Green", "Orange", "Brown" },
                    new List<string> { },
                    new List<int> { 3, 5 },
                    new List<string> {
                        "C:\\Users\\jenje\\source\\repos\\MyClothingStore\\MyClothingStore\\wwwroot\\imageTest\\w_pic1.jpg",
                        "C:\\Users\\jenje\\source\\repos\\MyClothingStore\\MyClothingStore\\wwwroot\\imageTest\\w_pic4.jpg",
                        "C:\\Users\\jenje\\source\\repos\\MyClothingStore\\MyClothingStore\\wwwroot\\imageTest\\w_pic6.jpg"
                    }),

                new Product (
                    Guid.NewGuid(),
                    "T-shirt",
                    "default t-shirt",
                    120,
                    new List<string> { "Blue", "Black", "Gray" },
                    new List<string> { "S", "M", "L" },
                    new List<int> { 1, 2, 3, 5 },
                    new List<string> {
                        "C:\\Users\\jenje\\source\\repos\\MyClothingStore\\MyClothingStore\\wwwroot\\imageTest\\pic2.jpg",
                        "C:\\Users\\jenje\\source\\repos\\MyClothingStore\\MyClothingStore\\wwwroot\\imageTest\\pic3.jpg",
                        "C:\\Users\\jenje\\source\\repos\\MyClothingStore\\MyClothingStore\\wwwroot\\imageTest\\pic6.jpg"
                    }),
            };
        }

        public List<Product> GetAll()
        {
            return productList;
        }
    }
}
