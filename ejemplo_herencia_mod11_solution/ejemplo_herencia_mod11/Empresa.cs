using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemplo_herencia_mod11
{
    public class Empresa
    {
        public Empresa(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }

        public Empresa()
        {
            
        }

        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }
}