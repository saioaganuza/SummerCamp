using System.Collections;

namespace practica1_mod6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<vehiculo>();

            while (true) {

                Console.WriteLine("Escoja el constructor con el que desea crear su coche: \n 1. Indicando el año de compra y el color. \n 2. Indicando la marca y el modelo. \n 3. Indicando el año de compra, la marca, el modelo y el color.");

                int eleccion = Int32.Parse(Console.ReadLine());

              
                switch (eleccion)
                {
                    case 1:
                        Console.WriteLine("Indique el año de compra: ");
                        int año = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indique el color del vahículo: ");
                        string color = Console.ReadLine();
                        var v = new vehiculo(año,color);
                        list.Add(v);
                        break;
                    case 2:
                        Console.WriteLine("Indique la marca del vahículo: ");
                        string marca = Console.ReadLine();
                        Console.WriteLine("Indique el modelo del vahículo: ");
                        string modelo = Console.ReadLine();
                        v = new vehiculo(marca,modelo);
                        list.Add(v);
                        break;
                    case 3:
                        Console.WriteLine("Indique el año de compra: ");
                        año = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indique el color del vahículo: ");
                        color = Console.ReadLine();
                        Console.WriteLine("Indique la marca del vahículo: ");
                        marca = Console.ReadLine();
                        Console.WriteLine("Indique el modelo del vahículo: ");
                        modelo = Console.ReadLine();
                        v = new vehiculo(año,marca,modelo,color);
                        list.Add(v);
                        break;
                    default:
                        Console.WriteLine("Escoja entre 1, 2 o 3. Gracias");
                        eleccion = Int32.Parse(Console.ReadLine());
                        break;
                }
                Console.WriteLine("El vehículo se ha registrado correctamente.");
                int i= 1;
                foreach(vehiculo v in list) {
                    v.SacarDatos(v,i);
                    i++;
                        }
                
            }

        }
    }
}