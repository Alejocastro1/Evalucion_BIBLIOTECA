using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Utilidades
    {
        public static DateTime CalcularFechaDevolucion(DateTime fechaPrestamo, int diasPrestamo)
        {
            return fechaPrestamo.AddDays(diasPrestamo);
        }
    }
}

