using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using CafeAlessio.Domain.Entities;
using CafeAlessio.Service;
using CafeAlessio.Service.Concrete;
using CafeAlessio.Web.Areas.Admin.Models;
using CafeAlessio.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CafeAlessio.Web.App_Start
{
    public class Bootstrapper
    {
        public static void Run()
        {
            DatabaseService.InitDB();

            SetAutofacContainer();
        }

        private static void SetAutofacContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            
            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            //builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            // Register our Data dependencies
            builder.RegisterModule(new ServiceModule());

            // Services
            builder.RegisterAssemblyTypes(typeof(UserService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();

            //Mapper.Initialize(cfg => cfg.CreateMap<UserEntity, UserViewModel>());
            //Mapper.Initialize(cfg => cfg.CreateMap<UserEntity, UserViewModel>());
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserEntity, UserViewModel>();
                cfg.CreateMap<UserViewModel, UserEntity>();
                cfg.CreateMap<ProductTypeViewModel, ProductTypeEntity>();
                cfg.CreateMap<SiteMenuViewModel, SiteMenuEntity>();
                cfg.CreateMap<DailyOfferViewModel, DailyOfferEntity>();
                //.ForMember(d => d.Email, o => o.MapFrom(src => src.Email));

                cfg.CreateMap<ProductEntity, ProductViewModel>();
                cfg.CreateMap<ProductViewModel,ProductEntity>();
                cfg.CreateMap<ProductTypeEntity,ProductTypeViewModel>();
                cfg.CreateMap<SiteMenuEntity, SiteMenuViewModel>();
                cfg.CreateMap<DailyOfferEntity, DailyOfferViewModel>();
                // .ForMember(d => d., o => o.MapFrom(src => src.Email));
            });

            IMapper mapper = config.CreateMapper();

            builder.RegisterInstance<IMapper>(mapper);

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
