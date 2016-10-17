using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Domain.Entities
{
    public class ProductEntity : EntityBase
    {
        public decimal Price
        {
            get;
            set;
        }

        public ProductType ProductType
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

        //public MeasureEnum Measure
        //{
        //    get;
        //    set;
        //}

    }
}
