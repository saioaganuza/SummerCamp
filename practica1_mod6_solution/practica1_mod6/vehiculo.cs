using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1_mod6
{
    internal class vehiculo
    {
        public vehiculo()
        {
            
        }

        public vehiculo(int año, string marca, string modelo, string color)
        {
            Año = año;
            Marca = marca;
            Modelo = modelo;
            Color = color;
        }

        public vehiculo(int año, string color)
        {
            Año = año;
            Color = color;
            Marca = "Sin especificar";
            Modelo = "Sin especificar";
        }

        public vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Color = "Sin especificar";
            Año = 0;
        }

        public int Año { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        public void SacarDatos(vehiculo v, int pos)
        {
            Console.WriteLine("Vehículo " + pos + ": " + "Año:" + v.Año +  " Color:" + v.Color + " Marca:" + v.Marca + " Modelo:" + v.Modelo );
        }
    }
}
