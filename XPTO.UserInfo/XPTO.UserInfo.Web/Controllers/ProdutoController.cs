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
    public class ProdutoController : BaseController
    {
        // GET: Produto
        public ActionResult Index()
        {
            ViewBag.usuarios = xs.ConsultaUsuariosAtivos();
            ViewBag.resposta = "";

            return View();
        }

        [HttpPost]
        public ActionResult IndexPost(int usuario, string nome_produto)
        {
            ViewBag.usuarios = xs.ConsultaUsuariosAtivos();
            ViewBag.resposta = xi.InserirProduto(usuario,nome_produto);

            return View("Index");
        }

    }
}
