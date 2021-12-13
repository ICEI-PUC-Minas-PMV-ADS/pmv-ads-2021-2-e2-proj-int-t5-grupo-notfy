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
    public class NotificacaosController : Controller
    {
        private BD_NOTFYEntities db = new BD_NOTFYEntities();

        // GET: Notificacaos
        public ActionResult Index()
        {
            var notificacao = db.Notificacao.Include(n => n.Notificador).Include(n => n.Notificando);
            return View(notificacao.ToList());
        }

        // GET: Notificacaos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notificacao notificacao = db.Notificacao.Find(id);
            if (notificacao == null)
            {
                return HttpNotFound();
            }
            return View(notificacao);
        }

        // GET: Notificacaos/Create
        public ActionResult Create()
        {
            ViewBag.NotificadorID = new SelectList(db.Notificador, "ID", "Nome");
            ViewBag.NotificandoID = new SelectList(db.Notificando, "ID", "Nome");
            return View();
        }

        // POST: Notificacaos/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NotificandoID,MatriculaImovel,NotificadorID,Sequencia,Tentativa1,Tentativa2,Tentativa3,Concluido,Observacao")] Notificacao notificacao)
        {
            if (ModelState.IsValid)
            {
                db.Notificacao.Add(notificacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NotificadorID = new SelectList(db.Notificador, "ID", "Nome", notificacao.NotificadorID);
            ViewBag.NotificandoID = new SelectList(db.Notificando, "ID", "Nome", notificacao.NotificandoID);
            return View(notificacao);
        }

        // GET: Notificacaos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notificacao notificacao = db.Notificacao.Find(id);
            if (notificacao == null)
            {
                return HttpNotFound();
            }
            ViewBag.NotificadorID = new SelectList(db.Notificador, "ID", "Nome", notificacao.NotificadorID);
            ViewBag.NotificandoID = new SelectList(db.Notificando, "ID", "Nome", notificacao.NotificandoID);
            return View(notificacao);
            
        }

        // POST: Notificacaos/Edit/5
        [HttpPost]
        
        public ActionResult Edit([Bind(Include = "ID,NotificandoID,MatriculaImovel,NotificadorID,Sequencia,Tentativa1,Tentativa2,Tentativa3,Concluido,Observacao")] Notificacao notificacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notificacao).State = EntityState.Modified;
                db.SaveChanges();

                ViewBag.Mensagem = "Tentativa registrada com sucesso!";
               
                return RedirectToAction("Index");
            }
            ViewBag.NotificadorID = new SelectList(db.Notificador, "ID", "Nome", notificacao.NotificadorID);
            ViewBag.NotificandoID = new SelectList(db.Notificando, "ID", "Nome", notificacao.NotificandoID);
            return View(notificacao);
        }

        // GET: Notificacaos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notificacao notificacao = db.Notificacao.Find(id);
            if (notificacao == null)
            {
                return HttpNotFound();
            }
            return View(notificacao);
        }

        // POST: Notificacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Notificacao notificacao = db.Notificacao.Find(id);
            db.Notificacao.Remove(notificacao);
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
