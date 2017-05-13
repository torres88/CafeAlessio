using CafeAlessio.Web.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CafeAlessio.Web.Areas.Admin.Models
{
    public class ViewModelBase : IViewModel
    {
        public int Id { get; set; }

        public bool Active { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreationDate { get; set; }
        [ScaffoldColumn(false)]
        public string CreatedBy { get; set; }
        [ScaffoldColumn(false)]
        public DateTime ModificationDate { get; set; }
        [ScaffoldColumn(false)]
        public string ModifiedBy { get; set; }
    }
}