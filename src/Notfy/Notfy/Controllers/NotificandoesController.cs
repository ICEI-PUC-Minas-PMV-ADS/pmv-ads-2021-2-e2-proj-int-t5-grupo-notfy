using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Notfy.Models;

namespace Notfy.Controllers
{
    public class NotificandoesController : Controller
    {
        private BD_NOTFYEntities db = new BD_NOTFYEntities();

        // GET: Notificandoes
        public ActionResult Index()
        {
            return View(db.Notificando.ToList());
        }

        // GET: Notificandoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notificando notificando = db.Notificando.Find(id);
            if (notificando == null)
            {
                return HttpNotFound();
            }
            return View(notificando);
        }

        // GET: Notificandoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Notificandoes/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,Telefone,CPF,Email,Endereco,CEP,Cidade,Estado")] Notificando notificando)
        {
            if (ModelState.IsValid)
            {
                db.Notificando.Add(notificando);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(notificando);
        }

        // GET: Notificandoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notificando notificando = db.Notificando.Find(id);
            if (notificando == null)
            {
                return HttpNotFound();
            }
            return View(notificando);
        }

        // POST: Notificandoes/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,Telefone,CPF,Email,Endereco,CEP,Cidade,Estado")] Notificando notificando)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notificando).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notificando);
        }

        // GET: Notificandoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notificando notificando = db.Notificando.Find(id);
            if (notificando == null)
            {
                return HttpNotFound();
            }
            return View(notificando);
        }

        // POST: Notificandoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Notificando notificando = db.Notificando.Find(id);
            db.Notificando.Remove(notificando);
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
