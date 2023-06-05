namespace Consola
{
    delegate int Operacion(int a, int b);
    delegate int Areas(int lado);

    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado[] listaEmpleados = new Empleado[5];
            CargarEmpleados(listaEmpleados);
            Array.ForEach(listaEmpleados, Aumento);
            Console.WriteLine("Sin aumento");
            ImprimirEmpleado(listaEmpleados);
            Array.ForEach(listaEmpleados, Aumentar);
            Console.WriteLine("Con aumento");
            ImprimirEmpleado(listaEmpleados);

        }

        static void Aumento(Empleado unEmpleado)
        {
            if (unEmpleado.sueldo >= 200000 && unEmpleado.sueldo <= 250000)
                Console.WriteLine($"El empleado {unEmpleado.legajo} recibe un aumento del 15%");
            else
                Console.WriteLine($"El empleado {unEmpleado.legajo} recibe un aumento del 10%");
        }

        static void Aumentar(Empleado unEmpleado)
        {
            if (unEmpleado.sueldo >= 200000 && unEmpleado.sueldo <= 250000)
                unEmpleado.sueldo = unEmpleado.sueldo * 1.15;
            else
                unEmpleado.sueldo = unEmpleado.sueldo * 1.10;
        }

        static void ImprimirEmpleado(Empleado[] unEmpleado)
        {
            foreach (var item in unEmpleado)
            {
                Console.WriteLine($"Empleado {item.legajo} cobra {item.sueldo}");
            }
            
        }

        record Empleado
        {
            public int legajo { get; set; }
            public double sueldo { get; set; }
        }

        static void CargarEmpleados(Empleado[] v)
        {
            Random r = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = new Empleado();
                v[i].legajo = r.Next(1000,2000);
                v[i].sueldo = r.Next(200000,300000);
            }
        }

        static void CargarCoches(Coche[] v)
        {
            Random r = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = new Coche();
                v[i].modelo = "VW";
                v[i].cantidadPuertas = r.Next(3, 6);
            }
        }

        static void Imprimir(Coche[] v)
        {
            foreach (Coche item in v)
            {
                Console.WriteLine($"El coche {item.modelo} tiene {item.cantidadPuertas}");
            }
        }


        record Coche
        {
            public string modelo { get; set; }
            public int cantidadPuertas { get; set; }
        }


        static bool miExists(int[] v, Predicate<int> predicado)
        {
            bool existe = false;
            for (int i = 0; i < v.Length; i++)
            {
                existe = predicado(v[i]);
                if (existe) //true
                    break;
            }

            return existe;
        }

        static bool EsMayorQueCinco(int valor)
        {
            if (valor > 5)
                return true;
            else
                return false;
        }

        static int Multiplicacion (int a, int b)
        {
            return a * b;
        }

        static int Resta (int x, int y)
        {
            return x - y;
        }

        static int Cuadrado(int lado)
        {
            return lado * lado;
        }

        static int Comparacion (string a, string b)
        {
            return String.Compare(a, b);
        }

        static void Impresion (double altura, double peso, int edad)
        {
            if (altura > 1.80 && peso > 100 && edad > 65)
            {
                Console.WriteLine("Sus datos nos preocupan");
            }
        }

        static int TamanioCasa (int habitaciones, int pisos)
        {
            if (habitaciones > 2 && pisos > 1)
                return 1;
            else
                return 0;
        }

        record Alumno
        {
            public string nombre { get; set; }
            public int edad { get; set; }
        };

        static bool MayorEdad (Alumno unAlumno)
        {
            if (unAlumno.edad >= 18)
                return true;
            else
                return false;
        }

        static void Repetir(int cantidad, string letra)
        {
            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine(letra);
            }
        }

        static int Potencia(int basePotencia, int exponente)
        {
            int baseNumero = 1;
            for (int i=1; i<= exponente; i++)
            {
                baseNumero *= basePotencia;
            }
            return baseNumero;
        }
    }
}

//Delegados

//Operacion unaOperacion;

//unaOperacion = Multiplicacion;
//Console.WriteLine(unaOperacion(4, 9));

//unaOperacion = Resta;
//Console.WriteLine(Resta(4, 9));

//Areas unaFigura = Cuadrado;

//Console.WriteLine($"El Área de una figura de 8cm es {unaFigura(8)}cm");

//------------------------------
//Comparison<string> comparador = Comparacion;
//Console.WriteLine(comparador("Adiós", "Abeja"));

//Comparison<string> comparador2 = Comparacion;
//Console.WriteLine(comparador("Adiós", "Abeja"));


//Action<double, double, int> informes = Impresion;
//informes(1.9, 150, 68);

//Func<int, int, int> analisis = TamanioCasa;
//Console.WriteLine($"Análisis: {analisis(2, 1)}");

//Predicate<Alumno> unAlumno;
//unAlumno = MayorEdad;
//Alumno ejemplo = new Alumno()
//{
//    nombre = "Emanuel",
//    edad = 37
//};
//Console.WriteLine($"El alumno, ¿es mayor de edad? {(unAlumno(ejemplo) ? "SI" : "NO")}");

//Action<int, string> miAccion = Repetir;
//miAccion(5, "j");

//Func<int, int, int> opera = Potencia;
//Console.WriteLine($"La potencia en 4 y 7 es {opera(4, 7)}");

//FUNCIONDES/DELEGADOS CON FUNCIONES DE ARRAYS
//Array.algo
//int[] vector = { 4, 9, 7, 2, 1 };
//bool existe = false;

//for (int i = 0; i < vector.Length; i++)
//{
//    existe = EsMayorQueCinco(vector[i]);
//    if (existe) //true
//        break;
//}

//if (existe)
//    Console.WriteLine("Hay un elemento mayor que 5");

//existe = false;
//existe = Array.Exists(vector, EsMayorQueCinco);

//if (existe)
//    Console.WriteLine("Con Array.Exists: Hay un elemento mayor que 5");

//existe = false;
//existe = miExists(vector, EsMayorQueCinco);

//if (existe)
//    Console.WriteLine("Mi propia función: Hay un elemento mayor que 5");

//-----------------------------------------
//Aplicación de Expresiones lambda y funciones anónimas
//Predicate<int> esMayorQueCinco = (x) => {
//    if (x > 5)
//    {

//        return true;
//    }
//    else
//        return false;
//};

//int[] vector = { 4, 9, 7, 2, 1 };
//bool existe = false;

//existe = Array.Exists(vector, x => { if (x % 2 == 0) return true; else return false; });

//Console.WriteLine(existe);

//existe = Array.Exists(vector, x => x % 2 == 0);

//8
//Ejercicio 8
//Coche[] listaCoches = new Coche[5];
//Coche[] ConCincoPuertas;
//CargarCoches(listaCoches);
//Imprimir(listaCoches);
//ConCincoPuertas = Array.FindAll(listaCoches, x => x.cantidadPuertas == 5);
//Console.WriteLine("Los que tienen 5 puertas son");
//Imprimir(ConCincoPuertas);