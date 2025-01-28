using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto2
{
  public class AsignarValores<T> where T : struct, IConvertible
    {
      public List<T> list = new List<T> ();


        public void Agregar () {

            bool continuar = true;
            String num;

            Console.WriteLine("Ingrese los valores separados por Enter)" +
                "\r\n Para finalizar escriba fin. \r\n");

            do
            {
                Console.Write("-");
                num = Console.ReadLine();
          

                if (num.ToLower() == "fin") { 
                
                continuar = false;   
                break;
                
                }

                //Excepcion 
                try
                {
                    // Convertir el valor en T
                    T valor = (T)Convert.ChangeType(num, typeof(T));
                    list.Add(valor); 
                }
                catch (Exception)
                {
                    Console.WriteLine("Error, el valor no coincide con el tipo de dato esperado. Intentalo de nuevo.");
                }

            } while (continuar);
        }

        //Metodo aprendido Lambda
        public List<T> ObtenerLista() => list; 



    }



    }

 