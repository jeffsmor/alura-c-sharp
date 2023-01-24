using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    public class Livro
    {
        public string Titulo { get; private set; }
        public string? Autor { get; set; }
        public string ISBN { get; private set; }
        public int Ano { get; set; }
        public string? EstiloLiterario { get; set; }
        public int NumeroDePaginas { get; set; }
        public string? Pais { get; set; }

        public Livro(string titulo, string ISBN)
        {
            this.Titulo = titulo;
            this.ISBN = ISBN;
        }
    }
}
