using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFuncAction
{
    internal class Ejemplo
    {

        internal void EjemploFunc()
        {

            // Expresión Lambda mediante Func<>

            Func<string> holaMundoExpresion =

                // Parametros
                ()
                // Operador Lambda
                =>
                // Delegado / Método anónimo / Expresión
                "Hola Mundo !!!!!!";

            Console.WriteLine(holaMundoExpresion); //Si  lo pongo así no sale lo que quiero que salga                                          
            Console.WriteLine(holaMundoExpresion());



            // Expresion Lambda mediante Bloque Func<>
            Func<string> holaMundoBloque =

                // Parametros
                ()
                // Operador Lambda
                =>
                // Delegado / Método anónimo 
                {

                    var cadena = "Hola Mundo !!!!";
                    return cadena;
                };

            Console.WriteLine(holaMundoBloque());

            //Crear una expresion lambda que sume dos números

            //Func
            Func<int, int, int> sumar = //Dos parámetros de entrada y uno de salida = int, int, int
            //Parámetros
            (numero1, numero2)
            //Operador Lambda
            =>
            //Delegado / método anónimo
            {
                return numero1 + numero2;
            };

            Console.WriteLine(sumar(10, 20));
        }



        internal void EjemploAction()
        {
            // LLamar a Action pasándole un método como parámetro
            Action(AccionMetodo, 1);

            // Llamar a Action escribiendo la expresión lambda como parámetro entre los dos paréntesis
            Action((a) => Console.WriteLine($"En el método Accion {a}") , 1);

            // Crear una variable que almacene la acción        
            // Llamar a Action apsándole la vaiable y el valor 1

            Action<int> accion = (y) => 
            { 
                Console.WriteLine($"En el método Accion {y}");
            };
            Action(accion,1 );


            // Lista de acciones
            List<Action<int>> listaAcciones = new List<Action<int>>();

            listaAcciones.Add( accion );
            listaAcciones.Add( AccionMetodo );

            foreach ( var item in listaAcciones)
            {
                item(1);
            }
        }

        //Método que recibe un Action<int> y un int
        public void Action(Action<int> accion, int num)
        {
            accion(num);
        }

        public void AccionMetodo(int num)
        {
            Console.WriteLine($"En el método Accion {num}");
        }

        
    }
}
