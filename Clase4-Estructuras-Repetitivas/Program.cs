namespace Consola
{
    class Program
    {
        enum Dias { Domingo = 1, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado }

        static void Main(string[] args)
        {


        //Random r = new Random();
        //Console.WriteLine(r.Next(0, 28)); //el extremo superior no lo incluye
        //Console.WriteLine(r.Next(0, 28)); //el extremo superior no lo incluye
        //Console.WriteLine(r.Next(0, 28)); //el extremo superior no lo incluye
        //Console.WriteLine(r.Next(0, 28)); //el extremo superior no lo incluye
        //Console.WriteLine(r.Next(0, 28)); //el extremo superior no lo incluye

        Console.WriteLine(Dias.Martes); //obtengo el texto
            Console.WriteLine((int)Dias.Martes); //obtengo el número


            //char letra = 'J';
            //double a = 4.35;

            //Console.WriteLine(letra);
            //Console.WriteLine(Char.IsDigit(letra));
            //Console.WriteLine(Char.IsLetter(letra));
            //Console.WriteLine(Char.IsLower(letra));

            //Console.WriteLine(Math.Round(a, 1));


            //double a = 6.35;
            //double b = 4.36;
            //string nombre = "Emanuel";
            //string ciudad;

            ////Console.WriteLine(a.ToString() + b.ToString());
            ////Console.WriteLine(nombre[2]); //arrancando desde 0;

            //Console.WriteLine("Ingrese la ciudad");
            //ciudad = Console.ReadLine();

            //ciudad = ciudad.ToUpper();

            ////if (ciudad == "PILAR")
            ////    Console.WriteLine("Es correcto");

            //ciudad = ciudad.Replace("R", "S");//caracter viejo, caracter nuevo
            //Console.WriteLine(ciudad);
            //ciudad = ciudad.Substring(0, 2); //desde dónde arranco, cuántos caracteres
            //Console.WriteLine(ciudad);



        }
    }
}

//---------------------------
//Declaración de variables
//int lluvia = 0, dias = 0, cantidad;

//Console.WriteLine("Ingrese la lluvia del día 1");
//cantidad = int.Parse(Console.ReadLine());

//lluvia = lluvia + cantidad; //lluvia+= cantidad;
//dias = dias + 1; //dias+= 1; dias++;

//Console.WriteLine($"Lluvia: {lluvia} - Días {dias}");

//---------------------------
////Imprimir de 0 a un valor máximo
//int i = 0, valor;

//Console.WriteLine("Ingrese el valor");
//valor = int.Parse(Console.ReadLine());

//while( i <= valor)
//{
//    Console.WriteLine(i);
//    i++;
//}

//Console.ReadKey();
//---------------------------
//Imprimir solo valores pares entre 0 y un máximo.

//Sumar de a dos
//Resto contra 2 es cero
//int i = 0, valor;

//Console.WriteLine("Ingrese el valor");
//valor = int.Parse(Console.ReadLine());

////Caso 1
////while (i <= valor)
////{
////    Console.WriteLine(i);
////    i = i + 2;
////}

////Caso 1
////while (i <= valor)
////{
////    if (i % 2 == 0 ) Console.WriteLine(i);
////    i++;
////}

//Console.ReadKey();
//----------------------------



//int valor;

//Console.WriteLine("Ingrese un valor:");
//valor = int.Parse(Console.ReadLine());

//while (valor != 0)
//{
//    if (valor % 2 == 0) Console.WriteLine($"Valor par: {valor}");

//    Console.WriteLine("Ingrese un valor:");
//    valor = int.Parse(Console.ReadLine());
//}

//-----------------------------
//Lectura y permanencia
//int valor;

//Console.WriteLine("Ingrese un valor:");
//valor = int.Parse(Console.ReadLine());

//while (valor != 0)
//{
//    if (valor % 2 == 0) Console.WriteLine($"Valor par: {valor}");

//    Console.WriteLine("Ingrese un valor:");
//    valor = int.Parse(Console.ReadLine());
//}

//-----------------------------------

//-- Break y Continue

//int i = 1, x = 10;

//while (i <= x)
//{
//    if (i == 4) break;
//    Console.WriteLine(i);
//    i++;
//}

//while (i <= x)
//{
//    i++;
//    if (i == 4) continue;
//    Console.WriteLine(i);
//    Console.WriteLine("Hola mundo");
//}

//----------------------------------
//int b = 0, maximo = 1500, numero;

//Console.WriteLine("Ingrese el valor");
//numero = int.Parse(Console.ReadLine());

//while(numero != 0)
//{
//    if (b == 0)
//    {
//        maximo = numero;
//        b = 1;
//    }
//    else if (numero > maximo)
//        maximo = numero;

//    Console.WriteLine("Ingrese el valor");
//    numero = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("El máximo es " + maximo);

//------------------------------------
////1.	Ingresar varios valores mayores que cero y devolver la suma.
////si es negativo, que no sume
//int valor, suma = 0; 

//Console.WriteLine("Ingrese un valor:");
//valor = int.Parse(Console.ReadLine());

////Pregunto para entrar
//while (valor != 0) //Condición de permanencia
//{
//    //Pregunto si es positivo
//    if (valor > 0)
//        suma += valor;

//    //Vuelvo a pedir
//    Console.WriteLine("Ingrese un valor:");
//    valor = int.Parse(Console.ReadLine());
//}

//Console.WriteLine($"La suma es {suma}");
//-----------------------------------------
////2.Crear un programa que permita ingresar al usuario valores 
////    distintos de cero(pueden ser negativos o positivos).Contar cuántos son pares.
//int valor, cont = 0;

//Console.WriteLine("Ingrese un valor:");
//valor = int.Parse(Console.ReadLine());

////Pregunto para entrar
//while (valor != 0) //Condición de permanencia
//{
//    //Pregunto si es par
//    if (valor % 2 == 0)
//        cont++; //cont = cont + 1;

//    //Vuelvo a pedir
//    Console.WriteLine("Ingrese un valor:");
//    valor = int.Parse(Console.ReadLine());
//}

//Console.WriteLine($"La cantidad es {cont}");

//-----------------------------------
////2.Crear un programa que permita ingresar al usuario valores 
////    distintos de cero(pueden ser negativos o positivos).Contar cuántos son pares.
//int valor, cont = 0;

//Console.WriteLine("Ingrese un valor:");
//valor = int.Parse(Console.ReadLine());

////Pregunto para entrar
//while (valor != 0) //Condición de permanencia
//{
//    //Pregunto si es par
//    if (valor % 2 == 0)
//        cont++; //cont = cont + 1;

//    //Vuelvo a pedir
//    Console.WriteLine("Ingrese un valor:");
//    valor = int.Parse(Console.ReadLine());
//}

//Console.WriteLine($"La cantidad es {cont}");

//----------------------------------------
////4.	Indicar si el usuario alguna vez en el ciclo ingresó el valor 10.
//int valor;
////int b;
//bool b = false; //arranco en false

//Console.WriteLine("Ingrese un valor:");
//valor = int.Parse(Console.ReadLine());

////Pregunto para entrar
//while (valor != 0) //Condición de permanencia
//{
//    //Pregunto si es par
//    if (valor == 10)
//        b = true; //lo cambio a true dando a entender que está el 10

//    //Vuelvo a pedir
//    Console.WriteLine("Ingrese un valor:");
//    valor = int.Parse(Console.ReadLine());
//}

//if (b == true) Console.WriteLine("Ingresó el 10");