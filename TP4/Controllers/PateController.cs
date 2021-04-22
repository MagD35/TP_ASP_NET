using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP4.Controllers
{
    public class PateController : Controller
    {
        // GET: Pate
        public ActionResult Index()
        {
            return View();
        }

        // GET: Pate/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pate/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pate/Create
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

        // GET: Pate/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pate/Edit/5
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

        // GET: Pate/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pate/Delete/5
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
