using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto2
{
    public class Print
    {
        public static void Imprimir<T>(List<T> list)
        {

            if (list.Count == 0)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Console.WriteLine("Contenido de la lista:");
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }

        }

    }
}
