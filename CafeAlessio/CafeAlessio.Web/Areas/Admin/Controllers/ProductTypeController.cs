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
    public class ProductTypeController : AdminControllerBase<IProductTypeService, ProductTypeEntity, ProductTypeViewModel>
    {
        public ProductTypeController(IProductTypeService service, IMapper mapper)
            : base(service, mapper) { }
    }
}
