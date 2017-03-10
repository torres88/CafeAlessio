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
    public class ProductController : AdminControllerBase<IProductService, ProductTypeEntity, ProductViewModel>
    {
        private readonly IProductTypeService _productTypeService;

        public ProductController(IProductService service, IProductTypeService productTypeService, IMapper mapper)
            : base(service, mapper)
        {
            _productTypeService = productTypeService;
        }

        public override ActionResult Create()
        {
            ProductViewModel viewModel = Activator.CreateInstance<ProductViewModel>();
            viewModel.ProductTypeList = new SelectList(this._mapper.Map<IEnumerable<ProductTypeViewModel>>(this._productTypeService.List()), "Id", "Value"); 
            return View(viewModel);            
        }
    }
}