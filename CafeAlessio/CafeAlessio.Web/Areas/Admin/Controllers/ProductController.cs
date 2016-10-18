using AutoMapper;
using CafeAlessio.Domain.Entities;
using CafeAlessio.Service.Abstract;
using CafeAlessio.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CafeAlessio.Web.Areas.Admin.Controllers
{
    public class ProductController : AdminControllerBase<IProductService, ProductEntity, ProductViewModel>
    {
        public ProductController(IProductService service, IMapper mapper)
            : base(service, mapper) { }
    }
}