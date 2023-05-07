namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] vector = new int [5];
            // int[] v2 = {0, 1, 2, 3, 4};

            // foreach (int item in v2) {
            //     Console.WriteLine(item);
            // }

            // 1 
            int[] vector1 = {2, 3, 5, 7, 10};

            Console.WriteLine($"El {vector1[0]} y {vector1[1]}");

            // 2
            vector1[2] = 6;
            Console.WriteLine($"Cambio {vector1[2]}");

            // 3
            int sumase;
            sumase = vector1[2] + vector1[3];
            Console.WriteLine($"La suma es {sumase}");

            // 11
            int maximo = 0;
            int minimo11 = 0;

            //Máximo
            for (int i = 0; i < vector1.Length; i++)
            {
                if (i == 0)
                {
                   maximo = vector1[i];
                   minimo11 = vector1[i];
                } else if (vector1[i] < minimo11) {
                    minimo11 = vector1[1];
                } else if (vector1[i] > maximo) {
                   maximo = vector1[i];
                } 
            } 
            Console.WriteLine($"El maximo es: {maximo} y el minimo es {minimo11}");
            

            

            //18
            int[] vector = { 4, 7, 2, 0, 9 };
            int suma = 0, minimo = 0, pos = 0;

            //Determinar cuántas personas pueden ingresar al local si
            //en total entre los que están en la cola y
            //recorriendo el local no pueden superar el número 50.

            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i];
            }
            Console.WriteLine($"Pueden ingresar {50 - suma} personas");

            //Si cada caja puede tener 10 personas en espera, ¿cuántos pueden sumarse a cada cola?
            foreach (int item in vector)
            {
                Console.WriteLine($"Puedo sumar {10 - item}");
            }

            //Los 5 que recién entraron fueron a la caja más vacía, 
            //¿a qué caja fueron? Considere que el 4 es la caja 1.
            for (int i = 0; i < vector.Length; i++)
            {
                if (i == 0)
                {
                    minimo = vector[i];
                    pos = i;
                }
                else if (vector[i] < minimo)
                {
                    minimo = vector[i];
                    pos = i;
                }
                    
            }

            Console.WriteLine($"La posición es {pos + 1}");


        }
    }

}

//----------------------------------------------------
//int sinAtender=0, noLlegaron=0, superaron=0;
//int cantidad;

//for (int i = 1; i <= 7; i++)
//{
//    Console.WriteLine("Ingrese la cantidad");
//    cantidad = int.Parse(Console.ReadLine());

//    //a.Cuántas personas quedaron sin atender al finalizar la semana.
//    //b.Cuántos días en total superaron las 50 personas.
//    if (cantidad > 50)
//    {
//        sinAtender += cantidad - 50;
//        superaron++;
//    }
//    else if (cantidad < 50)
//    {
//        //c.Cuántos días no llegaron a las 50 personas.
//        noLlegaron++;
//    }
//}

//Console.WriteLine($"{sinAtender}   {superaron}    {noLlegaron}");

//--
//int[] v = new int[5]; //de 0 a 4 son las posiciones.
//int[] v2 = { 4, 7, 9, 5, 3 };
//int aux, posA, posB;

//int suma = 0, maximo = 0;

////Inicializar cada posición de forma individual
//v[0] = 5;
//v[1] = 8;

//Console.WriteLine(v[0]);
//Console.WriteLine(v[1]);
//Console.WriteLine(v[0] + v[1]);
//Console.WriteLine((v[0] + v[1]) * 20);

////v[5] = 10; //¿anda? NO

////Asigno valores
//for (int i = 0; i < v.Length; i++) //i => 0, 1, 2, 3, 4 => 5 < v.Lenght(vale 5) 
//{
//    //la variable i va a ir tomando valores
//    v[i] = 0;
//}

////Acumular
//for (int i = 0; i < v2.Length; i++)
//{
//    suma += v2[i];
//}
//Console.WriteLine($"El total es {suma}. el promedio es {suma / v2.Length}");

////Máximo
//for (int i = 0; i < v2.Length; i++)
//{
//    if (i == 0)
//    {
//        maximo = v2[i];
//    }
//    else if (v2[i] > maximo)
//        maximo = v2[i];
//}

//Console.WriteLine($"El máximo es {maximo}");
//Console.WriteLine("Con FOREACH");
//suma = 0;
//foreach (int item in v2)
//{
//    Console.WriteLine(item);
//    suma += item;
//}
//Console.WriteLine($"El total es {suma}. el promedio es {suma / v2.Length}");

////Intercambiar posiciones
//posA = 1;
//posB = 3;
//aux = v2[posA]; //Copio uno de los valores en una variable auxiliar.
//v2[posA] = v2[posB]; //Puedo pisar el valor de V[i] porque tengo una copia
//v2[posB] = aux; //La copia la mando a V[j].

