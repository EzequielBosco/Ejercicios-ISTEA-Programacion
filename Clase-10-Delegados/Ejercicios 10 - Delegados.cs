using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace Delegados
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //1
            //delegado
            cuadrado miFuncion = Cuadrado;
            Console.WriteLine(miFuncion(8));
            //función anónima
            miFuncion = (x) => { return x * x; };
            Console.WriteLine(miFuncion(8));

            //2
            sumatoria miFuncionSumatoria = Sumatoria;
            Console.WriteLine(miFuncionSumatoria(8));
            miFuncionSumatoria = (x) =>
            {
                int suma = 0; 
                for (int i = 1; i <= x; i++)
                {
                    suma += i;
                }

                return suma;
            };
            Console.WriteLine(miFuncionSumatoria(8));
            
            //3
            Action<int, string> miAccion = Repetir;
            miAccion(4, "m");
            miAccion = (cantidad, letra) =>
            {
                for (int i = 1; i <= cantidad; i++)
                {
                    Console.WriteLine(letra);
                }
            };
            miAccion(7, "a");

            //4
            Func<int, int, int> miFuncion2 = Potencia;
            Console.WriteLine(miFuncion2(3, 4));

            //5
            Action<int> miAccion2 = Secuencia;
            miAccion2(5);

            //6
            Comparison<int> miComparacion = Mayor;
            Console.WriteLine(miComparacion(4, 8));

            //7
            Persona unaPersona = new Persona();
            unaPersona.Nombre = "Ana";
            unaPersona.Edad = 25;

            Persona unaPersona2 = new Persona();
            unaPersona2.Nombre = "Lorena";
            unaPersona2.Edad = 30;

            Func<Persona, Persona, int> compararEdades = Mayor;
            Console.WriteLine(Mayor(unaPersona, unaPersona2));


            //8
            Coche[] listaCoches = new Coche[5];
            Random r = new Random();
            for (int i = 0; i < listaCoches.Length; i++)
            {
                listaCoches[i] = new Coche();
                listaCoches[i].Modelo = "VW";
                listaCoches[i].cantPuertas = r.Next(4, 7);
            }

            Coche[] cochesPuertas = Array.FindAll<Coche>(listaCoches, TienePuertas);
            foreach (Coche item in cochesPuertas)
            {
                Console.WriteLine($"El modelo {item.Modelo} tiene {item.cantPuertas} puertas");
            }

            //9
            Empleado[] listaEmpleados = new Empleado[5];
            Random r2 = new Random();
            for (int i = 0; i < listaEmpleados.Length; i++)
            {
                listaEmpleados[i] = new Empleado();
                listaEmpleados[i].legajo = r2.Next(1000,2001);
                listaEmpleados[i].sueldo = r2.Next(200000, 300000);
            }

            foreach (Empleado item in listaEmpleados)
            {
                Console.WriteLine($"El empleado {item.legajo} cobra {item.sueldo}");
            }

            Array.ForEach<Empleado>(listaEmpleados,ActualizarEmpleado);

            foreach (Empleado item in listaEmpleados)
            {
                Console.WriteLine($"El empleado {item.legajo} cobra {item.sueldo}");
            }

            Console.WriteLine("Ingrese un legajo (debe existir en la lista, caso contrario genera excepción)");
            int legajo = int.Parse(Console.ReadLine());

            Empleado? empEncontrado = Array.Find<Empleado>(listaEmpleados, (x) => x.legajo == legajo);

            Console.WriteLine($"Su sueldo es {empEncontrado.sueldo}");

            //10
            Casa[] listaCasas = new Casa[4];
            listaCasas[0] = new Casa();
            listaCasas[0].ubicacion = "Pilar";
            listaCasas[0].cantHabitaciones = 4;

            listaCasas[1] = new Casa();
            listaCasas[1].ubicacion = "Escobar";
            listaCasas[1].cantHabitaciones = 3;

            listaCasas[2] = new Casa();
            listaCasas[2].ubicacion = "Caballito";
            listaCasas[2].cantHabitaciones = 2;

            listaCasas[3] = new Casa();
            listaCasas[3].ubicacion = "Lomas de Zamora";
            listaCasas[3].cantHabitaciones = 3;

            Casa[] listsaTresHabitaciones = Array.FindAll(listaCasas, tieneHabitaciones);

            foreach (var item in listsaTresHabitaciones)
            {
                Console.WriteLine($"La casa de {item.ubicacion} tiene {item.cantHabitaciones} haticaiones");
            }

            //11
            Console.WriteLine("Ejercicio 11");
            Producto[] listaProductos = new Producto[10];
            for (int i = 0; i < listaProductos.Length; i++)
            {
                listaProductos[i] = new Producto();
                listaProductos[i].codigo = r2.Next(1000, 2001);
                listaProductos[i].devolucion = r2.Next(1, 5);
            }

            Array.ForEach(listaProductos, x => { if (x.devolucion == 2 || x.devolucion == 3) x.devolucion = -1; });

            Producto[] listaNegativos = Array.FindAll(listaProductos, x => x.devolucion == -1);

            foreach (Producto item in listaNegativos)
            {
                Console.WriteLine($"Codigo {item.codigo}");
            }

        }

        //1
        delegate int cuadrado(int a);
        static int Cuadrado(int x)
        {
            return x * x;
        }

        //2
        delegate int sumatoria(int b);

        static int Sumatoria(int y)
        {
            int suma = 0;
            for (int i = 1; i <= y; i++)
            {
                suma += i;
            }

            return suma;
        }

        //3
        static void Repetir(int cantidad, string letra)
        {
            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine(letra);
            }
        }

        //4
        static int Potencia(int basePotencia, int exponente)
        {
            int resultado = 1;
            for (int i = 1; i <= exponente; i++)
            {
                resultado *= basePotencia;
            }

            return resultado;
        }

        //5
        static void Secuencia(int max)
        {
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine(i);
            }
        }

        //6
        static int Mayor(int valor1, int valor2)
        {
            if (valor1 > valor2)
                return 1;
            else if (valor1 == valor2)
                return 0;
            else
                return -1;
        }

        //7
        record Persona{
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }
        static int Mayor(Persona valor1, Persona valor2)
        {
            if (valor1.Edad > valor2.Edad)
                return 1;
            else if (valor1.Edad == valor2.Edad)
                return 0;
            else
                return -1;
        }

        //8
        record Coche
        {
            public string Modelo { get; set; }
            public int cantPuertas { get; set; }
        }

        static bool TienePuertas(Coche unCoche)
        {
            if (unCoche.cantPuertas == 5)
                return true;
            else
                return false;
        }

        //9
        record Empleado
        {
            public int legajo { get; set; }
            public double sueldo { get; set; }
        }

        static void ActualizarEmpleado(Empleado unEmpleado)
        {
            if (unEmpleado.sueldo >= 200000 && unEmpleado.sueldo <= 250000)
                unEmpleado.sueldo = unEmpleado.sueldo * 1.15;
            else
                unEmpleado.sueldo = unEmpleado.sueldo * 1.10;
        }

        //10
        record Casa
        {
            public int cantHabitaciones { get; set; }
            public string ubicacion { get; set; }
        }

        static bool tieneHabitaciones(Casa unaCasa)
        {
            if (unaCasa.cantHabitaciones == 3)
                return true;
            else
                return false;
        }

        //11
        record Producto
        {
            public int codigo { get; set; }
            public int devolucion { get; set; }
        }
    }
}