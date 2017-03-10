using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CafeAlessio.Web.Areas.Admin.Models
{
    public class DailyOfferViewModel : LocalizedViewModelBase
    {
        [Required]
        [Range(1, 500000)]
        public decimal Price { get; set; }
        public int Index { get; set; }
    }
}