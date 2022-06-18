using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library_Management_System.Models;
using System.Data.Entity.SqlServer;

namespace Library_Management_System.Controllers
{
    public class ReturnbookController : Controller
    {
        LibraryDBEntities db = new LibraryDBEntities();
        // GET: Returnbook
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save(Returnbook returnbook)
        {
            if(ModelState.IsValid)
            {
                db.Returnbooks.Add(returnbook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult getMid(int m_id)
        {
            var memberid = (from s in db.Issuebooks
                            where s.m_id == m_id
                            select new
                            {
                                Issuedate = s.issuedate,
                                Returndate = s.returndate,
                                MemberId = s.m_id,
                                Bookname = s.book,
                                ElapsedDays = SqlFunctions.DateDiff("day", DateTime.Now, s.returndate)

                            }).ToArray();
            return Json(memberid, JsonRequestBehavior.AllowGet);
        }
    }
}