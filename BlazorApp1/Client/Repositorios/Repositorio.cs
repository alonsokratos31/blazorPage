using BlazorApp1.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Peliculas> ObtenerPeliculas()
        {
            return new List<Peliculas>()
            {
                new Peliculas(){Titulo = "La Momia",Lanzamiento= new DateTime(2019,11,10)},
                new Peliculas(){Titulo = "Avengers",Lanzamiento= new DateTime(2019,11,10)},
                new Peliculas(){Titulo = "Joker",Lanzamiento= new DateTime(2019,11,10)}
            };

        }
    }
}
