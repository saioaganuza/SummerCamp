using EjemploDelegados.Medios;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados
{
    public class InventarioMedios
    {
            //PUblic bool ProbarCD();
            //public bool ProbarVinilo();
            //public bool ProbarVideoVhs();
        public delegate bool ProbarMediosDelegado();

        //Delegado para mostrar info del medio
        public delegate string InfoMediosDelegado(string id);

        public void ResultadoProbarMedios(ProbarMediosDelegado probarMediosdelegado)
        {
            //var tipo = probarMediosdelegado.GetType().FullName;
            //if (tipo== "Tocadiscos")
            //{
            //    var obj = (Tocadiscos)probarMediosdelegado;
            //    if (obj.ProbarVinilo())
            //    {
            //        Console.WriteLine("Instrucciones para almacenar vinilo.");
            //    }
            //}

                //1- Recibir medio a probar
                //2- Probar el medio
                //3- Si el medio se ha podido reproducir indicar cómo archivarlo
            var resultadoPrueba = probarMediosdelegado();

            if (resultadoPrueba)
            {
                Console.WriteLine("El medio funciona, hay que agrgarlo al inventario.");

            }
            else
            {
                Console.WriteLine("El medio no funciona, debe ser destruido.");
            }

        }

        public void ResultadoinfoMedios(InfoMediosDelegado infoMedios, string codigoBarras)
        {
            Console.WriteLine(infoMedios(codigoBarras));
        }
    }
}
