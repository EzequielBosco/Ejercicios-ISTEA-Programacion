namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.Armar un menú tal que según el número ingresado 
            //    realice las siguientes acciones:
            //a.  1: Pida un valor entre 1 y 10 e indique si es par o no.
            //b.  2: Pida dos números y muestre el menor de los dos.

            int opcion, numero, numero2;

            Console.WriteLine("Ingrese la opción");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    //1: Pida un valor entre 1 y 10 e indique si es par o no.
                    Console.WriteLine("Inrgese un valor entre 1 y 10");
                    numero = int.Parse(Console.ReadLine());

                    if (numero % 2 == 0)
                        Console.WriteLine("Es par");
                    else
                        Console.WriteLine("Es impar");
                    break;
                case 2:
                    //2: Pida dos números y muestre el menor de los dos.
                    Console.WriteLine("Inrgese un valor");
                    numero = int.Parse(Console.ReadLine());

                    Console.WriteLine("Inrgese otro valor");
                    numero2 = int.Parse(Console.ReadLine());

                    if (numero < numero2)
                        Console.WriteLine(numero);
                    else if (numero2 < numero)
                        Console.WriteLine(numero2);
                    break;
                default:
                    Console.WriteLine("Incorrecto");
                    break;
            }
        }
    }
}

//int valor1, valor2;

//valor1 = 10;
//valor2 = 20;

//if (valor1 > valor2)
//    Console.WriteLine("El primero es mayor");
//else if (valor1 == valor2)
//    Console.WriteLine("Son iguales");
//else
//    Console.WriteLine("El primero es menor");


//
//Case sensitive


//int valor = 30;
//string nombre;

//Console.WriteLine("Ingrese el nombre");
//nombre = Console.ReadLine();

//if (nombre == "Emanuel")
//{
//    Console.WriteLine("Es el nombre ingresado el mismo que está en código");
//}

//if (valor >= 0 && valor <= 100)
//    Console.WriteLine("Está en el intervalo");
//else
//    Console.WriteLine("No está en el intervalo");


//valor = -20;
//if (valor <= 0 || valor >= 100)
//    Console.WriteLine("Está en el conjunto");
//else
//    Console.WriteLine("No está en el conjunto");

//---------------------------
//string mensaje;
//int valor;

//Console.WriteLine("Ingrese un valor");
//valor = int.Parse(Console.ReadLine());

//mensaje = valor >= 10 ? "Es mayor o igual" : "Es menor";

////valor = valor >= 10 ? 5 : valor;

//Console.WriteLine(mensaje);
//Console.WriteLine(valor);

//-----------------------------------------
//5.	Ingresar por pantalla un número entre 0 y 99.
////Informar si el número tiene un dígito o dos.

//int numero;

//Console.WriteLine("Ingrese un número entre 0 y 99");
//numero = int.Parse(Console.ReadLine());

//if (numero >= 10)
//    Console.WriteLine("Tiene dos dígitos");
//else
//    Console.WriteLine("Tiene un solo dígito");

//------------------------------------------
//6.	Ingresar un número y determinar si es mayor a 10 y si es par.

//int numero;

//Console.WriteLine("Ingrese un número entre 0 y 99");
//numero = int.Parse(Console.ReadLine());

//if (numero > 10 && numero % 2 == 0)
//    Console.WriteLine("Cumple");

//--------------------
//double v1 = 4.8, v2 = 3.5;
//double resultado;

//resultado = v1 % v2;

//Console.WriteLine(resultado);

//---------------------------------------------
//2.Ingresar un número y determinar si es mayor a 10 y si es par.

//string mensaje;
//int valor;

//Console.WriteLine("Ingrese el valor");
//valor = int.Parse(Console.ReadLine());

//mensaje = valor > 10 && valor % 2 == 0 ? "Cumple" : "No cumple";

//Console.WriteLine(mensaje);

//------------------
////5.Construir un menú con las siguientes opciones:
////    a.Opción 1: Imprimir “Hola mundo”.
////    b.Opción 2: Imprimir “Adiós”.

//int opcion;

//Console.WriteLine("Ingrese la opción");
//opcion = int.Parse(Console.ReadLine());

//switch (opcion)
//{
//    case 1: Console.WriteLine("Imprimir hola mundo");
//        break;
//    case 2: Console.WriteLine("Imprimir Adiós");
//        break;
//    default:
//        Console.WriteLine("Incorrecto");
//        break;
//}

// 15.Pedir la dirección, la altura y la localidad en tres variables distintas. Mostrar por pantalla 
// lo ingresado por el usuario en una sola frase.

// string direccion, localidad, frase;
// int altura;
// Console.WriteLine("Ingrese su dirección:");
// direccion = Console.ReadLine();

// Console.WriteLine("Ingrese su altura:");
// altura = int.Parse(Console.ReadLine());

// Console.WriteLine("Ingrese su localidad:");
// localidad = Console.ReadLine();

// frase = $"Vives en la calle {direccion}, numero {altura} en la localidad de {localidad}";
// Console.WriteLine(frase);