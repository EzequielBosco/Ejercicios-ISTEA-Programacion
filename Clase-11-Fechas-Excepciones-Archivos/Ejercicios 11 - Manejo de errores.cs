using System.Data;

namespace ManejoDeErrores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1
            //int x;
            //int y;
            //try
            //{
            //    Console.WriteLine("Ingrese un valor");
            //    x = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Ingrese un valor");
            //    y = int.Parse(Console.ReadLine());


            //    Console.WriteLine(x + y);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Estoy en finally");

            //}

            //2
            //int[] vector = new int[3];
            //try
            //{
            //    Console.WriteLine(vector[4]);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //3
            int a = 0;
            try
            {
                Cuadrado(0, ref a);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //4
            try
            {
                Repetir(0, "Hola");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //5
            try
            {
                Informacion("", 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        static void Cuadrado(int lado, ref int perimetro)
        {
            if (lado <= 0)
                throw new InvalidDataException("El valor no es válido");
            else
                perimetro = lado * 4;
        }

        static void Repetir(int cantidad, string letra)
        {
            if (cantidad <= 0)
                throw new InvalidDataException("El valor no es válido");

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(letra);
            }
        }

        static void Informacion(string nombre, int edad)
        {
            if (nombre == "" || edad <= 0)
                throw new InvalidDataException("Los parámetros son incorrectos");

            Console.WriteLine($"Nombre {nombre} y edad {edad}");
        }
    }
}