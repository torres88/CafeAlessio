using CafeAlessio.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CafeAlessio.Domain.Entities;

namespace CafeAlessio.Web.Areas.Admin.Models
{
    public class ProductViewModel : ViewModelBase
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

        public MeasureEnum Measure
        {
            get;
            set;
        }

        public bool IsSpicy { get; set; }

        public bool IsVega { get; set; }
    }
}