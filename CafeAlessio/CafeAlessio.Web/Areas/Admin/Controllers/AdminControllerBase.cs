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
        protected readonly TService _service;
        protected readonly IMapper _mapper;

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
            return View(_mapper.Map<TViewModel>(this._service.GetById(id)));
        }

        [HttpPost]
        public virtual ActionResult Edit(TViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this._service.Update(_mapper.Map<TEntity>(viewModel));

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
            return View(Activator.CreateInstance<TViewModel>());
        }

        [HttpPost]
        public virtual ActionResult Create(TViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    this._service.Create(_mapper.Map<TEntity>(viewModel));

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
