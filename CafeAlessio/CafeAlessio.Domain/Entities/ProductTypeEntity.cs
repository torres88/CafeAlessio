using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Domain.Entities
{
    [Table("ProductType")]
    public class ProductTypeEntity : LocalizedEntityBase
    {
        public ProductTypeEntity SubProductType { get; set; }

        public List<ProductEntity> Products { get; set; }
    }
}
