using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Domain.Entities
{
    [Table("Product")]
    public class ProductEntity : LocalizedEntityBase
    {
        [Required]
        public decimal Price
        {
            get;
            set;
        }

        [Required]
        public ProductTypeEntity ProductType
        {
            get;
            set;
        }

        public string DescriptionHun
        {
            get;
            set;
        }

        public string DescriptionIta
        {
            get;
            set;
        }

        public string DescriptionEng
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

        [ForeignKey("ProductGroup")]
        public int ProductGroupId { get; set; }

        [Required]
        public ProductGroupEntity ProductGroup
        {
            get;
            set;
        }
    }
}
