using Extensiones;
namespace EjemploMetodosExtension
{
    public class Program
    {
        static void Main(string[] args)
        {
            var juan = "JuAn lOpEz".ConvertirCadena();
            var luis = "lUis MaRTinEz".ConvertirCadena();


            //Agregar método de extensión para comparar dos enteros

            int a = 1;
            int b = 2;

            if (a.EsMayorQue(b))
            {
                Console.WriteLine("Es mayor");
            }
            else
            {
                Console.WriteLine("Es menor");
            }

            //Mostrar año de la fecha
            var fecha = DateTime.Now;
            var año = fecha.ObtenerAño();


            //Obtener el primer elemento de la lista
            var lista = new List<int>() { 1, 3, 4, 5, 6, 7 };
            var primero = lista.Primero();
        }


    }
}