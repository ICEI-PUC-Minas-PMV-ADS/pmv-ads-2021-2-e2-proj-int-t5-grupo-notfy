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
    public class NotificadorsController : Controller
    {
        private BD_NOTFYEntities db = new BD_NOTFYEntities();

        // GET: Notificadors
        public ActionResult Index()
        {
            return View(db.Notificador.ToList());
        }

        // GET: Notificadors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notificador notificador = db.Notificador.Find(id);
            if (notificador == null)
            {
                return HttpNotFound();
            }
            return View(notificador);
        }

        // GET: Notificadors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Notificadors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,Telefone,CPF,Email,Tipo,Usuario,Senha")] Notificador notificador)
        {
            if (ModelState.IsValid)
            {
                db.Notificador.Add(notificador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(notificador);
        }

        // GET: Notificadors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notificador notificador = db.Notificador.Find(id);
            if (notificador == null)
            {
                return HttpNotFound();
            }
            return View(notificador);
        }

        // POST: Notificadors/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,Telefone,CPF,Email,Tipo,Usuario,Senha")] Notificador notificador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notificador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notificador);
        }

        // GET: Notificadors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notificador notificador = db.Notificador.Find(id);
            if (notificador == null)
            {
                return HttpNotFound();
            }
            return View(notificador);
        }

        // POST: Notificadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Notificador notificador = db.Notificador.Find(id);
            db.Notificador.Remove(notificador);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult VerificarLogin(string usuario, string senha)
        {

            var usuarioLogin = usuario;
            var senhaLogin = senha;
            bool sucesso = false;
            
            var usuarioInfo = db.Notificador.SingleOrDefault(o => o.Usuario == usuarioLogin && o.Senha == senhaLogin);

            if (usuarioInfo != null)
            {
                var resultado = new
                {
                    sucesso = true,
                    nomeNotificador = usuarioInfo.Nome,
                    tipoUsuario = usuarioInfo.Tipo

                };

                return Json(resultado, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var resultado = new
                {
                    sucesso = false
                };
                return Json(resultado, JsonRequestBehavior.AllowGet);
            }

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
