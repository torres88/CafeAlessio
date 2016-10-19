using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Domain.Entities
{
    [Table("Product")]
    public class ProductEntity : EntityBase
    {
        public decimal Price
        {
            get;
            set;
        }

        public ProductTypeEntity ProductType
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string ImageName
        {
            get;
            set;
        }

        public decimal Unit
        {
            get;
            set;
        }

        public MeasureEnum Measure
        {
            get;
            set;
        }

        public bool IsSpicy { get; set; }

        public bool IsVega { get; set; }

        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }

    }
}
