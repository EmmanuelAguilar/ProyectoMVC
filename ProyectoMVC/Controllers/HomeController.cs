using Models;
using System.Web.Mvc;

namespace ProyectoMVC.Controllers
{
    public class HomeController : Controller
    {
        //Un controlador esta compuesto por acciones y se navega por los controladores desde la URL

        Alumno oAlumno = new Alumno();

        public ActionResult Index()
        {
            return View(Alumno.Listar()); //Se le pasa a la vista el modelo, en la vista se tendra que especificar el modelo a utilizar
        }

        public ActionResult Ver(int id)
        {
            return View(oAlumno.Obtener(id));
        }

        public ActionResult Crud(int id = 0) //Insertar o actualizar un nuevo registro de alumnos
        {
            return View(
                id == 0 ? new Alumno()              //nuevo alumno
                        : oAlumno.Obtener(id)       //Update
                );
        }

        public ActionResult Guardar(Alumno model)
        {
            if (ModelState.IsValid)
            {
                model.Guardar();
                return Redirect("~/Home");
            }else
            {
                return View("~/Views/Home/Crud.cshtml", model);
            }
            
        }

        public ActionResult Eliminar(int id)
        {
            oAlumno.id = id;
            oAlumno.Eliminar();
            return Redirect("~/Home");
        }
    }
}