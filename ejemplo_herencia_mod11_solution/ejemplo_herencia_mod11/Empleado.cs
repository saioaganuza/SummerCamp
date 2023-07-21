using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemplo_herencia_mod11
{
    public partial class Empleado //Clase padre
    {
        public string Nombre
        {
            get;set;
           
        }

        //public Empleado()
        //{
        //    Nombre = string.Empty;
        //}
        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

       
        public override string ToString()
        {
            return $"[Empleado. Nombre: {Nombre} Vacaciones: {diasVacaciones.ToString()}]";
        }

         protected double diasVacaciones;

        public virtual void CalculoVacaciones()
        {
            diasVacaciones += 10;

        }
       

    }
}