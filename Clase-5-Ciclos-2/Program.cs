namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, maximo;

            Console.WriteLine("Ingrese el máximo");
            maximo = int.Parse(Console.ReadLine());

            for (i = 0; i <= maximo; i++)
            {
                maximo--;
                Console.WriteLine(i);
            }

        }
    }
}


//int i, maximo;

//Console.WriteLine("Ingrese el máximo");
//maximo = int.Parse(Console.ReadLine());

//for (i = 0; i <=maximo; i++)
//{
//    Console.WriteLine(i);
//}

//i = 0;
//while (i <= maximo)
//{
//    Console.WriteLine(i);
//    i++;
//}

//Console.WriteLine($"El valor de i es: {i}");

//-----------------------------------------------

//8.Ingresar varios valores mayores que cero y devolver la suma. 
//    ¿Qué particularidad tiene el hecho de usar Do-While ?

//int valor, suma = 0, contar = 0;

//do
//{

//    Console.WriteLine("Ingrese:");
//    valor = int.Parse(Console.ReadLine());

//    if (valor > 0)
//        suma += valor;


//} while (valor != 0);

//Console.WriteLine($"Suma: {suma}");

////9.Permitir ingresar valores y contar cuántos son pares. 
////¿Cuál es el inconveniente con el primer dato?

//do
//{

//    Console.WriteLine("Ingrese:");
//    valor = int.Parse(Console.ReadLine());

//    if (valor % 2 == 0)
//        contar++;


//} while (valor != 0);

//Console.WriteLine($"Suma: {suma}");

//---------------------------------
////11.Repetir el ejercicio anterior para los números impares.

//int maximo, suma=0;

//Console.WriteLine("Ingrese el máximo");
//maximo = int.Parse(Console.ReadLine());
//Console.WriteLine("Estándar");
//for (int i = 1; i <= maximo; i++)
//{
//    if (i % 2 != 0)
//        Console.WriteLine(i);
//}

//Console.WriteLine("Incrementos");
//for (int i = 1; i <= maximo; i = i + 2)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("Incrementos repartidos");
//for (int i = 1; i <= maximo; i++)
//{
//    Console.WriteLine(i++);
//}

////12.Tomar el ejercicio anterior y sumar todos los valores que hayan sido pares.
//for (int i = 1; i <= maximo; i++)
//{
//    if (i % 2 == 0)
//        suma += i;

//    //suma += (i % 2 == 0) ? i : 0;
//}

//Console.WriteLine("La suma es " + suma);
////13.Solicitar un valor y luego mostrar todos los múltiplos de 5 desde 1 hasta ese valor.
//for (int i = 1; i <= maximo; i++)
//{
//    if (i % 5 == 0)
//        Console.WriteLine(i);
//}

//----------------------------------
////1.Solicitar por pantalla la nota final de cada alumno 
//// y devolver el promedio de las calificaciones.Con 0 se cierran el ciclo.

//int i=0, notas, suma = 0;

//Console.WriteLine("Ingrese el máximo");
//notas = int.Parse(Console.ReadLine());

//while (notas != 0)
//{
//    suma += notas;
//    i++;

//    Console.WriteLine("Ingrese el máximo");
//    notas = int.Parse(Console.ReadLine());
//}
//Console.WriteLine($"El promedio es: {suma / i}");


////Console.WriteLine("Ingrese el máximo");
////notas = int.Parse(Console.ReadLine());

////for (i = 0; notas != 0; i++)
////{
////    suma += notas;

////    Console.WriteLine("Ingrese el máximo");
////    notas = int.Parse(Console.ReadLine());

////}

//---------------------------------------
////2.El servicio meteorológico necesita 
////    mostrar la cantidad de días que no llovió de acuerdo con los datos que les entregaron.
////    Realice un programa en el que ingresen la cantidad de días a procesar, 
////    la cantidad de lluvia para cada día 
////    y mostrar la cantidad de días que no llovió(el valor ingresado es cero).

//int cantDias, cont = 0, cantLluvia;

//Console.WriteLine("Cantidad de días");
//cantDias = int.Parse(Console.ReadLine());

//for (int i = 1; i <= cantDias; i++)
//{
//    Console.WriteLine("Ingrese la cantidad de lluvia");
//    cantLluvia = int.Parse(Console.ReadLine());

//    if (cantLluvia == 0) cont++;
//}

//Console.WriteLine($"No llovió: {cont} días");

