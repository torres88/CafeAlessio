using CafeAlessio.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CafeAlessio.Domain.Entities;
using System.Web.Mvc;

namespace CafeAlessio.Web.Areas.Admin.Models
{
    public class ProductViewModel : ViewModelBase
    {
        public string NameHun
        {
            get;
            set;
        }

        public string NameIta
        {
            get;
            set;
        }

        public string NameEng
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
            set;
        }

        //public ProductTypeEntity ProductType
        //{
        //    get;
        //    set;
        //}

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

        public int ProductTypeId { get; set; }

        public SelectList ProductTypeList { get; set; }
    }
}