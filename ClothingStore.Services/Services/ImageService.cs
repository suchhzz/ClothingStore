using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using ClothingStore.Models.Abstracts;

namespace ClothingStore.Services.Services
{
    public class ImageService : IImageService
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        public ImageService(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }
        public async Task<List<string>> SaveImages(List<IFormFile> images)
        {
            List<string> imagePathUrl = new List<string>();

            string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "imageTest");

            if (images != null)
            {
                foreach (var image in images)
                {
                    string fileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                    string filePath = Path.Combine(uploadsFolder, fileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await image.CopyToAsync(fileStream);
                    }

                    imagePathUrl.Add(filePath);
                }
            }

            return imagePathUrl;
        }
    }
}
