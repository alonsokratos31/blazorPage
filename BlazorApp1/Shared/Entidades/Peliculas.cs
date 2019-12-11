using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Shared.Entidades
{
    public class Peliculas
    {
        public string Titulo { get; set; }
        public DateTime Lanzamiento { get; set; }
        public string Poster { get; set; }
        public string TituloCortado
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Titulo))
                {
                    return null;
                }

                if (Titulo.Length > 60)
                {
                    return Titulo.Substring(0, 60) + "...";
                }

                else
                {
                    return Titulo;
                }
            }
        }
    }
}
