using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp
{
    public class Autor : Persona
    {
        public List<Libro> Libros { get; set; } = new List<Libro>();

        public Autor(string nombre, string email) : base(nombre, email) { }
    }
}
