using AutoMapper;
using CafeAlessio.Domain;
using CafeAlessio.Domain.Entities;
using CafeAlessio.Service;
using CafeAlessio.Service.Abstract;
using CafeAlessio.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CafeAlessio.Web.Areas.Admin.Controllers
{
    public class AdminControllerBase<TService, TEntity, TViewModel> : Controller
        where TService : ICafeAlessioService<TEntity>
        where TEntity : IEntity
        where TViewModel : IViewModel
    {
        private readonly TService _service;
        private readonly IMapper _mapper;

        public AdminControllerBase(TService service, IMapper mapper)
        {
            this._service = service;
            this._mapper = mapper;
        }

        public virtual ActionResult Index()
        {
            return View(_mapper.Map<IEnumerable<TViewModel>>(this._service.List()));            
        }

        public virtual ActionResult Edit(int id)
        {
            return View(this._service.GetById(id));
        }

        [HttpPost]
        public virtual ActionResult Edit(TEntity entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this._service.Update(entity);

                }
            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("Index");
        }

        public virtual ActionResult Create()
        {
            return View(Activator.CreateInstance<TEntity>());
        }

        [HttpPost]
        public virtual ActionResult Create(TEntity entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this._service.Create(entity);

                }
            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("Index");
        }

    }
}
