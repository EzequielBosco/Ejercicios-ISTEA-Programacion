using System.IO;
using System.Text;
using System.Reflection.Emit;

namespace Consola
{
    class Program
    {
        // variable global
        static int x, suma, perimetro = 0, valor;
        string a, b;

        // funciones simples
        static int Multiplicar(int valor)
        {
            return valor * valor;
        }

        // funcion imprimir
        static void Imprimir(object mensaje) {
            string mensajeString = mensaje.ToString();
            Console.WriteLine(mensajeString);
        }

        // funcion opciones
        static void Opciones()
        {
            Console.WriteLine("Las opciones son:");
            Console.WriteLine("1. ");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("Ingrese un valor");
        }

        // funcion ref
        static void Cuadrado(int lados, ref int perimetro) {
          perimetro = lados * 4;
        }

        // out
        static bool Verdadero(int valor, out int resultado) {
          if (valor == 0){
            resultado = 0;
            return false;
          } 
          resultado = valor;
          return true;
        }

        // RECORD
        record Persona {
          public string nombre { get; set; }
          public int edad { get; set; }
        }

        // record vector
        record Producto
        {
            public int codigo { get; set; }
            public int precio { get; set; }
        }

        // DELEGADOS
        delegate int Area(int valor);
        // comparison
        static int Comparar(string a, string b) {
          return String.Compare(a, b);
        }

        //action
        static void Imprimir1(string a) {
          Imprimir($"{a}");
        }

        // funcs
        static string Ejecutar(int x, int y) {
          if (x >= y)
            return "El primer numero es mayor";
          else 
            return "El segundo numero es mayor";
        }

        // predicate
        static bool EsMayor(Persona unaPersona) {
          if (unaPersona.edad >= 18)
            return true;
          else
            return false;
        }

        static void Main(string[] args)
        {
            x = 5;
            // FUNCION simple
            numero(x);

            static int numero(int a) {
                Imprimir(a);
                return a;
            }


            // FUNCION ref
            Cuadrado(10, ref perimetro);
            Imprimir(perimetro);

            // FUNCION out
            bool verdadero;
            int resultado;

            verdadero = Verdadero(0, out resultado);
            if (verdadero) {
              Imprimir($"El resultado es: {resultado}");
            } else {
              Imprimir("No se pudo resolver");
            }

            // MATRIZ
            int[,] matriz = { { 4, 7, 9 }, { 2, 0, 7 }, { 8, 0, 1 } };

            //suma especifica
            Console.WriteLine(matriz[0, 2] + matriz[1,1]);

            // recorrer
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Imprimir($"Posición [{i},{j}] = {matriz[i,j]}");
                }
            }

            // promedio por columna
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
               suma = 0;
               for (int j = 0; j < matriz.GetLength(1); j++)
               {
                   suma += matriz[i, j];
               }
               Imprimir($"El alumno {matriz[i, 0]} tiene un promedio de {suma / matriz.GetLength(1)}");
            }

            // promedio por fila
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                suma = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    suma += matriz[i, j];

                }
                Imprimir($"El promedio es {suma / matriz.GetLength(0)}");
            }

            // RECORD
            Persona ezequiel = new Persona() {
              nombre = "Ezequiel", edad = 22
            };
            Imprimir(ezequiel.nombre);

            // record vector
            Producto[] productos = new Producto[5];
            Random r = new Random();

            for (int i = 0; i < productos.Length; i++) {
              productos[i] = new Producto();
              productos[i].codigo = r.Next(1000,2001);
              productos[i].precio = r.Next(8000, 15000);
            }
            
            foreach (Producto producto in productos) {
              Imprimir(producto);
            }

            // DELEGADOS
            Area cuadrado = Multiplicar;
            Imprimir($"El area de un cuadrado es {cuadrado(4)}");
            // comparison
            Comparison<string> Comparacion;
            Comparacion = Comparar;
            Imprimir(Comparacion("aaab", "aaaa"));

            // action
            Action<string> Impresion;
            Impresion = Imprimir1;
            Impresion("hola");

            // funcs
            Func<int, int, string> funcs;
            funcs = Ejecutar;
            Imprimir($"Func: {funcs(3, 5)}");

            // predicate
            Predicate<Persona> VoF;
            VoF = EsMayor;
            Persona Emiliano = new Persona() {
              edad = 20
            };
            Imprimir($"El alumno {(VoF(Emiliano) ? "es mayor" : "es menor")}");

            // funcion anonima
            Predicate<Persona> EsMenor = unaPersona => unaPersona.edad < 18;
            if (EsMenor(Emiliano))
              Imprimir("El alumno es menor");
            else
              Imprimir("El alumno es mayor");
            

            // ARCHIVOS

            string contenido = "contenido de prueba", contenido1 = $"otro contenido \ntexto", texto;

            if (File.Exists("texto.txt"))
              Imprimir("Existe");
            else 
              Imprimir("No existe");
              File.WriteAllText("texto.txt", contenido);

            
            texto = File.ReadAllText("texto.txt");
            Imprimir(texto);
            foreach (string linea in File.ReadAllLines("texto.txt")) {
              Imprimir(linea);
            } 

            File.WriteAllText("textos.txt", contenido1);
            string[] textos = File.ReadAllLines("textos.txt", Encoding.UTF8);
            foreach (string linea in textos) {
              Imprimir(linea);
            } 

            // EXCEPCIONES
            try
            {
              Hacer(4, 7);
            }
            catch (Exception ex)
            {
              Console.WriteLine(ex.Message);
            }

            static void Hacer(int x, int y) {
            if (x < y)
              throw new ArgumentException("El primer valor no puede ser menor");
            }
            
            // fechas
            DateTime fechaAhora = DateTime.Now;
        }
    }
}