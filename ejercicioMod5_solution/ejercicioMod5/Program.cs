using System.Runtime.Intrinsics;

namespace ejercicioMod5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Vehiculo>();
            var v1 = new Vehiculo(1000,Vehiculo.TipoEtiqueta.CERO, 2014);
            var v2 = new Vehiculo(2000,Vehiculo.TipoEtiqueta.sin, 2006);
            var v3 = new Vehiculo(2000,Vehiculo.TipoEtiqueta.B, 2018);
            var v4 = new Vehiculo(5000,Vehiculo.TipoEtiqueta.C, 2010);
            var v5 = new Vehiculo(5500,Vehiculo.TipoEtiqueta.ECO, 2005);

            lista.Add(v1);
            lista.Add(v2);
            lista.Add(v3);
            lista.Add(v4);
            lista.Add(v5);

            foreach (var vehiculo in lista)
            {
            Console.WriteLine("El valor incrementado del vehículo es "+ v1.SacarImpuesto(vehiculo));
            }
            


            
        }
    }
}