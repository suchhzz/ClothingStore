using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Models.Abstracts
{
    public interface IImageService
    {
        public Task<List<string>> SaveImages(List<IFormFile> images);
    }
}
