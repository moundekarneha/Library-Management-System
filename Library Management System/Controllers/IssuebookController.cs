using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library_Management_System.Models;

namespace Library_Management_System.Controllers
{
    public class IssuebookController : Controller
    {
        LibraryDBEntities db = new LibraryDBEntities();
        // GET: Issuebook
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetBook()
        {
            var book = db.Books.Select(p => new
            {
                ID = p.id,
                Bname = p.bname

            }).ToList();
            return Json(book, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult GetMid(int m_id)
        {
            var memberid = (from s in db.Members where s.id == m_id select s.name).ToList();
            return Json(memberid, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Save(Issuebook issue)
        {
            if (ModelState.IsValid)
            {
                db.Issuebooks.Add(issue);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(issue);
        }

    }
}