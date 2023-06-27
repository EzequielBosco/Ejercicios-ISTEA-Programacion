using System.Security.Cryptography;

namespace FuncionesI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////11
            //int opcion;
            //int viaje, cantidadP, excursion;

            //do
            //{
            //    Console.WriteLine("Ingrese la opción");
            //    opcion = int.Parse(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            Console.WriteLine("Ingrese el importe del viaje");
            //            viaje = int.Parse(Console.ReadLine());
            //            Console.WriteLine("Ingrese cantidad de personas");
            //            cantidadP = int.Parse(Console.ReadLine());
            //            Console.WriteLine("Ingrese el importe de la excursión");
            //            excursion = int.Parse(Console.ReadLine());
            //            TotalViaje(viaje, cantidadP, excursion);
            //            break;
            //        case 2:
            //            Console.WriteLine("Ingrese cantidad de personas");
            //            cantidadP = int.Parse(Console.ReadLine());
            //            Reserva(cantidadP);
            //            break;
            //        default:
            //            break;
            //    }
            //} while (opcion != 0);

            //12

            int opcion;
            int numero1, numero2;

            do
            {
                Console.WriteLine("Ingrese el número 1");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el número 2");
                numero2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la opción");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("0. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(Suma(numero1, numero2));
                        break;
                    case 2:
                        Console.WriteLine(Resta(numero1, numero2));
                        break;
                    case 3:
                        Console.WriteLine(Multiplicacion(numero1, numero2));
                        break;
                    case 4:
                        Console.WriteLine(Division(numero1, numero2));
                        break;
                    default:
                        break;
                }
            } while (opcion != 0);

        }
        //1
        static int Cuadrado(int numero)
        {
            return numero * numero;
        }
        //2
        static void Informacion(string nombre, int edad)
        {
            Console.WriteLine($"Su nombre es {nombre} y su edad es {edad}");
        }
        //4
        static int Sumatoria(int numero)
        {
            int suma = 0;

            for (int i = 1; i < numero; i++)
            {
                suma += i;
            }

            return suma;
        }
        //5
        static int Sumatoria2(int numero)
        {
            int suma = 0;
            if (numero == 0)
                return -1;

            for (int i = 1; i <= numero; i++)
            {
                suma += i;
            }

            return suma;
        }
        //6
        static int Resta(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        //7
        static string Unir(string cadena1, string cadena2)
        {
            return cadena1 + cadena2;
        }
        //8
        static int Factorial(int numero)
        {
            int resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }

            return resultado;
        }
        //9
        static void Opciones()
        {
            Console.WriteLine("Bienvenido al Restaurante. Sus opciones son:");
            Console.WriteLine("1- Cargar un nuevo menú");
            Console.WriteLine("2 - Finalizar la cuenta");
            Console.WriteLine("3 - Salir");
        }

        //10
        static int Remeras(int cantidad)
        {
            int hilo = 0;
            for (int i = 1; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese la cantidad de hilos");
                hilo += int.Parse(Console.ReadLine());
            }

            return hilo;
        }

        //11
        static int TotalViaje(int importe, int cantidadP, int excursion)
        {
            return importe * cantidadP + excursion * cantidadP;
        }

        static void Reserva(int cantidad)
        {
            for (int i = 1; i <=0; i++)
            {
                Console.WriteLine($"Pasaje {i} reservado");
            }
        }

        //12
        static int Suma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        static int Multiplicacion(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        static int Division(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
    }

}