using System.IO;
using System.Text;
using System.Reflection.Emit;

namespace Consola
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Imprimir("PUNTO 1");
            int opciones = 3, posicionX, posicionY;
            int tierra = 0;

            string[,] tablero = { { "T", "A", "A" }, 
                                  { "A", "T", "A" }, 
                                  { "T", "T", "T" } };
            Imprimir("Comenzamos");
            Imprimir("El tablero tiene posiciones maximas de 2x2 (2X, 2Y)");
            while (opciones > 0) {
                Imprimir($"Elija una posicion en X");
                posicionX = int.Parse(Console.ReadLine());
                Imprimir($"Elija una posicion en Y");
                posicionY = int.Parse(Console.ReadLine());
                if (tablero[posicionX, posicionY] == "T") {
                    Imprimir("Es tierra");
                    tierra++;
                } else {
                    Imprimir("Es agua");
                }

                opciones--;
                if (opciones > 0) {
                    Imprimir($"Le quedan {opciones} oportunidades");
                }
            };

            if (tierra == 3) {
                Imprimir("¡El jugador ganó!");
            } else {
                Imprimir("¡El jugador perdió!");
            }

            Imprimir("Puede verificar en el tablero siguiente:");
            for (int i = 0; i < tablero.GetLength(0); i++) {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Imprimir($"Posición [{i},{j}] = {tablero[i,j]}");
                }
            }

            // ---------------------------------------------------------------------

            Imprimir("PUNTO 2");
            string texto;

            if (File.Exists("temperaturas.txt")) {
              Imprimir("Existe");
            }
            else {
              Imprimir("No existe");
            }
            texto = File.ReadAllText("temperaturas.txt");
            // Imprimir(texto);

            string[] lineas = texto.Split('\n');
            string horaMaxima = "";
            string hora = "";
            string fecha = "";
            int dispositivos = 0;
            int maxDispositivos = 0;
            string resultadoHsMaxima;
            string resultadoMaxDispositivos;

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(';');

                if (datos.Length >= 4) {
                    hora = datos[1];
                    fecha = datos[0];
                    dispositivos = int.Parse(datos[3]);

                    if (dispositivos > maxDispositivos)
                    {
                        maxDispositivos = dispositivos;
                        horaMaxima = hora;
                    }
                }
            }

            resultadoHsMaxima = $"{fecha} - {horaMaxima}";
            File.WriteAllText("resultados.txt", resultadoHsMaxima);
            resultadoMaxDispositivos = $"\n{fecha} - {hora} - {maxDispositivos}";
            File.AppendAllText("resultados.txt", resultadoMaxDispositivos);


            // ---------------------------------------------------------------------

            Imprimir("PUNTO 3");
            int numeroEquipo;

            Jugador[] jugadores = new Jugador[10];
            
            Random r = new Random();
            for (int i = 0; i < jugadores.Length; i++)
            {
                jugadores[i] = new Jugador();
                jugadores[i].equipo = r.Next(1, 5);
                jugadores[i].puntaje = r.Next(100, 121);
            }

            Imprimir("Ingrese el numero de equipo:");
            numeroEquipo = int.Parse(Console.ReadLine());

            Imprimir($"Jugadores del equipo {numeroEquipo}:");

            Jugador[] jugadorEquipo = Array.FindAll(jugadores, jug => jug.equipo == numeroEquipo);

            if (jugadorEquipo.Length > 0)
            {
                foreach (Jugador jugador in jugadorEquipo)
                {
                    Imprimir($"Número de equipo: {jugador.equipo}, Puntaje: {jugador.puntaje}");
                }
            }
            else
            {
                Console.WriteLine("No hay jugadores en ese equipo.");
            }

            // ---------------------------------------------------------------------

            Imprimir("Punto 4");

            int gradosSuperados;
            int temperatura = 122;
            bool supera;

            try
            {
                supera = CalderaControl(temperatura, out gradosSuperados);

                if (supera) {
                    Imprimir($"Supera por {gradosSuperados} grados");
                } else {
                    Imprimir("No supero los 100 grados");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Imprimir("Error " + ex.Message);
            }

        }
        // funcion imprimir
        static void Imprimir(object mensaje) {
            string mensajeString = mensaje.ToString();
            Console.WriteLine(mensajeString);
        }

        // funcion punto 4
        static bool CalderaControl(int temperatura, out int gradosSuperados) {
            gradosSuperados = 0;

            if (temperatura < 0) {
                throw new ArgumentOutOfRangeException($"La temperatura {temperatura} es negativa");
            }

            if (temperatura > 100) {
                gradosSuperados = temperatura - 100;
                return true;
            } else {
                return false;
            }
        }

        // record
        record Jugador {
          public int equipo { get; set; }
          public int puntaje { get; set; }
        }
    }
}
