using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados.Medios
{
    public class ReproductorCDS
    {
        public bool ProbarDC()
        {
            Console.WriteLine("por favor, ponga el CD en el reproductor.");
            Console.WriteLine("Pulse el botón de reproduccitón.");
            Console.WriteLine("Indique a continuación si ha escuchado algo");
            var result = Console.ReadLine();

            // Equivale a if (result=="S")/else
            return result == "S";
        }
        public string ObtenerCancionesCD(string codigoBarras)
        {
            //Buscar BBDD codigoBarras
            //Devolver resultado
            return "Mostrando la lista de canciones del disco";
        }

    }
}
