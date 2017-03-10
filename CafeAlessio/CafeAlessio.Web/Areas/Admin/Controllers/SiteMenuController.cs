using AutoMapper;
using CafeAlessio.Domain.Entities;
using CafeAlessio.Service.Abstract;
using CafeAlessio.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CafeAlessio.Web.Areas.Admin.Controllers
{
    public class SiteMenuController : AdminControllerBase<ISiteMenuService, SiteMenuEntity, SiteMenuViewModel>
    {
        public SiteMenuController(ISiteMenuService service, IMapper mapper)
            : base(service, mapper) { }
    }
}