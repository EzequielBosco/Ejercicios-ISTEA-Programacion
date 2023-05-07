namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //10.Ingresar dos valores y
            //obtener la parte entera y el resto de la división.

            int v1, v2, entera, resto;

            Console.WriteLine("V1");
            v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("V2");
            v2 = int.Parse(Console.ReadLine());

            entera = v1 / v2;
            resto = v1 % v2;

            Console.WriteLine(entera);
            Console.WriteLine(resto);

        }
    }
}

////Declaración de variables (espacios reservados de memoria)
//int total; //Camel case
//int valor1, valor2;
//string nombre = "Emanuel", apellido = "Villalva", persona; //Declarando e inicializando
//double temperatura = 37.5;
//float altura, ancho, area;

//altura = 1.78f;
//ancho = 3.45f;
//area = altura * ancho;

//valor1 = 5; //Asignación 
//valor2 = -3; //Asigno un valor a la variable
//total = (7 + 9) * 10 - 10; //lo que está a la derecha del igual se llama expresión
//persona = nombre + " " + apellido;

//Console.WriteLine("Hola mundo");
//Console.WriteLine(valor1);
//Console.WriteLine(nombre);
//Console.WriteLine(total);
//Console.WriteLine(temperatura);
//Console.WriteLine(area);
//Console.WriteLine(persona);
//----------------------------------------------------
////Ingresar el nombre y el apellido y devolver el nombre y luego el apellido
////Declaración de variables
//string nombre, apellido;

////Entrada
//Console.WriteLine("Ingrese el nombre");
//nombre = Console.ReadLine(); //sentencia

//Console.WriteLine("Ingrese el apellido");
//apellido = Console.ReadLine(); //sentencia

////Proceso

////Salida
//Console.WriteLine("El nombre ingresado es");
//Console.WriteLine(nombre);

//Console.WriteLine("El apellido ingresado es");
//Console.WriteLine(apellido);
//---------------------------------------------------
//int edad, altura, temp;
//string temperatura = "35";
//int a = 10, b = 15;

//Console.WriteLine("Ingrese su edad");
//edad = int.Parse(Console.ReadLine());

//altura = int.Parse("178");
//temp = int.Parse(temperatura);

////a = a + b;
//a += b;


//Console.WriteLine(edad);
//Console.WriteLine(altura);
//Console.WriteLine(temp);
//Console.WriteLine(a);

//-----------------------------------------------------------
//string nombre;
//string cita;
//int valor1 = 8, valor2 = 3;

//nombre = null;
//nombre = "";

//cita = "Como dice Anónimo:\"Al que madruga Dios lo ayuda\"";
//Console.WriteLine(cita);
//cita = "Quiero incluir la barra invertida (\\)";
//Console.WriteLine(cita);
//cita = "Quiero incluir la barra invertida (\\)\nOtra línea";
//Console.WriteLine(cita);
//cita = cita + Environment.NewLine + "Otra línea";
//Console.WriteLine(cita);
//cita = "\tOtra línea";
//Console.WriteLine(cita);

//Console.WriteLine((valor1 + valor2).ToString());
//----------------------------------
//string nombre = "Emanuel";
//int edad = 18;

//Console.WriteLine("Mi nombre es " + nombre + " y la edad " + edad);
//Console.WriteLine("Mi nombre es {0} y mi edad es {1}", nombre, edad);
//Console.WriteLine($"Mi nombre es {nombre} y mi edad es {edad}");

//----------------------------------------
////Declaración de variables
//string nombre, apellido;

////Entradas
//Console.WriteLine("Ingrese el nombre");
//nombre = Console.ReadLine();

////Salida
//Console.WriteLine($"El nombre es: {nombre}");

////Entrada
//Console.WriteLine("Ingrese el apellido");
//apellido = Console.ReadLine();

////Salida
//Console.WriteLine($"El apellido es: {apellido}");

//Console.Write("El nombre es " + nombre);
//Console.Write("El apellido es " + apellido);

//--------------------------------------
////6.Pedir la dirección, la altura y la localidad
////en tres variables distintas.
////Mostrar por pantalla lo ingresado por el usuario en una sola frase

//string direccion, altura, localidad;

//Console.WriteLine("Ingrese la direccion");
//direccion = Console.ReadLine();

//Console.WriteLine("Ingrese la altura");
//altura = Console.ReadLine();

//Console.WriteLine("Ingrese la localidad");
//localidad = Console.ReadLine();

//Console.WriteLine($"La dirección es {direccion} {altura}, {localidad}");

//--------------------------------
////7.Devolver la resta de dos números.
////Utilice la resta estándar y el método abreviado.
//int v1, v2;

//Console.WriteLine("Ingrese el valor 1");
//v1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Ingrese el valor 2");
//v2 = int.Parse(Console.ReadLine());

////v1 = v1 - v2;
//v1 -= v2; //v1 restate a vos mismo lo que dice v2

//Console.WriteLine(v1);
