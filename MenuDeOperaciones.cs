using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto2
{
        public class MenuDeOperaciones
        {
            public static void SeleccionarOperacion<T>(List<T> lista) where T : struct, IConvertible
            {

                ManejarOperaciones<T> operaciones = new ManejarOperaciones<T>();
            operaciones.OperacionRealizada += (msg) => Console.WriteLine(msg); // Suscripción al evento
            string opcion;
             
            bool continuar = true;
            do
            {
                Console.WriteLine("\n __________________________________________________________");
                Console.WriteLine("Elige la operación a realizar:");
                    Console.WriteLine("1. Sumar");
                    Console.WriteLine("2. Restar");
                    Console.WriteLine("3. Multiplicar");
                    Console.WriteLine("4. Dividir");
                    Console.WriteLine("5. Salir\n");


            bool valido = false;

            do
            {

                opcion = Console.ReadLine();
                try
                {
                    if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4" || opcion == "5")
                    {
                        valido = true;
                    }
                    else
                    {
                        throw new Exception("");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error. Debe ingresar un numero del 1 al 5 segun su eleccion. \n\n\n");
                }

            } while (!valido);




                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Realizando suma...");
                        T suma = operaciones.sumar(lista);
                        break;
                    case "2":
                        Console.WriteLine("Realizando resta...");
                        T resta = operaciones.Restar(lista);
                        break;
                    case "3":
                        Console.WriteLine("Realizando multiplicación...");
                        T multiplicacion = operaciones.Multiplicar(lista);
                        break;
                    case "4":
                        Console.WriteLine("Realizando división...");
                        T division = operaciones.Division(lista);
                        break;
                    case "5":
                        Console.WriteLine("Saliendo de las operaciones.");
                        break;
                }

                if (opcion != "5")
                    {
                        Console.WriteLine("¿Deseas realizar otra operación? (si/no): ");
                        string respuesta = Console.ReadLine();
                        if (respuesta.ToLower() != "si")
                        {
                            continuar = false;
                            break;
                        }

                        else
                        {
                        continuar= true;
                        }
                }

            } while (continuar);
         }
    }
}


