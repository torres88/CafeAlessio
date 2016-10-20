using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using Microsoft.AspNet.Http;

namespace CafeAlessio.Web.Areas.Admin.Models
{
    public class WineDinnerViewModel
    {
        public string ShortName { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string ImageName { get; set; }
        public string ImageFile { get; set; }
        public bool Active { get; set; }

        //public IFormFile Picture { get; set; }

    }
}