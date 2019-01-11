using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XPTO.UserInfo.Core;
using XPTO.UserInfo.Core.Model;

namespace XPTO.UserInfo.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            //ViewBag.UsuariosProdutos = xs.ConsultaUsuariosAtivos();

            return View(xs.UsuariosAtivosComProdutos());
        }

        public ActionResult Inserir()
        {
            ViewBag.PodeEnviarProduto = xs.ConsultaUsuarios().Count > 0;
            ViewBag.resposta = "";
            return View();
        }

        [HttpPost]
        public ActionResult InserirArquivo(string tipo, string Arquivo)
        {
            var httpRequest = Request.Files[0];

            StreamReader sr = new StreamReader(httpRequest.InputStream);
            string resposta = "";

            if (tipo == "U")
            {
                resposta = xi.InserirUsuarios(sr);
            }
            else
            {
                resposta = xi.InserirProdutos(sr);
            }
            ViewBag.PodeEnviarProduto = xs.ConsultaUsuarios().Count > 0;
            ViewBag.resposta = resposta;
            return View("Inserir");
        }

        public ActionResult DeleteProduto(int id)
        {
            xd.DeleteProduto(id);
            return View("Index", xs.UsuariosAtivosComProdutos());
        }

    }
}