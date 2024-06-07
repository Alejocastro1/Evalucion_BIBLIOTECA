using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Email { get; set; }

        protected Persona(string nombre, string email)
        {
            Nombre = nombre;
            Email = email;
        }
    }
}
