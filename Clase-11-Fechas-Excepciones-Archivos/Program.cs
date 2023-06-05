﻿using System;
using System.Data;
using System.Linq.Expressions;
using System.IO;
using System.Text;
using System.Reflection.Emit;

namespace Consola
{
    class Program
    {

        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2023, 5, 1);
            Console.WriteLine(fecha);

            DateTime fechaAhora = DateTime.Now;
            Console.WriteLine(fechaAhora);

            string[] lineas = File.ReadAllLines("paises.txt", Encoding.UTF8);
            int maximo = 0;
            string pais = "";
            bool b = true;

            //Afganistán;Kabul;Asia
            for (int i = 1; i < lineas.Length; i++)
            {
                string[] partes = lineas[i].Split(';');

                if (b)
                {
                    maximo = partes[0].Length;
                    pais = partes[0];
                }
                    
                else if (partes[0].Length > maximo)
                {
                    maximo = partes[0].Length;
                    pais = partes[0];
                }

                if (partes[2] == "Europa")
                    File.AppendAllText("Europa.txt", partes[0] + "\n", Encoding.Unicode);


            }

            File.WriteAllText("maximo.txt", pais);

        }

        static void prueba(int[] vector)
        {
            Console.WriteLine(vector[10]);
        }

        static int division(int x, int y)
        {
            if (y == 0)
                throw new Exception("La variable y no puede ser cero");

            return x / y;
        }

        static void Cuadrado(int lado, ref int perimetro)
        {
            if (lado <= 0)
                perimetro = -1;
                //throw new ArgumentException("El lado no puede ser cero o negativo");

            perimetro = lado * 4;
        }
    }
}

// Fechas y Timespan
//DateTime fecha = new DateTime(2023, 5, 29);
//DateTime fecha2;

//Console.WriteLine(fecha);

//fecha2 = fecha.AddMinutes(150);

//Console.WriteLine(fecha);
//Console.WriteLine(fecha2);

//Console.WriteLine($"Año: {fecha2.Year} - Minutos: {fecha2.Minute}");

//fecha2 = fecha.AddMinutes(-150);
//Console.WriteLine(fecha2);

//Console.WriteLine(DateTime.Now);

//DateTime fechaHoraActual = DateTime.Now;
//Console.WriteLine(fechaHoraActual);

//Errores
//try
//{
//    string x = "Hola";
//    int y;
//    bool b;

//    y = int.Parse(x);
//    b = int.TryParse("Hola", out y);

//    if (b)
//    {
//        Console.WriteLine("Conversión exitosa");
//    }
//    else
//    {
//        Console.WriteLine("Conversión errónea");
//    }
//}
//catch (Exception error)
//{
//    Console.WriteLine(error.Message);
//}
//finally
//{
//    Console.WriteLine("Cierre de programa normal");
//}

//Errores en main
//int x, y;

//x = 5;
//y = 6;

//try
//{
//    if (x < y)
//        throw new Exception("El primero es menor");

//    if (x > y)
//        Console.WriteLine("Está ok");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Uso en función
//int x, y;

//x = 5;
//y = 6;

//try
//{
//    Console.WriteLine(division(5, 0));
//}
//catch (Exception e)
//{
//    // Modificar el mensaje de excepción.
//    string mensaje = "Ocurrió el siguiente error: " + e.Message;
//    Console.WriteLine(mensaje);
//}

//Ej 2
//int[] v = new int[5];

//try
//{
//    prueba(v);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//            int resultado = 0;
//try
//{
//    Cuadrado(0, ref resultado);
//    Console.WriteLine("Si no se produjo error");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Archivos
//Console.WriteLine(Path.GetDirectoryName("C:\\Hola\\mundo.txt"));
//Console.WriteLine(Path.DirectorySeparatorChar);

//if (!File.Exists("tanque.txt"))
//{
//    Console.WriteLine("EL archivo no existe");
//    return;
//}

//string cadena = File.ReadAllText("tanque.txt");
//Console.WriteLine(cadena);

//Console.WriteLine("Modo vector");

//foreach (string item in File.ReadAllLines("tanque.txt"))
//{
//    Console.WriteLine(item);
//    //lógica
//}

//string escritura = "escribo \n un texto";
//File.WriteAllText("pruebaEscritura.txt", escritura);

//string[] lineas = new string[3];
//lineas[0] = "primer línea";
//lineas[1] = "segunda línea";
//lineas[2] = "tercera línea";
//File.WriteAllLines("pruebaEscritura2.txt", lineas);

////Append
//File.AppendAllText("pruebaEscritura.txt", "nuevo texto");
//File.AppendAllLines("pruebaEscritura2.txt", lineas);

//Ej 2 de archivos
//int valor1;
//int valor2;
//int resultado;

//Console.WriteLine("Ingrese un valor");
//valor1 = int.Parse(Console.ReadLine());

//while (valor1 != 0)
//{
//    try
//    {
//        Console.WriteLine("Ingrese un valor");
//        valor2 = int.Parse(Console.ReadLine());

//        resultado = valor1 / valor2;
//        //“FechaHora actual - OK - XXX” 
//        string mensaje = DateTime.Now.ToString() + " - OK - " + resultado.ToString() + Environment.NewLine;
//        File.AppendAllText("log.txt", mensaje);
//    }
//    catch (Exception ex)
//    {
//        //“FechaHora actual - ERROR - Mensaje”
//        string mensaje = DateTime.Now.ToString() + " - ERROR - " + ex.Message + "\n";
//        File.AppendAllText("log.txt", mensaje);
//    }
//    finally
//    {
//        Console.WriteLine("Ingrese un valor");
//        valor1 = int.Parse(Console.ReadLine());
//    }
//}