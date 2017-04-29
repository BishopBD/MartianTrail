using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MartianTrail.Controllers
{
    public class SetupController : Controller
    {
        // GET: Setup
        public ActionResult Rocket()
        {
            return View();
        }

        public ActionResult CrewIntro()
        {
            return View();
        }

        // GET: Setup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Setup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Setup/Create
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

        // GET: Setup/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Setup/Edit/5
        [HttpPost]
        public ActionResult ChooseRocket(FormCollection collection)
        {
            try
            {
                var c= collection;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Setup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Setup/Delete/5
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
