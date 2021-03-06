using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP4.Utils;
using TP4.Models;

namespace TP4.Controllers
{
    public class PizzaController : Controller
    {
        private readonly static List<Pizza> pizzas = FakeDb.Instance.pizzas;
        private readonly static List<Ingredient> ingredients = FakeDb.Instance.ingredients;
        private readonly static List<Pate> pates = FakeDb.Instance.pates;

        // GET: Pizza
        public ActionResult Index()
        {
            return View(pizzas);
        }

        // GET: Pizza/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pizza/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pizza/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                  //Pizza newPizza = new Pizza();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pizza/Edit/5
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

        // GET: Pizza/Delete/5
        public ActionResult Delete(int id)
        {
            return View(pizzas.Where(c => c.Id == id).FirstOrDefault());
        }

        // POST: Pizza/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                Models.Pizza pizza = pizzas.Where(c => c.Id == id).FirstOrDefault();
                pizzas.Remove(pizza);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
