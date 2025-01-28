Practica 2: Manejo de Operaciones 
Este programa es prácticamente una calculadora genérica capaz de realizar operaciones con cualquier tipo de dato numérico. Esta práctica está basada en la creación de un programa cuya función es realizar operaciones matemáticas como: suma, resta, multiplicar y dividir un conjunto de elemento de tamaño indefinido, siempre y cuando existan más de dos valores. Funcionalidades aplicadas que destacan este programa son los genéricos, las excepciones, los delegados y los eventos. 

¿Cómo funciona?
El programa inicia con un menú y una representación gráfica sencilla basada en texto Intuitivo fácil de comprender, Este menú principal le da la libertad al usuario de que pueda trabajar con el tipo de datos de su preferencia.
Se le pide al usuario ingresar un número del 1 al 3, eligiendo el tipo de dato. 
Si el usuario introduce un valor fuera del rango especificado, El programa lanzara una excepción, explicándole brevemente al usuario la forma correcta de responder al menú, dándole la oportunidad de volverlo a intentar hasta que pueda ingresar lo de forma correcta.
Luego de esto, el usuario debe insertar una serie de elementos dentro de una lista que es genérica La cual trabajará con el tipo de dato elegido por el usuario, Si el usuario eligió los enteros, debe ingresar los números enteros en la lista, de lo contrario, la lista desplegará una excepción si el valor ingresado no coincide con el tipo de dato esperado.
Esta excepción impedirá que el programa explote y le recordará al usuario el tipo de dato con el que está trabajando para que pueda insertar un valor valido. 
Lo que el usuario decida terminar de ingresar los valores a su lista deberá escribir fin, lo cual se especifica en el programa para que el usuario pueda Completar o finalizar su lista de forma correcta. No importa si el usuario escribe fin con mayúsculas o con minúsculas, el programa sabrá interpretar si el usuario ha terminado. 
Cuando el usuario haya terminado de ingresar los valores a su lista, entonces el programa le mostrará los valores que posee su lista.
Luego de esto se mostrará otro menú donde el usuario deberá elegir qué tipo de operación desea realizar con su lista de valores, ya sea sumar, restar, dividir o multiplicar. El usuario tiene la oportunidad de realizar más de una operación Ya que el programa le permitirá, realizar las operaciones que desee, hasta que el usuario decida finalizar, También se presentará una excepción, cielo usuario ingresa un valor no esperado en cuestión a la elección de dichas operaciones. El programa también es capaz de realizar o de lanzar una excepción si el usuario intenta dividir y en su lista existe el valor cero. Además de esto, el programa maneja eventos Los cuales notificará al usuario cuando una operación matemática sea completada exitosamente. 

Explicación de los Métodos Utilizados
Las clases asignarValores<T>
Agregar: Permira al usuario ingresar valores de tipo genérico T a una lista. Maneja excepciones si el valor ingresado no coincide con el tipo esperado.
ObtenerLista: Este me devuelve la lista de valores almacenados utilizando una expresión lambda.

La clase ManejarOperaciones<T>
sumar: Este método se encarga de sumar todos los elementos de la lista genérica. Usa dynamic para manejar cualquier tipo de dato numérico. Lanza un evento al completar la operación.
Restar: Este método de restar los elementos de la lista. También utiliza dynamic y lanza un evento al terminar.
Multiplicar: Multiplica todos los elementos de la lista. Similar a los métodos anteriores, notifica mediante el evento. 
Division: Se encarga de la división los elementos de la lista. Maneja una excepción para la división entre cero y lanza el evento correspondiente. 
La clase MenuDeOperaciones
SeleccionarOperacion: Este presenta un menú para las operaciones matemáticas suma, resta, multiplicación, división, sobre la lista ingresada. También maneja excepciones de entrada y utiliza los métodos de ManejarOperaciones<T> para realizar las operaciones.

La clase Print
Imprimir<T>: Este método se encarga de imprimir el contenido de cualquier lista genérica T. Verifica si la lista está vacía antes de mostrar los datos.

Manejo de Genéricos
En la clase ManejarOperaciones<T>  aquí utilice genéricos, y con restricciones (where T : struct, IConvertible) para garantizar que solo se utilicen tipos numéricos (int, float, double).

Delegados y Eventos
Definí un delegado como OperacionCompletada y el evento como  OperacionRealizada. Esto permite enviar mensajes al usuario tras completar exitosamente una operación matemática.

Entrada de Datos 
La clase AsignarValores<T> permite al usuario ingresar una lista de valores. Utiliza Convert.ChangeType para convertir las entradas del usuario al tipo genérico seleccionado. 
