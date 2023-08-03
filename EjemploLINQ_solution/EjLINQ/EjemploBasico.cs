using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjLINQ
{
    public class EjemploBasico
    {
        public EjemploBasico()
        {
        }

        public void Ejecutar()
        {

            string[] niveles = { "Basico", "Intermedio", "Avanzado" };
            int nc = niveles.Count();

            // Seleccionar todos los niveles cuya longitud en carácteres sea mayor que 6 y ordenado por nivel

            var listaConsultaForeach = new List<string>();
            foreach (string nivel in niveles)
            {
                if(nivel.Length > 6)
                {
                    listaConsultaForeach.Add(nivel);
                }
            }

            // Sintaxis SQL
            // Select nivel from niveles order by nivel

            var listaConsultaLinq = from nivel in niveles where nivel.Length > 6 select nivel;


            // Obtener resultados
            List<string> listaResultados = listaConsultaLinq.ToList(); // siempre hay una conversión a una lista 

            // Sintáxis de métodos
            //1- Preparación
            Func<string, bool> predicado = nivel => nivel.Length > 6;
            //var consultaLinqMetodos = niveles.Where(nivel => nivel.Length > 6);
            var consultalinqMetodos = niveles.Where(predicado).OrderBy(nivel => nivel).Select(nivel => nivel);
            //2- Resultados
            List<string> listaResultadosLinqMetodos = consultalinqMetodos.ToList();
        }
    }
}
