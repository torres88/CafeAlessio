using AutoMapper;
using CafeAlessio.Domain.Entities;
using CafeAlessio.Service;
using CafeAlessio.Service.Abstract;
using CafeAlessio.Service.Concrete;
using CafeAlessio.Web.Areas.Admin.Models;
using CafeAlessio.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CafeAlessio.Web.Areas.Admin.Controllers
{
    public class UserController : AdminControllerBase<IUserService, UserEntity, UserViewModel>
    {
        public UserController(IUserService service,IMapper mapper)
            : base(service, mapper) { }

    }
}
