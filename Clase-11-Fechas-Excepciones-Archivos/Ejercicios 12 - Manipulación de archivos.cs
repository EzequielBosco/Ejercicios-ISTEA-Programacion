namespace ManipulacionArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //int maximo = 0, b = 0;
            //if (File.Exists("tanque.txt") == false)
            //    return;

            //foreach (string linea in File.ReadAllLines("tanque.txt"))
            //{
            //    string[] partes = linea.Split('|');

            //    if (b == 0)
            //    {
            //        maximo = int.Parse(partes[1]);
            //    }
            //    else if (int.Parse(partes[1]) > maximo)
            //    {
            //        maximo = int.Parse(partes[1]);
            //    }
            //}

            //Console.WriteLine($"El máximo es {maximo}");

            //2
            //try
            //{
            //    int x;
            //    int y;

            //    Console.WriteLine("Ingrese un valor");
            //    x = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Ingrese un valor");
            //    y = int.Parse(Console.ReadLine());

            //    File.AppendAllText("Log.txt", DateTime.Now + " - " + "OK " + x / y + Environment.NewLine);

            //}
            //catch (Exception ex)
            //{
            //    File.AppendAllText("Log.txt", DateTime.Now + " - " + "ERROR " + ex.Message + Environment.NewLine);
            //}

            //3
            //string[] leidos = File.ReadAllLines("Paises.txt");
            //string[] cadena;

            //foreach (string item in leidos)
            //{
            //    cadena = item.Split(';');
            //    if (cadena[2] == "Europa")
            //    {
            //        File.AppendAllText("solonombres.txt", cadena[1] + Environment.NewLine);
            //    }
            //}

            //4
            //int[] totales = new int[8];
            //string anio;
            //bool b = true;

            //if (File.Exists("tanque.txt") == false)
            //    return;

            //for (int i = 0; i < totales.Length; i++)
            //{
            //    totales[i] = 0;
            //}

            //foreach (string linea in File.ReadAllLines("visualizaciones.txt"))
            //{
            //    if (!b)
            //    {
            //        string[] partes = linea.Split(',');
            //        anio = partes[0].Substring(0, 4);

            //        totales[int.Parse(anio) - 2015] += int.Parse(partes[1]);
            //    }
            //    else
            //    {
            //        b = false;
            //    }
            //}

            //foreach (int item in totales)
            //{
            //    File.AppendAllText("totales.txt", item.ToString() + Environment.NewLine);
            //}
            

        }
    }
}