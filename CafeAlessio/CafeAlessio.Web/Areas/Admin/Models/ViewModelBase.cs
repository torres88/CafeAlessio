using CafeAlessio.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CafeAlessio.Web.Areas.Admin.Models
{
    public class ViewModelBase : IViewModel
    {
        public int Id { get; set; }

        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModificationDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}