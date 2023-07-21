using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemplo_herencia_mod11
{
    public class Excepciones_bbdd :Exception
    {
        public string Mensaje { get; }
        public DateTime FechaHoraExcepcion { get; set; }

        public Excepciones_bbdd(string mensaje, DateTime fechaHoraExcepcion) : base(mensaje)
        {
            Mensaje = mensaje;
            FechaHoraExcepcion = fechaHoraExcepcion;
        }
    }
}