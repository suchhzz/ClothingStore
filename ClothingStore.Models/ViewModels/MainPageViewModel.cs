using ClothingStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Models.ViewModels
{
    public class MainPageViewModel
    {
        public List<Product> Products { get; set; }
        public string SearchTitle { get; set; } = string.Empty;
    }
}
