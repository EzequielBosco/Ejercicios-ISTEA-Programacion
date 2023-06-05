namespace Consola
{
    class Program
    {
        record Persona
        {
            public int Edad { get; set; }
            public string Altura { get; set; }
            public Propiedades misPropiedades { get; set; }

        }

        record Propiedades
        {
            public string tipoCasa { get; set; }
            public int cantidadHabitaciones { get; set; }
        }

        record Alumno
        {
            public int legajo { get; set; }
            public int calificacion { get; set; }
        }



        static void Main(string[] args)
        {

            string salud = "tengo";
            int noTiene, tiene;

            noTiene = salud.IndexOf("0");
            Console.WriteLine(noTiene);

            tiene = salud.IndexOf("o");
            Console.WriteLine(tiene);

            //int perimetro = 0;
            //Cuadrado(5, ref perimetro);

            //Console.WriteLine($"Perímetro {perimetro}");

            //int resultado;
            //Potencia(2, 3, out resultado);

            //Console.WriteLine($"Valor {resultado}");

            //int maximo = 4;
            //Secuencia1(in maximo);

            bool pudo;
            int resultado2;
            pudo = ConversionLiquido(0, out resultado2);
            if (pudo)
            {
                Console.WriteLine($"El resultado es {resultado2}");
            }
            else
                Console.WriteLine("No se pudo resolver");

        }

        static void Cuadrado(int lado, ref int perimetro)
        {
            perimetro = lado * 4;
        }

        static void Potencia(int baseNumero, int exponente, out int Resultado)
        {
            //Castear => Cast
            Resultado = (int)Math.Pow(baseNumero, exponente);
        }

        static void Secuencia1(in int max)
        {
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine(i);
            }
        }

        static bool ConversionLiquido(int valor, out int resultado)
        {
            if (valor == 0)
            {
                resultado = 0;
                return false;
            }

            resultado = (valor + 100) / valor;
            return true;

        }
    }
}

//Persona unaPersona = new Persona();
//unaPersona.Altura = "1.8m";
//unaPersona.Edad = 40;

//Console.WriteLine($"La edad es {unaPersona.Edad} y la altura es {unaPersona.Altura}");

//Persona unaPersona2 = new Persona()
//{
//    Altura = "1.6m",
//    Edad = 35
//};
//Console.WriteLine($"La edad es {unaPersona2.Edad} y la altura es {unaPersona2.Altura}");

//Persona[] lista = new Persona[5];
//Random r = new Random();


//Console.WriteLine("Vectores de registro");
//for (int i = 0; i < lista.Length; i++)
//{
//    lista[i] = new Persona()
//    {
//        Altura = "2m",
//        Edad = r.Next(18, 66)
//    };
//}

//foreach (Persona item in lista)
//{
//    Console.WriteLine($"La altura es {item.Altura} y la edad es {item.Edad}");
//}

//for (int i = 0; i < lista.Length; i++)
//{
//    Console.WriteLine($"La altura es {lista[i].Altura} y la edad es {lista[i].Edad}");
//}

////Persona unaPersonaConCasa = new Persona();
////unaPersona.misPropiedades = new Propiedades();

////unaPersona.Edad = 16;
////unaPersona.misPropiedades.tipoCasa = "Mansión";
///
//            Random r = new Random();
//Alumno[] listaAlumnos = new Alumno[10];
//Alumno[] segundoParcial = new Alumno[10];
//int numeroLegajo = 1000;
//int sumatoria = 0;

//for (int i = 0; i < listaAlumnos.Length; i++)
//{
//    listaAlumnos[i] = new Alumno();
//    listaAlumnos[i].legajo = numeroLegajo;
//    listaAlumnos[i].calificacion = r.Next(1, 11);

//    numeroLegajo++;
//}

//for (int i = 0; i < listaAlumnos.Length; i++)
//{
//    Console.WriteLine(listaAlumnos[i].calificacion);
//    sumatoria += listaAlumnos[i].calificacion;
//}

//Console.WriteLine($"El promedio es {sumatoria / listaAlumnos.Length}");

////Copiar de un arrelgo a otro
//for (int i = 0; i < listaAlumnos.Length; i++)
//{
//    segundoParcial[i] = new Alumno();
//    segundoParcial[i].legajo = listaAlumnos[i].legajo;
//    segundoParcial[i].calificacion = listaAlumnos[i].calificacion;
//}
