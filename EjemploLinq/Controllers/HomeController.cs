using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploLinq.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int[] numeros = { 2, 4, 5, 8, 100, -5, -2, 9, 50, 42, 8, 40 };
            var queryn =from n in numeros orderby n ascending select n;
            
            /*where (n%2).Equals(0)/*>5 && n<40*/
            /*numeros.Where(n => n == 100); */
            ViewBag.datos = queryn;
            return View();
        }
        public ActionResult prueba()
        {
            List<string> materias = new List<string>()
            {
                "Matematicas",
                "Algoritmia",
                "MVC Basico",
                "Historial del Internet",
                "Use Tools",
                "LinQ"
            };
            var query = from n in materias
                        where n.StartsWith("m")
                        select n;
            return View(query.ToList());
        }

    }
}