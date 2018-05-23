using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FullTreino.Models;

namespace FullTreino.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/

        private static Usuarios _usuarios = new Usuarios();

        public ActionResult Index()
        {
            return View(_usuarios.listaUsuarios);
        }

        public ActionResult AdicionaUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdicionaUsuario(UsuarioModel _usuarioModel)
        {
            _usuarios.CriaUsuario(_usuarioModel);
            return View();
        }
        public ViewResult DeletaUsuario(string id)
        {
            return View(_usuarios.GetUsuario(id));

        }

        [HttpPost]
        public RedirectToRouteResult DeletaUsuario(string id, FormCollection collection)
        {
            _usuarios.DeletarUsuario(id);
            return RedirectToAction("Index");
        }
    }
}