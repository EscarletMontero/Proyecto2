// See https://aka.ms/new-console-template for more information
using Poyecto2;

String opcion;

Console.WriteLine("______________________________OPERACIONES MATEMATICAS____________________________\n\n");

Console.WriteLine("Elige con que tipo de Datos deseas trabajar:");
Console.WriteLine("1. Enteros");
Console.WriteLine("2. Flotantes ");
Console.WriteLine("3. Double");
Console.Write("Selecciona una opción (1-3): \r\n");

bool valido = false;

do {

    opcion = Console.ReadLine();
    try
    {
        if (opcion == "1" || opcion == "2" || opcion == "3")
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
        Console.WriteLine("Error. Debe ingresar un numero del 1 al 3 segun su eleccion. \n\n\n");
    }

} while (!valido);



switch (opcion)
{
    case "1":
        Console.WriteLine("______________________________________________________\n" +
            "Has elegido trabajar con enteros" +
            "\n______________________________________________________\n");
        AsignarValores<int> listaInt = new AsignarValores<int>();
        listaInt.Agregar();
        Print.Imprimir(listaInt.ObtenerLista());
        MenuDeOperaciones.SeleccionarOperacion(listaInt.ObtenerLista());
        break;

    case "2":
        Console.WriteLine("______________________________________________________\n" +
            "Has elegido trabajar con Flotantes" +
            "\n______________________________________________________\n");
             AsignarValores<float> listaFloat = new AsignarValores<float>();
             listaFloat.Agregar();
             Print.Imprimir(listaFloat.ObtenerLista());
        MenuDeOperaciones.SeleccionarOperacion(listaFloat.ObtenerLista());

        break;

    case "3":
        Console.WriteLine("______________________________________________________\n" +
            "Has elegido trabajar con Double" +
            "\n______________________________________________________\n");

        AsignarValores<double> listaDouble = new AsignarValores<double>();
        listaDouble.Agregar();
        Print.Imprimir(listaDouble.ObtenerLista());
        MenuDeOperaciones.SeleccionarOperacion(listaDouble.ObtenerLista());

        break;


    default:
        Console.WriteLine("Opción no válida. Intenta de nuevo.");
        break;

}
