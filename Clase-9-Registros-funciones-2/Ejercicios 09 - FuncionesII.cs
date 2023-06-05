namespace FuncionesII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado;
            double result = 0;
            string parteCadena;
            bool pudo;
            Matematicas(5,ref result);
            Console.WriteLine(result);

            Console.WriteLine(ConversionLiquido(0, out resultado));

            pudo = Derecha("Hola mundo", 4, out parteCadena);
            if (pudo)
            {
                Console.WriteLine(parteCadena);
            }

        }
        //1
        static void Cuadrado(int lado, ref int perimetro)
        {
            perimetro = lado * 4;
        }
        //2
        static void Repetir(int cantidad, string letra)
        {
            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine(letra);
            }

        }
        //3
        static void Potencia(int basePotencia, int exponente, out int Resultado)
        {
            Resultado = (int)Math.Pow(basePotencia, exponente);

        }
        //4
        static void Secuencia1(in int max)
        {
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine($"Secuencia {i}");
            }
        }
        //5
        static int Mayor(int valor1, int valor2, int valor3 = 0)
        {
            int maximo = valor1;

            if (valor2 > maximo)
                maximo = valor2;

            if (valor3 > maximo)
                maximo = valor3;

            return maximo;
        }
        //6
        static void Estadistica(int cantidadValores, ref int pares, ref int impares)
        {
            int valor;
            for (int i = 1; i <= cantidadValores; i++)
            {
                Console.WriteLine("Ingrese el valor");
                valor = int.Parse(Console.ReadLine());

                if (valor % 2 == 0)
                    pares++;
                else
                    impares++;
            }
        }
        //7
        void Precio(double importe, double iva, double descuento, ref double importeDto, ref double total)
        {
            importeDto = importe * descuento / 100;
            total = (importe - importeDto) * (iva / 100 + 1);
        }

        //8
        static void Matematicas(int vueltas, ref double resultado)
        {
            resultado = 1;
            for (int i = 1; i <= vueltas; i++)
            {
                resultado = resultado / 2;
            }
        }

        //9
        static bool ConversionLiquido(int valor, out int resultado)
        {
            if (valor == 0)
            {
                resultado = 0;
                return false;
            }
            else
            {
                resultado =  (valor + 100) / valor;
                return true;
            }
                
        }

        static bool ConversionLiquido(double valor, out double resultado)
        {
            if (valor == 0)
            {
                resultado = 0;
                return false;
            }
            else
            {
                resultado = (valor + 100) / valor;
                return true;
            }

        }

        //10
        static bool Izquierda(string cadena, int cantidad, out string resultado)
        {
            if (cantidad > cadena.Length)
            {
                resultado = "";
                return false;
            }

            resultado = cadena.Substring(0, cantidad);
            return true;
        }

        static bool Derecha(string cadena, int cantidad, out string resultado)
        {
            if (cantidad > cadena.Length)
            {
                resultado = "";
                return false;
            }

            resultado = cadena.Substring(cadena.Length - cantidad, cantidad);
            return true;
        }

    }
}