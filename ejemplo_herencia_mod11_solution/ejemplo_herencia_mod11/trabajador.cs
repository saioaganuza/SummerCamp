using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemplo_herencia_mod11
{
    public class Trabajador : Empleado
    {
        public Trabajador(string nombre, string turno) : base(nombre) //Obligatorio pasarle el nombre, puedo no tener esta obligación si creo el ctor vacío de Empleado en la clase padre (Enmpleado)
        {
            
            Turno = turno;
        }

        public string Turno { get; set; }

        public override string ToString()
        {
            return $"[Trabajador. Nombre: {Nombre} Vacaciones: {diasVacaciones.ToString()}]";
        }

        public override void CalculoVacaciones()
        {
            base.CalculoVacaciones();
            diasVacaciones += 15;

        }
    }
}