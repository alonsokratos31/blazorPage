using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp1.Shared.Entidades
{
    public class Peliculas
    {
        public int id { get; set; }
        [Required]
        public string Titulo { get; set; }
        public string Reseumen { get; set; }
        public bool EnCartelera { get; set; }
        public string Trailer { get; set; }
        [Required]
        public DateTime? Lanzamiento { get; set; }
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
