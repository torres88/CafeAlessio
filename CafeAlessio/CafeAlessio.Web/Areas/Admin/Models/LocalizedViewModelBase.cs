using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CafeAlessio.Web.Areas.Admin.Models
{
    public class LocalizedViewModelBase : ViewModelBase
    {
        [Required]
        public string NameHUN { get; set; }
        public string NameENG { get; set; }
        public string NameITA { get; set; }
    }
}