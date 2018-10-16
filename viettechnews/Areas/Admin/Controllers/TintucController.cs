using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.DAO;

namespace viettechnews.Areas.Admin.Controllers
{
    public class TintucController : Controller
    {
        private viettechnewsDbContext db = new viettechnewsDbContext();

        // GET: /Admin/Tintuc/
        public ActionResult Index()
        {
            return View(db.Tintucs.OrderByDescending(x=>x.CreateDate).ToList());
        }

        // GET: /Admin/Tintuc/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tintuc tintuc = db.Tintucs.Find(id);
            if (tintuc == null)
            {
                return HttpNotFound();
            }
            return View(tintuc);
        }

        // GET: /Admin/Tintuc/Create
        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }

        // POST: /Admin/Tintuc/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="BlogId,Title,Brief,Content,Picture,CreateDate,CategoryId,CategoryChildId,Tags,ViewNo,Status,UserId,Seotitle")] Tintuc tintuc)
        {
            if (ModelState.IsValid)
            {
                tintuc.CreateDate = DateTime.Now;
                db.Tintucs.Add(tintuc);

                tintuc.ViewNo = 0;
                db.Tintucs.Add(tintuc);

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tintuc);
        }

        // GET: /Admin/Tintuc/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tintuc tintuc = db.Tintucs.Find(id);
            if (tintuc == null)
            {
                return HttpNotFound();
            }
            return View(tintuc);
        }

        // POST: /Admin/Tintuc/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="BlogId,Title,Brief,Content,Picture,CreateDate,CategoryId,CategoryChildId,Tags,ViewNo,Status,UserId,Seotitle")] Tintuc tintuc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tintuc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tintuc);
        }

        // GET: /Admin/Tintuc/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tintuc tintuc = db.Tintucs.Find(id);
            if (tintuc == null)
            {
                return HttpNotFound();
            }
            return View(tintuc);
        }

        // POST: /Admin/Tintuc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tintuc tintuc = db.Tintucs.Find(id);
            db.Tintucs.Remove(tintuc);
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

        public string ChangeImage(int? id, string picture)
        {
            if (id==null)
            {
                return "Mã không tồn tại";
            }
            Tintuc tin = db.Tintucs.Find(id);
            if (tin==null)
            {
                return "Mã không tồn tại";
            }
            tin.Picture = picture;
            db.SaveChanges();
            return "";
        }

        public void SetViewBag(long? selectedId = null)
        {
            var dao = new DanhmucDao();
            ViewBag.CategoryId = new SelectList(dao.ListDanhmuc(), "CategoryId", "CategoryName", selectedId);
        }
    }
}
