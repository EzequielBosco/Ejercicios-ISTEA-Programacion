namespace RegistrosYArreglos
{
    internal class Program
    {
        record Producto
        {
            public int Codigo { get; set; }
            public int Precio { get; set; }
        }
        static void Main(string[] args)
        {
            Producto[] misProductos = new Producto[5];
            Producto[] misProductos2 = new Producto[5];
            Random r = new Random();
            int maximo = 0, minimo = 0;
            for (int i = 0; i < misProductos.Length; i++)
            {
                misProductos[i] = new Producto();
                misProductos[i].Codigo = r.Next(1000, 2000);
                misProductos[i].Precio = r.Next(5000, 10000);
            }

            for (int i = 0; i < misProductos.Length; i++)
            {
                if(i==0)
                {
                    maximo = misProductos[i].Precio;
                    minimo = misProductos[i].Precio;
                }
                else
                {
                    if (misProductos[i].Precio > maximo)
                        maximo = misProductos[i].Precio;
                    if (misProductos[i].Precio < minimo)
                        minimo = misProductos[i].Precio;
                }
            }

            for (int i = 0; i < misProductos.Length; i++)
            {
                Console.WriteLine($"El producto {misProductos[i].Codigo} cuesta ${misProductos[i].Precio}");
            }
            Console.WriteLine($"El máximo es {maximo} y el mínimo es {minimo}");

            //Copio
            for (int i = 0; i < misProductos.Length; i++)
            {
                misProductos2[i] = new Producto();
                misProductos2[i].Codigo = misProductos[i].Codigo;
                misProductos2[i].Precio = (int)Math.Round(misProductos[i].Precio*1.1,0);
            }

            for (int i = 0; i < misProductos.Length; i++)
            {
                Console.WriteLine($"El producto {misProductos2[i].Codigo} cuesta ${misProductos2[i].Precio}");
            }
        }

        //3
//        record Alumno
//        {
//            public int Legajo { get; set; }
//            public int Calificacion { get; set; }
//        }

//        Alumno[] misAlumnos = new Alumno[10];
//        Random r = new Random();
//        int legajoinicial = 1000;
//        int sumatoria = 0, contador = 0;

//            for (int i = 0; i<misAlumnos.Length; i++)
//            {
//                misAlumnos[i] = new Alumno();

//        misAlumnos[i].Legajo = legajoinicial + 1 + i;
//                misAlumnos[i].Calificacion = r.Next(1, 11);
//            }


//            for (int i = 0; i<misAlumnos.Length; i++)
//            {
//                sumatoria += misAlumnos[i].Calificacion;
//                contador++;
//            }

//Console.WriteLine($"El promedio es {sumatoria / contador}");
    }


}