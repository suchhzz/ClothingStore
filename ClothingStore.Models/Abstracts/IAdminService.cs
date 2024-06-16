using ClothingStore.Models.Models.Admin;
using ClothingStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Models.Abstracts
{
    public interface IAdminService
    {
        public Task<Guid> CreateProduct(CreateProduct createProduct);
    }
}
