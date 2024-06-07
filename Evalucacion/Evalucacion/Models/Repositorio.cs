using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Repositorio<T>
    {
        private List<T> elementos = new List<T>();

        public void Agregar(T elemento)
        {
            elementos.Add(elemento);
        }

        public void Eliminar(T elemento)
        {
            elementos.Remove(elemento);
        }

        public List<T> Buscar(Func<T, bool> criterio)
        {
            return elementos.Where(criterio).ToList();
        }
    }
}


