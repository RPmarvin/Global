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
            if (Helper.SessionHelper.ExistUserInSession())
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            //if (inicioSecion==0)
            //{
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Index", "Home");
            //}
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
            var usuarios = bd.usuario.FirstOrDefault(x => x.nombre_usuario== usuario && x.dni_usuario== clave);
            var cargo = bd.usuario.FirstOrDefault(x => x.nombre_usuario== usuario && x.dni_usuario== clave && x.cargo_usuario== "Caja");
            if (usuarios != null)
            {
                Helper.SessionHelper.AddUserToSession(usuarios.id_usuario.ToString());
                if (cargo != null)
                {
                    
                    return RedirectToAction("Caja", "Home");
                }
                else
                {
                    return RedirectToAction("usuarios", "administrador");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Logout()
        {
            Helper.SessionHelper.DestroyUserSession();
            return RedirectToAction("Index", "Home");
        }

        //public static string ObtenerNombreUsuario()
        //{
        //    using (var b = new Models.CajabdEntities())
        //    {
        //        return b.usuario.Find(Helper.SessionHelper.GetUser()).nombre_usuario;
        //    }
        //}
        

    }
}