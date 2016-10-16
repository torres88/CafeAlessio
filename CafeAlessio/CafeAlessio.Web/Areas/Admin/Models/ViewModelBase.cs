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
    }
}