using AppMVCLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMVCLogin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autenticar(Empleado usuario)
        {
            EmpleadoDao dao = new EmpleadoDao();
            try
            {
                var usuario1 = dao.validarLogin(usuario.Nombre, usuario.Apellidos);
                if (usuario1 == null)
                {
                    usuario.LoginErrorMessage = "El usuario o password es incorrecto.";
                    return View("Index", usuario);
                }
                else
                {
                    //CREAR SESSION Y ASIGNAR VALORES
                    Session["userID"] = usuario.IdEmpleado;
                    Session["userName"] = usuario.Nombre;
                    Session["userLastName"] = usuario.Apellidos;
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public ActionResult LogOut()
        {
            //recuparar valor de la variable de session
            int userId = (int)Session["userID"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }


    }
}