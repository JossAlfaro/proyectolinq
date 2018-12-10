using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploLinq.Models
{
    public class Ejemplo
    {
        public int carnet { get; set; }
        public string nombre { get; set; }
        public string materia { get; set; }
        public decimal promedio { get; set; }
        public DateTime fecha { get; set; }

        public List<Ejemplo> Lista()
        {
            var estudiante1 = new Ejemplo()
            {
                carnet = 001,
                nombre = "Maria",
                materia = "Gestion de Bases de Datos",
                promedio = 8,
                fecha = DateTime.Now
            };

            var estudiante2 = new Ejemplo()
            {
                carnet = 002,
                nombre = "Juan",
                materia = "LinQ",
                promedio = 6,
                fecha = DateTime.Now
            };

            var estudiante3 = new Ejemplo()
            {
                carnet = 003,
                nombre = "Miguel",
                materia = "Mvc Basico",
                promedio = 7,
                fecha = DateTime.Now
            };

            var estudiante4 = new Ejemplo()
            {
                carnet = 004,
                nombre = "Juan",
                materia = "Historial del Internet",
                promedio = 6,
                fecha = DateTime.Now
            };

            return new List<Ejemplo>() { estudiante1, estudiante2, estudiante3, estudiante4 };
        }
    }
  
    

}