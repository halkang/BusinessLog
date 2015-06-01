using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessLog.Models;

namespace BusinessLog.Controllers
{
    public class BussinessController : Controller
    {
        private FuBrotherEntities db = new FuBrotherEntities();
        CleMonReportNRepository repo = RepositoryHelper.GetCleMonReportNRepository();

   


        // GET: Bussiness
        public ActionResult Index()
        {
            return View(db.CleMonReportN.ToList());
        }

        // GET: Bussiness/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CleMonReportN cleMonReportN = db.CleMonReportN.Find(id);
            if (cleMonReportN == null)
            {
                return HttpNotFound();
            }
            return View(cleMonReportN);
        }

        // GET: Bussiness/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bussiness/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RowIndex,廢棄物來源是否為事業單位,委託單位名稱,委託單位證號,委託單位地址,縣市別代碼,行業別代碼,六聯單單號,廢棄物編號,清除量,清除日期,清除方法,貯存地點,中間或最終處置地點代碼,中間或最終處置到達日期,清運_x0028_除_x0029_機具車號,清運_x0028_除_x0029_機具拖車車尾車號")] CleMonReportN cleMonReportN)
        {
            if (ModelState.IsValid)
            {
                db.CleMonReportN.Add(cleMonReportN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cleMonReportN);
        }

        // GET: Bussiness/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CleMonReportN cleMonReportN = db.CleMonReportN.Find(id);
            if (cleMonReportN == null)
            {
                return HttpNotFound();
            }
            return View(cleMonReportN);
        }

        // POST: Bussiness/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RowIndex,廢棄物來源是否為事業單位,委託單位名稱,委託單位證號,委託單位地址,縣市別代碼,行業別代碼,六聯單單號,廢棄物編號,清除量,清除日期,清除方法,貯存地點,中間或最終處置地點代碼,中間或最終處置到達日期,清運_x0028_除_x0029_機具車號,清運_x0028_除_x0029_機具拖車車尾車號")] CleMonReportN cleMonReportN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cleMonReportN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cleMonReportN);
        }

        // GET: Bussiness/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CleMonReportN cleMonReportN = db.CleMonReportN.Find(id);
            if (cleMonReportN == null)
            {
                return HttpNotFound();
            }
            return View(cleMonReportN);
        }

        // POST: Bussiness/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CleMonReportN cleMonReportN = db.CleMonReportN.Find(id);
            db.CleMonReportN.Remove(cleMonReportN);
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
