using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVC.Controllers
{
    public class HomeController : Controller
    {
        //Un controlador esta compuesto por acciones y se navega por los controladores desde la URL

        // GET: Home
        //localhost/home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Alumno()
        {
            return View();
        }
    }
}