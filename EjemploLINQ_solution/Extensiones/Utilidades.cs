using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extensiones
{
    public static class Utilidades
    {
        public static string ConvertirCadena(this string cadena) //El this es para poder invocar al método así: juan.ConvertirCadena();
        {
            return cadena.Trim().ToUpper() + "." ;
        }

        public static int ObtenerAño (this DateTime dateTime)
        {
            return dateTime.Year;
        }

        public static bool EsMayorQue (this int numero, int numero2)
        {
            return numero > numero2;
        }

        public static int Primero(this List<int> lista)
        {
            return lista[0];
            //return lista.FirstOrDefault
        }
    }
    
}
