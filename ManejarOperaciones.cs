using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto2
{   
    // Delegado 
    public delegate void OperacionCompletada(string msg);
    public class ManejarOperaciones<T> where T : struct, IConvertible
    {
        //Evento que implementara el delegado que cree
        public event OperacionCompletada OperacionRealizada;

         //Metodo sumar
          public T sumar(List<T> lista)
          {
          //Variable suma con dynamic para que no me de error
           dynamic suma = default(T);

            foreach (T t in lista) 
            {    
                suma = suma + (dynamic)t;
            }

            OperacionRealizada?.Invoke($"___________________________________________________________" +
                $"\nSuma realizada corectamente : )" +
                $"\nResultado: = {suma}" +
                $"\n___________________________________________________________");

            return suma;
         }

        //Metodo restar
        public T Restar(List<T> lista)
        {
            dynamic resta = default(T);
            foreach (T t in lista)
            {
                resta = resta - (dynamic)t;
            }

            OperacionRealizada?.Invoke($"___________________________________________________________" +
            $"\nResta realizada corectamente : )" +
            $"\nResultado: = {resta}" +
            $"\n___________________________________________________________");

            return resta;
        }

        //Metodo de multiplicacion
        public T Multiplicar(List<T> lista)
        {
            dynamic multiplica = 1;
            foreach (T t in lista)
            {
                multiplica = multiplica * (dynamic)t;
            }

            OperacionRealizada?.Invoke($"___________________________________________________________" +
            $"\nMultiplicacion realizada corectamente : )" +
            $"\nResultado: = {multiplica}" +
            $"\n___________________________________________________________");

            return multiplica;
        }

        //Metodo de dividir
        public T Division(List<T> lista)
        {
            try
            {
                //Verifico que mi lista no este vacia o en 0
                if (lista.Count == 0)
                    return default; 

                dynamic dividir = lista[0]; 

                for (int i = 1; i < lista.Count; i++)
                {
                    if ((dynamic)lista[i] == 0)
                        throw new DivideByZeroException("No se puede dividir entre cero, y su lista contiene 0."); // Excepción por división entre cero.

                    dividir = dividir / (dynamic)lista[i];
                }
                return dividir;
                OperacionRealizada?.Invoke($"___________________________________________________________" +
                $"\nDivision realizada corectamente : )" +
                $"\nResultado: = {dividir}" +
                 $"\n___________________________________________________________");

                return dividir;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}"); 
                return default;
            }
        }




    }
}
