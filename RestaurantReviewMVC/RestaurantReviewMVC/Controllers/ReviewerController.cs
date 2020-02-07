using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RestaurantReviewMVC.DAL;
using RestaurantReviewMVC.Models;

namespace RestaurantReviewMVC.Controllers
{
    public class ReviewerController : Controller
    {
        private ReviewContext db = new ReviewContext();

        // GET: Reviewer
        public ActionResult Index()
        {
            return View(db.Reviewers.ToList());
        }

        // GET: Reviewer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reviewer reviewer = db.Reviewers.Find(id);
            if (reviewer == null)
            {
                return HttpNotFound();
            }
            return View(reviewer);
        }

        // GET: Reviewer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviewer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReviewerID,Name,JoinDate")] Reviewer reviewer)
        {
            if (ModelState.IsValid)
            {
                db.Reviewers.Add(reviewer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reviewer);
        }

        // GET: Reviewer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reviewer reviewer = db.Reviewers.Find(id);
            if (reviewer == null)
            {
                return HttpNotFound();
            }
            return View(reviewer);
        }

        // POST: Reviewer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReviewerID,Name,JoinDate")] Reviewer reviewer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reviewer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reviewer);
        }

        // GET: Reviewer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reviewer reviewer = db.Reviewers.Find(id);
            if (reviewer == null)
            {
                return HttpNotFound();
            }
            return View(reviewer);
        }

        // POST: Reviewer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reviewer reviewer = db.Reviewers.Find(id);
            db.Reviewers.Remove(reviewer);
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
