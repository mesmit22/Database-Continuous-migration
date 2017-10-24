using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using database.Models;

namespace database.Controllers
{
    public class HomeController : Controller
    {
        private TestDatabaseContext db = new TestDatabaseContext();

        public ActionResult Index()
        {
            return View(db.Todoes.ToList());
        }

        public ActionResult Create()
        {
            return View(new Todo { DueDate = DateTime.Today.AddDays(2) });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TodoTitle,DueDate,Priority")] Todo todo)
        {
            if (ModelState.IsValid)
            {
                db.Todoes.Add(todo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(todo);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}