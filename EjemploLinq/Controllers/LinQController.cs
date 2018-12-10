using EjemploLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjemploLinq.Controllers
{
    public class LinQController : Controller
    {
        //instancia de la clase
        Ejemplo Db = new Ejemplo();
        // GET: LinQ
        public ActionResult Notas()
        {
            var listado = Db.Lista();

            return View(listado.ToList());

        }
        [HttpPost]
        public ActionResult Notas (string txtbuscar)
        {
            var listado = Db.Lista();
            var query = (from p in listado where p.materia.Contains(txtbuscar) select p);
            return View(query.ToList());
        }
    }
}