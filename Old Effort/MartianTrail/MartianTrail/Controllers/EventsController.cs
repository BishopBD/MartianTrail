using MartianTrail.Models;
using MartianTrail.Models.Crew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MartianTrail.Controllers
{
    public class EventsController : Controller
    {
        // GET: Setup
        public ActionResult Rocket()
        {
            return View();
        }

        //CompleteSetup
        [HttpPost]
        public ActionResult CompleteSetup(CompletedSetup_VM completedSetup)
        {
 
                return View("GeneralEvent");
 
        }

        // GET: Setup/Details/5
        public ActionResult GeneralEvent()
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
        public ActionResult StartEvents(FormCollection collection)
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
