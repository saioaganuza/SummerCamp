using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemplo_herencia_mod11
{
    public class Administrador : Empleado
    {
        public Administrador(string nombre, bool Tieneplaza) : base(nombre)
        {
            this.Tieneplaza = Tieneplaza;
        }

        public bool Tieneplaza { get; set; }

        public override string ToString()
        {
            return $"[Administrativo. Nombre: {Nombre} Vacaciones: {diasVacaciones.ToString()}]";
        }

        public override void CalculoVacaciones()
        {
            diasVacaciones += 9;

        }

        public string PlazaParking()
        {
            // TODO: Conectar a BBDD
            throw new Excepciones_bbdd("Error al conectar a BBDD", DateTime.Now);
            return Tieneplaza ? "Plaza A-1" : "no tiene plaza.";
        }
    }
}