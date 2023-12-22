using System;
using System.Collections.Generic;
using System.Text;

namespace Lab16.Model
{
    public class Libro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public int anio_publicacion { get; set; }
        public string genero { get; set; }
        public string editorial { get; set; }
        public bool disponible { get; set; }
    }
}
