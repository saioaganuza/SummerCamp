using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Conversor
    {
        public  List<Moneda> listaMonedas { get; set; }
        public  List<Factor> listaFactores { get; set; }

        
        public Conversor()
        {
            listaMonedas = new List<Moneda>() { new Moneda("EUR", "euros"), new Moneda("USD", "dolares"), new Moneda("GBP", "libras") };
            listaFactores = new List<Factor>() { new Factor("EUR", "USD", 1.12), new Factor("USD", "GBP", 0.77), new Factor("GBP", "EUR", 0.87) };
        }
        public static double CambioMoneda(double importe, string moneda1, string moneda2)
        {
            Conversor conversor = new Conversor();
            double factor=0;
            foreach (var item  in conversor.listaFactores)
            { 
                if (item.Origen == moneda1)
                {
                    foreach (var item2 in conversor.listaFactores)
                    {   
                        if (item2.Destino == moneda2)
                        {
                            factor = item2.Fact;
                        }

                    }

                }

            }
            return importe * factor;

            

        }

        public static string SacarSimbolo(string moneda2)
        {   
            Conversor conversor = new Conversor();
            string nombre = "";
            foreach (var item2 in conversor.listaMonedas)
            {
                if (item2.Id == moneda2)
                {
                    nombre = item2.Nombre;
                }

            }
             return nombre;

        }
    }
}
