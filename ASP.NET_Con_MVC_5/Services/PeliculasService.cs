using ASP.NET_Con_MVC_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_Con_MVC_5.Services
{
    public class PeliculasService
    {
        public Pelicula ObtenerPelicula()
        {
            return new Pelicula()
            {
                Titulo = "Escape Plan",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 2)
            };
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Escape Plan",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 2)
            };

            var pelicula2 = new Pelicula()
            {
                Titulo = "Captain America: Civil War",
                Duracion = 147,
                Pais = "USA",
                Publicacion = new DateTime(2016, 04, 29)
            };

            return new List<Pelicula> { pelicula1, pelicula2 };
        }
    }
}