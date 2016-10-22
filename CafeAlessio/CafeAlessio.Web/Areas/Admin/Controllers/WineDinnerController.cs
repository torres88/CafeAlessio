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


        // GET: Admin/WineDinner
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/WineDinner/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/WineDinner/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/WineDinner/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/WineDinner/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/WineDinner/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/WineDinner/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/WineDinner/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
