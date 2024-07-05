using ClothingStore.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Models.Models.Admin
{
    public class OtherParametersModel
    {
        public List<ColorEntity> Colors { get; set; }
        public List<SizeEntity> Sizes { get; set; }
        public List<QualityEntity> Qualities { get; set; }
    }
}
