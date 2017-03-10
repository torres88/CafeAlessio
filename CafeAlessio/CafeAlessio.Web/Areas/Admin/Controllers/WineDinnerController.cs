using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using CafeAlessio.Domain.Entities;
using CafeAlessio.Service.Abstract;
using CafeAlessio.Web.Areas.Admin.Models;

namespace CafeAlessio.Web.Areas.Admin.Controllers
{
    public class WineDinnerController : AdminControllerBase<IWineDinnerService, WineDinnerEntity, UserViewModel>
    {
        public WineDinnerController(IWineDinnerService service, IMapper mapper)
            : base(service, mapper) { }


        
    }
}
