using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GLOBALNET.Controllers
{
    public class HomeController : Controller
    {
        private Models.CajabdEntities bd = new Models.CajabdEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Caja()
        {
            return View();
        }
        public ActionResult Admin()
        {
            return View();
        }
        public ActionResult ReporteDia()
        {
            return View();
        }
        public ActionResult ReporteDetallado()
        {
            return View();
        }
        //metodo para agregar sesiones 
        public ActionResult Login(string usuario, string clave)
        {
            var u = bd.usuario.FirstOrDefault(x => x.nombre_usuario== usuario && x.dni_usuario== clave);
            if (u != null)
            {
                Helper.SessionHelper.AddUserToSession(u.id_usuario.ToString());
            }
            return RedirectToAction("Caja", "Home");
        }

        public ActionResult Logout()
        {
            Helper.SessionHelper.DestroyUserSession();
            return RedirectToAction("Index", "Home");
        }


        public static string ObtenerNombreUsuario()
        {
            using (var b = new Models.CajabdEntities())
            {
                return b.usuario.Find(Helper.SessionHelper.GetUser()).nombre_usuario;
            }
        }


    }
}