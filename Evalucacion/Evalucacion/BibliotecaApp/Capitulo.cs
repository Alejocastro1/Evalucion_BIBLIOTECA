using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp
{
    public class Capitulo
    {
        public string Titulo { get; set; }
        public int Numero { get; set; }

        public Capitulo(string titulo, int numero)
        {
            Titulo = titulo;
            Numero = numero;
        }
    }
}