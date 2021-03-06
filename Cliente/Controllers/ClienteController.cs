using Cliente.Context;
using Cliente.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Cliente.Controllers
{
    public class ClienteController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = db.Cliente.ToList();
            return View(cliente);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteModel cliente)
        {
            if (ModelState.IsValid)
            {
                db.Cliente.Add(cliente);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        [HttpGet]
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ClienteModel cliente = db.Cliente.Find(Id);

            if (cliente == null)
            {
                return HttpNotFound();
            }

            return View(cliente);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ClienteModel cliente)
        {
            db.Entry(cliente).State = EntityState.Deleted;
            db.SaveChanges();
            return View(nameof(Index));
        }
    }
}