//-------------------------------------
//3.Solicitar la cantidad de remeras confeccionadas.
//    Luego en un ciclo ingresar cuántos metros de hilos 
//    se usaron para cada una de las remeras y obtener el total de hilo utilizado. 
//    Cada remera utiliza una cantidad de metros diferente.

//int cantRemeras, totalHilo = 0, cantHilo;

//Console.WriteLine("Cantidad de remeras");
//cantRemeras = int.Parse(Console.ReadLine());

//for (int i = 1; i <= cantRemeras; i++)
//{
//    Console.WriteLine("Ingrese la cantidad de lluvia");
//    cantHilo = int.Parse(Console.ReadLine());

//    totalHilo += cantHilo;
//}

//Console.WriteLine($"Total de hilo {totalHilo}");

//-----------------------------------------------
//4.Hacer un programa para que se pida cuántos alumnos se van a ingresar 
//    y luego solicitar la edad 
//    y sexo(F - Femenino / M - Masculino de los alumnos de un curso).
//  Mostrar la siguiente información por pantalla
//a.Cuántos alumnos hay y el promedio de la edad.
//b.Cuántas mujeres, y cuántos varones hay.

//int cantAlumnos, sumaEdad = 0, edad, cantF = 0, cantM = 0;
//string MoF;

//Console.WriteLine("Cantidad de alumnos");
//cantAlumnos = int.Parse(Console.ReadLine());

//for (int i = 1; i <= cantAlumnos; i++)
//{
//    Console.WriteLine("Ingrese edad");
//    edad = int.Parse(Console.ReadLine());
//    sumaEdad += edad;
//    Console.WriteLine("Ingrese M o F");
//    MoF = Console.ReadLine();

//    if (MoF == "F") 
//        cantF++; 
//    else 
//        cantM++;

//}

//Console.WriteLine($"Promedio de edad {sumaEdad / cantAlumnos}");
//Console.WriteLine($"Cantidad F: {cantF} - Cantidad M: {cantM} ");

//------------------------------------
//5.
//a.Que pueda ingresar el valor de cada producto y la cantidad.
//b.Con cero devuelve el total.
//c.Ingresar con cuánto abona el cliente y mostrar el vuelto.

//int cantidad, precio, total = 0, cuantoAbona;

//Console.WriteLine("Ingrese la cantidad");
//cantidad = int.Parse(Console.ReadLine());

//while(cantidad !=0)
//{
//    Console.WriteLine("Ingrese el precio");
//    precio = int.Parse(Console.ReadLine());

//    total += cantidad * precio;

//    Console.WriteLine("Ingrese la cantidad");
//    cantidad = int.Parse(Console.ReadLine());
//}

//Console.WriteLine($"El total es {total}");

//Console.WriteLine("¿Cuánto abona?");
//cuantoAbona = int.Parse(Console.ReadLine());

//Console.WriteLine("El vuelto es: " + (cuantoAbona - total));

//-----------------------
//1.Elaborar un menú en el cual el usuario pueda elegir lo siguiente:
//a.  0: Salir del programa
//b.  1: Solicitar el nombre del usuario y responde “Hola xxxxx”.
//c.  2: Solicitar la edad y mostrar por pantalla “Su edad es xxxx”.
//do
//{
//    ImprimirOpciones;
//    x = leer x;
//    switch (x) { }

//}WHILE(x != valorSalida)


//int opcion;
//string nombreUsuario, edad;

//do
//{
//    Console.WriteLine("Menú");
//    Console.WriteLine("0. Salir");
//    Console.WriteLine("1: Solicitar el nombre del usuario y responde “Hola xxxxx”.");
//    Console.WriteLine("2: Solicitar la edad y mostrar por pantalla “Su edad es xxxx”.");
//    Console.WriteLine("¿Opción?");
//    opcion = int.Parse(Console.ReadLine());

//    switch (opcion)
//    {
//        case 0:
//            Console.WriteLine("Saliendo...");
//            break;

//        case 1:
//            Console.WriteLine("1: Solicitar el nombre del usuario y responde “Hola xxxxx”.");
//            nombreUsuario = Console.ReadLine();
//            Console.WriteLine("Hola " + nombreUsuario);
//            break;
//        case 2:
//            Console.WriteLine("2: Solicitar la edad y mostrar por pantalla “Su edad es xxxx”.");
//            edad = Console.ReadLine();
//            Console.WriteLine("Su edad es " + edad);
//            break;
//        default:

//            break;
//    }


//} while (opcion != 0);