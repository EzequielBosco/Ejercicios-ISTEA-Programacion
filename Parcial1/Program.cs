namespace Consola
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] lista = { 110, 120, 130, 105, 115 };
            int [] listaR = new int[lista.Length];
            int limite = 120, rechazadas = 0, aceptadas = 0, maximo = 0, precioCancion = 500, opcion = 0, posicion = 0;
            int limiteCompilado = 360, sumaDiscos = 0, disco = 1;

            // 1
            Console.WriteLine("PUNTO 1");
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] > limite)
                {
                    listaR[i] = 0;
                } else {
                    listaR[i] = lista[i];
                }
            }

            Console.WriteLine($"Lista original:");
            foreach(int cancion in lista) {
            Console.WriteLine($"{cancion}");
            }

            Console.WriteLine($"Lista con requisito:");
            foreach(int cancion in listaR) {
            Console.WriteLine($"{cancion}");
            }

            //2
            Console.WriteLine("PUNTO 2");

            for (int i = 0; i < listaR.Length; i++)
            {
                if (lista[i] > limite)
                {
                    rechazadas++;
                } else {
                    aceptadas++;
                }

                if (listaR[i] > maximo) {
                    maximo = lista[i];
                }
            }
            
            do {
            Console.WriteLine("Ingrese una opción:");
            Console.WriteLine("1 - Mostrar la canción más larga");
            Console.WriteLine("2 - Mostrar cuántas fueron rechazadas");
            Console.WriteLine("3 - Mostrar cuánto se tuvo que abonar");
            Console.WriteLine("0 - Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion) {
                case 0:
                    Console.WriteLine("Se sale del programa.");
                    break;
                case 1: 
                    Console.WriteLine($"Cancion más larga en segundos: {maximo}");
                    break;
                case 2:
                    Console.WriteLine($"Canciones rechazadas: {rechazadas}");
                    break;
                case 3: 
                    Console.WriteLine($"Se tuvo que abonar: {aceptadas * precioCancion}$");
                    break;
                default:
                    Console.WriteLine("Ingrese una opción correcta");
                    break;
            }
            } while (opcion != 0);
            
            //3
            Console.WriteLine("PUNTO 3");

            for (int i = 0; i < lista.Length; i++)
            {
                posicion++;
                if (sumaDiscos + lista[i] <= limiteCompilado) {
                    sumaDiscos += lista[i];
                } else {
                    Console.WriteLine($"El disco {disco} tiene {sumaDiscos} segundos");
                    sumaDiscos = lista[i];
                    disco ++;
                }
                Console.WriteLine($"Posicion cancion: {posicion}, Duracion de cancion en segundos: {lista[i]}, Disco: {disco}");
            }
            Console.WriteLine($"El disco {disco} tiene {sumaDiscos} segundos");

            //EXTRA PUNTO 3, por si la consigna pidiera más canciones en cada demo (como la lista de abajo) funcionaria igual.
            // int[] listaPrueba = { 110, 120, 130, 105, 115, 110, 120, 130, 105, 115 };
        }
    }
}