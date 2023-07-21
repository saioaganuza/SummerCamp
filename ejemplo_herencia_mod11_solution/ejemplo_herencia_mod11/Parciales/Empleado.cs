using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_herencia_mod11
{
    public partial class Empleado
    {
        public string? Telefono { get; set; }
        public Empleado Jefe { get; set; }
    }
}
