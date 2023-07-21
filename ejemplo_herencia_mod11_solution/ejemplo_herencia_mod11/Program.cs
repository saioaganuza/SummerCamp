namespace ejemplo_herencia_mod11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado juan = new Empleado("Juan");

            // Object juan = new Empleado("Juan"); Empleado es object pero Object es generico, no es empleado .


            Administrador maria = new Administrador("María", true);

            Empleado jose = new Trabajador("Jose", "Tarde");

            juan.Jefe = maria;

            // ((Empleado)juan) Convierto temporalmente juan de objeto a empleado

            //Empleado luis = new Externo("Luis", new Empresa 
            //{
            //    Nombre = "ACME",
            //    Telefono = "652895123"
            //});

            //Console.WriteLine(jose.ToString());
            //Console.WriteLine(maria.ToString());
            //Console.WriteLine(juan.ToString());

            var lista = new List<Empleado>() {
                juan, //convierte a juan de empleado a trabajador
                jose, maria,
                new Trabajador("luis", "Mañana")
            };

            foreach (var empleado in lista)
            {
                if (empleado.Nombre.StartsWith("J"))
                {
                    empleado.CalculoVacaciones();
                    Console.WriteLine(empleado.ToString());
                }
            }


        //Otro modo
            //SELECT *FROM empleados where empleados.NombreStartsWith("J")
            var listaEmpleadosJ = from empleado in lista                                  where empleado.Nombre.StartsWith("J")                                  orderby empleado.Nombre                                  select empleado;

            foreach (var empleado in listaEmpleadosJ)            {                if (empleado.Nombre.StartsWith("J"))                {                    empleado.CalculoVacaciones();

                }            }

            try
            {
                if (maria.Tieneplaza)
                {
                    Console.WriteLine(maria.PlazaParking());
                }
            }
            catch (Excepciones_bbdd ex)
            {
                Console.WriteLine(ex.Mensaje + " [" + ex.FechaHoraExcepcion + "]");
            }


        //Fin de otro modo

            

        }
    }
}