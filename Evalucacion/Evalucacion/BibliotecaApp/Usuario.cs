using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp
{
    public class Usuario : Persona, IBuscable<Libro>, IRegistrable
    {
        public List<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

        public Usuario(string nombre, string email) : base(nombre, email) { }

        public List<Libro> BuscarPorTitulo(string titulo)
        {
            return Prestamos
                .Select(p => p.Libro)
                .Where(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public void Registrar()
        {
            // Implementación del registro de usuario
        }

        public void Eliminar()
        {
            // Implementación de la eliminación de usuario
        }
    }
}


