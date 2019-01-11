using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using XPTO.UserInfo.Core;
using XPTO.UserInfo.Web.Models;

namespace XPTO.UserInfo.Web.Controllers
{
    public class UsuarioController : BaseController
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View(xs.ConsultaUsuarios());
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO uSUARIO = xs.ConsultaUsuarios().Find(u => u.Id == id);
            if (uSUARIO == null)
            {
                return HttpNotFound();
            }
            return View(uSUARIO);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,nome,sobrenome,dt_nascimento,sexo,email,ativo")] USUARIO uSUARIO)
        {
            if (ModelState.IsValid)
            {
                xi.InserirUsuario(uSUARIO);
                return RedirectToAction("Index");
            }

            return View(uSUARIO);
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO uSUARIO = xs.ConsultaUsuarios().Find(u => u.Id == id);
            if (uSUARIO == null)
            {
                return HttpNotFound();
            }
            return View(uSUARIO);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nome,sobrenome,dt_nascimento,sexo,email,ativo")] USUARIO uSUARIO)
        {
            if (ModelState.IsValid)
            {
                xu.AlterarUsuario(uSUARIO);
                return RedirectToAction("Index");
            }
            return View(uSUARIO);
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO uSUARIO = xs.ConsultaUsuarios().Find(u => u.Id == id);
            if (uSUARIO == null)
            {
                return HttpNotFound();
            }
            return View(uSUARIO);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            xd.DeleteUsuario(id);
            return RedirectToAction("Index");
        }

    }
}
