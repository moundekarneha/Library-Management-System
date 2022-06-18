using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Library_Management_System.Models;

namespace Library_Management_System.Controllers
{
    public class BooksController : Controller
    {
        private LibraryDBEntities db = new LibraryDBEntities();

        // GET: Books
        public ActionResult Index()
        {
            var books = db.Books.Include(b => b.Author).Include(b => b.Category).Include(b => b.Publisher);
            return View(books.ToList());
        }

        // GET: Books/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            ViewBag.a_id = new SelectList(db.Authors, "id", "name");
            ViewBag.c_id = new SelectList(db.Categories, "id", "catname");
            ViewBag.p_id = new SelectList(db.Publishers, "id", "name");
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,bname,c_id,a_id,p_id,contents,pages,edition")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.a_id = new SelectList(db.Authors, "id", "name", book.a_id);
            ViewBag.c_id = new SelectList(db.Categories, "id", "catname", book.c_id);
            ViewBag.p_id = new SelectList(db.Publishers, "id", "name", book.p_id);
            return View(book);
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            ViewBag.a_id = new SelectList(db.Authors, "id", "name", book.a_id);
            ViewBag.c_id = new SelectList(db.Categories, "id", "catname", book.c_id);
            ViewBag.p_id = new SelectList(db.Publishers, "id", "name", book.p_id);
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,bname,c_id,a_id,p_id,contents,pages,edition")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.a_id = new SelectList(db.Authors, "id", "name", book.a_id);
            ViewBag.c_id = new SelectList(db.Categories, "id", "catname", book.c_id);
            ViewBag.p_id = new SelectList(db.Publishers, "id", "name", book.p_id);
            return View(book);
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
