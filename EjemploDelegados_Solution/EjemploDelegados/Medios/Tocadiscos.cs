using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados.Medios
{
    public class Tocadiscos
    {
        public Tocadiscos()
        {
        }

        public bool ProbarVinilo()
        {
            Console.WriteLine("Por favor, ponga el disco en el tocadiscos");
            Console.WriteLine("Indique a continuación si ha escuchado algo S/N");
            var result = Console.ReadLine();

            // Equivale a if (result=="S")/else
            return result == "S";
        }

        public string ObtenerCancionesDisco (string codigoBarras)
        {
            //Buscar BBDD codigoBarras
            //Devolver resultado
            return "La lista de canciones está en la contraportada";
        }

    }
}
