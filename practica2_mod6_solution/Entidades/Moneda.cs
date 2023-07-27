using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entidades
{
    public class Moneda
    {
        public Moneda()
        { 
        }
        public Moneda(string id,string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public string Id { get; set; }
        public string Nombre { get; set; }
    }
}
