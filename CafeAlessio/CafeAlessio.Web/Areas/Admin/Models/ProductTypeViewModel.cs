using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CafeAlessio.Web.Areas.Admin.Models
{
    public class ProductTypeViewModel : ViewModelBase
    {
        public string NameHun { get; set; }

        public string NameEng { get; set; }

        public string NameIta { get; set; }
    }
}