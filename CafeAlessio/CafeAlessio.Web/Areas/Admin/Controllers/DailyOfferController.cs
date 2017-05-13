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
    public class DailyOfferController : AdminControllerBase<IDailyOfferService, DailyOfferItemEntity, DailyOfferViewModel>
    {
        public DailyOfferController(IDailyOfferService service, IMapper mapper)
            : base(service, mapper)
        {            
        }
    }
}