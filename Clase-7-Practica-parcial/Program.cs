namespace Consola
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] v = { 10, 1, 20, 4, 8 };
            int cantidad, diferencia=0, total=0;


            //....
            //v[0] = 10;
            //v[1] = 1;
            //v[2] = 20;
            //v[3] = 4;
            //v[4] = 8;

            //3.
            Console.WriteLine("A liberar:");
            cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] - cantidad <=0)
                {
                    cantidad -= v[i];
                    v[i] = 0;
                }
                else
                {
                    v[i] -= cantidad;
                    cantidad = 0;
                    
                }
   
            }

            foreach (int item in v)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < v.Length; i++)
            {
                //Completar al máximo (20) las posiciones impares
                //cuánto sumé en cada una
                //cuánto sumé en total
                if(i % 2 != 0)
                {
                    diferencia = 20 - v[i];
                    v[i] = 20;

                    Console.WriteLine($"Sumé en {i} la canidad de {diferencia}");
                    total += diferencia;
                }
            }

            Console.WriteLine($"Sumé en total: {total}");

        }
    }
}

//--------------Días de lluvia

//int cantidadMilimetros, probabilidades;
//int maxProb = 0, maxMili = 0, minProb = 0, minMili = 0;
//int sumaProb = 0, cont = 0, sumaMilimetros = 0;
//int opcion;
//bool supero = false;
//bool b = false;
//// int band = 0;
////int band = -200;

//Console.WriteLine("Ingrese la probabilidad");
//probabilidades = int.Parse(Console.ReadLine());

//while (probabilidades != 0)
//{
//    if (probabilidades >= 0 && probabilidades <= 100)
//    {
//        sumaProb += probabilidades;
//        cont++;

//        Console.WriteLine("Indique los milímetros");
//        cantidadMilimetros = int.Parse(Console.ReadLine());
//        sumaMilimetros += cantidadMilimetros;

//        //if (band == 0)
//        //if (band == -200)
//        if (b == false)
//        {
//            maxProb = probabilidades;
//            maxMili = cantidadMilimetros;

//            minProb = probabilidades;
//            minMili = cantidadMilimetros;

//            //band = 1;
//            //band = -201;
//            b = true;
//        }
//        else
//        {
//            if (probabilidades > maxProb)
//            {
//                maxProb = probabilidades;
//                maxMili = cantidadMilimetros;
//            }

//            if (probabilidades < minProb)
//            {
//                minProb = probabilidades;
//                minMili = cantidadMilimetros;
//            }
//        }

//        if (probabilidades > 90)
//            supero = true;

//    }
//    else
//        Console.WriteLine("Fuera del intervalo");

//    Console.WriteLine("Ingrese la probabilidad");
//    probabilidades = int.Parse(Console.ReadLine());
//}


//do
//{
//    Console.WriteLine("Opciones");
//    //... todos los writeline con las opcione

//    Console.WriteLine("Ingrese la opción");
//    opcion = int.Parse(Console.ReadLine());
//    switch (opcion)
//    {
//        case 1:
//            Console.WriteLine($"La Prob máxima es: {maxProb} con {maxMili}");
//            Console.WriteLine($"La Prob mínimo es: {minProb} con {minMili}");
//            break;

//        case 2:
//            Console.WriteLine($"El promedio es {sumaProb / cont} y superó es {supero}");
//            break;
//        case 3:
//            Console.WriteLine($"La suma de los milímetros: {sumaMilimetros}");
//            break;
//        default:
//            break;
//    }

//} while (opcion != 0);


//-------------------GUERREROS---------
//char opcion; //'a', 'b', '7'
//int cantGuerreros = 2, fuerza = 2, debilidad = 1;
//Random r = new Random();
//int poder = 10, aux, maximo = 0;

//do
//{
//    Console.WriteLine("1.Mostrar fuerza total.");
//    Console.WriteLine("2.Mostrar estado actual del ejército.es");
//    Console.WriteLine("3.Recibir un ataque.");
//    Console.WriteLine("4.Reforzar ejército.");
//    Console.WriteLine("5.Salir.");
//    Console.WriteLine("Opciones");

//    Console.WriteLine("Opción");
//    opcion = char.Parse(Console.ReadLine());

//    switch (opcion)
//    {
//        case '1':
//            //Mostrar fuerza total: Imprime por pantalla el resultado del cálculo de la fuerza total.
//            //Fuerza total = Cantidad de guerreros *fuerza - Cantidad de guerreros *debilidad
//            Console.WriteLine(cantGuerreros * fuerza - cantGuerreros * debilidad);
//            break;
//        case '2':
//            Console.WriteLine($"{cantGuerreros} {fuerza} {debilidad}");
//            break;
//        case '3':
//            aux = r.Next(5, 11);
//            if (cantGuerreros - aux >= 0)
//                cantGuerreros -= aux;
//            else
//                cantGuerreros = 0;

//            aux = 10 - aux;
//            if (fuerza - aux >= 0)
//                fuerza -= aux;
//            else
//                fuerza = 0;

//            debilidad--;
//            if (debilidad < 0)
//                debilidad = 0;

//            break;
//        case '4':
//            aux = 0;
//            for (int i = 0; i < 5; i++)
//            {
//                aux = r.Next(1, 7);
//                if (i == 0)
//                {
//                    maximo = aux;
//                }
//                else if (aux > maximo)
//                    maximo = aux;
//            }

//            if (cantGuerreros + maximo > 100)
//                cantGuerreros = 100;
//            else
//                cantGuerreros += maximo;

//            break;
//        case '5':
//            Console.WriteLine("Saliendo");
//            break;
//    }
//} while (opcion != '5');

//-----------------DICCIONARIO
//string[] diccionario = { "calabaza", "biblioteca", "elefante", "libro", "ardilla" };
//int coinciden = 0, noCoinciden = 0;
//string palabra;
//bool encontrado;
//int i;
//int posicion, maximo = 0;

////1.
//Console.Write("Ingrese una palabra (con X mayúscula para salir): ");
//palabra = Console.ReadLine();

//while (palabra != "X")
//{
//    i = 0;
//    encontrado = false;
//    while (i < diccionario.Length && encontrado == false)
//    {
//        if (diccionario[i] == palabra)
//            encontrado = true;
//        i++;
//    }

//    if (encontrado)
//    {
//        coinciden++;
//    }
//    else
//        noCoinciden++;

//    Console.Write("Ingrese una palabra (con X mayúscula para salir): ");
//    palabra = Console.ReadLine();
//}

//Console.WriteLine($"Coinciden {coinciden} y no coinciden {noCoinciden}");

////2.
//foreach (string item in diccionario)
//{
//    if (item[0] == 'a' || item[0] == 'e' || item[0] == 'i' || item[0] == 'o' || item[0] == 'u')
//        Console.WriteLine(item);

//    // if (item.StartsWith("a") == true || item.StartsWith("e")...)
//}

////3
//foreach (string item in diccionario)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("Indique la posición");
//posicion = int.Parse(Console.ReadLine());

//diccionario[posicion - 1] = "";

//foreach (string item in diccionario)
//{
//    if (item != "")
//        Console.WriteLine(item);
//}

////4
//for (int j = 0; j < diccionario.Length; j++)
//{
//    if (j == 0)
//    {
//        maximo = diccionario[j].Length;
//    }
//    else if (diccionario[j].Length > maximo)
//        maximo = diccionario[j].Length;
//}

//Console.WriteLine($"La palabra más extensa tiene {maximo} caracteres");