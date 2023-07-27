using Entidades;
using Operaciones;
namespace practica2_mod6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
                
            {
                var moneda = new Moneda();
                Conversor conversor = new Conversor();
                string monedaOrigen="";
                string monedaDestino="";

                //COger la moneda de origen
                Console.WriteLine("CONVERSOR DE DIVISA \n Indique el tipo de divisa: \n ");
                int i = 1;
                foreach(var item in conversor.listaMonedas) {
                    Console.WriteLine(i +".- "+item.Id + "\n");
                    i++;
                }

               
                    
                int.TryParse(Console.ReadLine(), out int numero);

                while(numero != 1 && numero!=2 && numero != 3) 
                {
                    Console.WriteLine("Escoja entre las opciones indicadas.");
                    int.TryParse(Console.ReadLine(), out numero);
                }
                switch (numero)
                {
                    case 1:
                        monedaOrigen = "EUR";
                        break;
                    case 2:
                        monedaOrigen = "USD";
                        break;
                    case 3:
                        monedaOrigen = "GBP";
                        break;
                }




                //Coger la moneda de destino
                Console.WriteLine("Indique el tipo de divisa al que desea convertir: \n ");
                i = 1;
                foreach (var item in conversor.listaMonedas)
                {
                    Console.WriteLine(i + ".- " + item.Id + "\n");
                    i++;
                }


                int.TryParse(Console.ReadLine(), out  numero);

                while (numero != 1 && numero != 2 && numero != 3)
                {
                    Console.WriteLine("Escoja entre las opciones indicadas.");
                    int.TryParse(Console.ReadLine(), out numero);
                }
                switch (numero)
                {
                    case 1:
                        monedaDestino = "EUR";
                        break;
                    case 2:
                        monedaDestino = "USD";
                        break;
                    case 3:
                        monedaDestino = "GBP";
                        break;
                }


                Console.WriteLine("Indique el importe que desea convertir: \n ");
                double importe = Int32.Parse(Console.ReadLine());

                double resultado= Math.Round(Conversor.CambioMoneda(importe, monedaOrigen, monedaDestino),2);
                string simbolo = Conversor.SacarSimbolo(monedaDestino);

                Console.WriteLine($" \n El restultado es: {resultado} {simbolo}\n ");

            }
        }
    }
}