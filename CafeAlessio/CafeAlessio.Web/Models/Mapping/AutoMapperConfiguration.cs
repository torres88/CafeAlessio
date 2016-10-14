using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CafeAlessio.Web.Models.Mapping
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
            });
        }
    }
}