//----------------------------
//int[] vector = { 4, 7, 9, 5, 3 };
//int aux;

//for (int i = 0; i < vector.Length - 1; i++) //cantidad de vueltas
//{
//    for (int j = 0; j < vector.Length - 1 - i; j++) //voy hasta la anteúltima pos
//    {
//        if (vector[j] > vector[j + 1]) //comparo pos actual y +1
//        {
//            aux = vector[j];
//            vector[j] = vector[j + 1];
//            vector[j + 1] = aux;
//        }
//    }
//}

//Array.Sort(vector);

//foreach (int item in vector) //item toma el valor de cada posición en cada vuelta
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(vector.ToString());

//------------------------
//int[] vector = { 4, 7, 9, 5, 3 };
//int i, valorBuscado;
//bool encontrado;

//encontrado = false;
//i = 0;
//Console.WriteLine("Ingrese el valor a buscar");
//valorBuscado = int.Parse(Console.ReadLine());

//while (i < vector.Length && encontrado == false)
//{
//    if (vector[i] == valorBuscado)
//        encontrado = true;

//    i++;
//}

//if (encontrado == true)
//{
//    Console.WriteLine($"El elemento está en la posición del vector {i - 1}");
//    Console.WriteLine($"El elemento está en la posición natural {i}");
//}

//----------------------------------

//int[] vector = { 4, 7, 9, 5, 3 };

//int[] vector2 = new int[5];
//int posicion;

//Array.Copy(vector, vector2, 5);

//foreach (int item in vector2)
//{
//    Console.WriteLine(item);
//}

//posicion = Array.IndexOf(vector, 10);
//Console.WriteLine($"El 7 está en la posición {posicion}");

//---------------------------
//Dado dos vectores, el primero con números pares y el segundo con números impares,
////devolver la suma de cada fila.
//int[] v1 = { 3, 7, 7, 2, 1 };
//int[] v2 = { 4, 7, 9, 5, 3 };

//for (int i = 0; i < v1.Length; i++)
//{
//    Console.WriteLine(v1[i] + v2[i]);
//}

//----------------------------------
////12
////Una maratonista quiere obtener información sobre una semana de ejercitación.
////Para eso permitir la carga de cuántas horas corrió cada día y:
////            a.Mostrar los valores ingresados por el usuario.
////            b.Devolver el total de horas ejercitadas.
////c.Además, sabiendo cuántas horas en total hay en una semana, cuántas son las que no estuvo corriendo.
////d. ¿Qué día fue el que más corrió ?

//int[] v = new int[7];
//int totalHoras = 0, maximo = 0;

//for (int i = 0; i < v.Length; i++)
//{
//    Console.WriteLine($"Ingrese el dato para el día {i + 1}");
//    v[i] = int.Parse(Console.ReadLine());
//    totalHoras += v[i];
//}

//for (int i = 0; i < v.Length; i++)
//{
//    Console.WriteLine(v[i]);
//}

//Console.WriteLine($"Total de horas {totalHoras}");
//Console.WriteLine($"Total no corriendo {24 * 7 - totalHoras}");

////Máximo
//for (int i = 0; i < v.Length; i++)
//{
//    if (i == 0)
//    {
//        maximo = v[i];
//    }
//    else if (v[i] > maximo)
//        maximo = v[i];
//}

//Console.WriteLine($"El máximo es: {maximo}");

//------------------------
//13 y 14
//string[] equipos = new string[5];
//int valor, j;
//bool encontrado;
//string buscar;

//for (int i = 0; i < equipos.Length; i++)
//{
//    Console.WriteLine($"Ingrese el equipo");
//    equipos[i] = Console.ReadLine();
//}

//foreach (string item in equipos)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("¿qué equipo quiere modificar?");
//valor = int.Parse(Console.ReadLine());

//while (valor != 10)
//{

//    Console.WriteLine("Ingrese el nombre del equipo");
//    equipos[valor] = Console.ReadLine();

//    foreach (string item in equipos)
//    {
//        Console.WriteLine(item);
//    }

//    Console.WriteLine("¿qué equipo quiere modificar?");
//    valor = int.Parse(Console.ReadLine());

//}

//Console.WriteLine("¿Qué equipo quiere buscar?");
//buscar = Console.ReadLine();

//encontrado = false;
//j = 0;
//while (j < equipos.Length && encontrado == false)
//{
//    if (equipos[j] == buscar)
//        encontrado = true;

//    j++;
//}

//if (encontrado == true)
//{
//    Console.WriteLine($"El equipo está en la posición {j}");
//}