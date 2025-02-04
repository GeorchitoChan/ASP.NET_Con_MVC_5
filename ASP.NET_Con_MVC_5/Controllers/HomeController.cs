using ASP.NET_Con_MVC_5.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ASP.NET_Con_MVC_5.Controllers
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            var persona1 = new Persona() { Nombre = "Jorge", Edad = 22 };
            var persona2 = new Persona() { Nombre = "Neri", Edad = 68 };
            return Json(new List<Persona>() { persona1, persona2 }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var peliculasService = new PeliculasService();
            var model = peliculasService.ObtenerPeliculas();

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public FileResult DownloadFile()
        {
            return File("/Files/File Result.pdf", "text/plain", "File Result.pdf");
        }

        public ContentResult ContentResult()
        {
            return Content("Jorge");
        }
    }
}