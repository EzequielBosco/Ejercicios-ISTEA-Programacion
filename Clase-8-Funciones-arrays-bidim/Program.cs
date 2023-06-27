namespace Consola
{
    class Program
    {
        //static string mensaje = "ERROR FEO!!!!";
        static void Main(string[] args)
        {

            // ejercicio 12

            string entrada;
            int a, b;

            do {
            Console.WriteLine("Introduce el primer número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segudo número");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduce una opcion \n1- Sumar \n2- Restar \n3- Multiplicar \n4- Dividir \n0- Salir");
            entrada = Console.ReadLine();
        
            switch (entrada) {
                case "1":
                    suma(a, b);
                    break;
                case "2":
                    resta(a, b);
                    break;
                case "3":
                    multiplicar(a, b);
                    break;
                case "4":
                    dividir(a, b);
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("El numero ingresado es incorrecto");
                    break;
            }
            } while (entrada != "0");
            


        }

        // int[,] matriz = { { 4, 7, 9 }, 
        //                   { 2, 0, 7 }, 
        //                   { 8, 0, 1 } 
        // };

        // Console.WriteLine(matriz[0, 2] + matriz[1,1]);

        // for (int i = 0; i < matriz.GetLength(0); i++)
        // {
        //     //i = 0
        //     for (int j = 0; j < matriz.GetLength(1); j++)
        //     {
        //         Console.WriteLine($"Posición [{i},{j}] = {matriz[i,j]}");
        //     }
        // }

        // //Inicialización todo en cero
        // for (int i = 0; i < matriz.GetLength(0); i++)
        // {
        //     //i = 0
        //     for (int j = 0; j < matriz.GetLength(1); j++)
        //     {
        //         matriz[i, j] = 0;
        //     }
        // }

        // Console.WriteLine(numero(matriz));

        // static int numero(int[,] a) {
        //     return a[0,1] + a[1,1];
        // }
        // -------------------------------------------------

        // static void Opciones()
        // {
        //     Console.WriteLine("Las opciones son:");
        //     Console.WriteLine("1. Total");
        //     Console.WriteLine("2. Pasajes reservados");
        //     Console.WriteLine("Ingrese el valor");
        // }

        //Cargar un importe de un viaje, la cantidad de personas
        //y el importe de una excursión y devolver el total.
        /// <summary>
        /// Da el total de la excursión
        /// </summary>
        /// <param name="viaje">Monto de viaje</param>
        /// <param name="personas">Cantidad de personas</param>
        /// <param name="excursion">Monto de excursión</param>
        /// <returns>Total de la excursión</returns>
        static int TotalExcursion(int viaje, int personas, int excursion)
        {
            return (viaje + excursion) * personas;
        }

        static void Reservas(int cantidad)
        {
            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine($"Pasaje {i} reservado");
            }
        }

        static int suma(int x, int y)
        {
            int resultado;
            resultado = x + y;
            Console.WriteLine(resultado);
            return resultado;
        }

        static int resta(int x, int y)
        {
            int resultado;
            resultado = x - y;
            Console.WriteLine(resultado);
            return resultado;
        }

        static int multiplicar(int a, int b)
        {
            int resultado;
            resultado = a * b;
            Console.WriteLine(resultado);
            return resultado;
        }

        static int dividir(int a, int b)
        {
            int resultado;
            resultado = a / b;
            Console.WriteLine(resultado);
            return resultado;
        }
        static int Cuadrado(int numero)
        {
            return numero * numero;
        }

        static void Informacion(string nombre, int edad)
        {
            if (nombre == "")
            {
                return;
            }

            Console.WriteLine($"Su nombre es {nombre} y su edad es {edad}");
        }
        static int Sumatoria(int numero)
        {
            int suma = 0;
            for (int i = 1; i <= numero; i++)
            {
                suma += i;
            }

            return suma;
        }

        static void Informacion()
        {
            Console.WriteLine("Ingrese un valor");
        }
    }
}

// int resultado, resultado2;
//int x = 8;
//int y = 9;
//resultado = suma(4, 8) + suma(7, 9);
//resultado2 = suma(x, y);
//Console.WriteLine(resultado);

//1
//Console.WriteLine($"El cuadrado de 8 es {Cuadrado(8)}");
//Console.WriteLine(Cuadrado(suma(4, 7)));

//Informacion();
//int valor = int.Parse(Console.ReadLine());

//Console.WriteLine($"La sumatoria es {Sumatoria(valor)}");

//11
//int valor, viaje, personas, excursion;

//do
//{
//    Opciones();
//    valor = int.Parse(Console.ReadLine());

//    switch (valor)
//    {
//        case 1:
//            Console.WriteLine("Ingrese el monto del viaje");
//            viaje = int.Parse(Console.ReadLine());
//            Console.WriteLine("Ingrese cantidad de personas");
//            personas = int.Parse(Console.ReadLine());
//            Console.WriteLine("Ingrese monto de excursión");
//            excursion = int.Parse(Console.ReadLine());
//            Console.WriteLine(TotalExcursion(viaje, personas, excursion));
//            break;
//        case 2:
//            Console.WriteLine("Cantidad de reservas");
//            viaje = int.Parse(Console.ReadLine());
//            Reservas(viaje);
//            break;
//        default:
//            break;
//    }


//} while (valor != 0);

//            Informacion("", 20);
//Informacion("Emanuel", 20);