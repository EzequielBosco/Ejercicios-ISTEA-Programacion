namespace ArreglosMultidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //1
        //int[,] m = {{ 101, 8, 9, 10},
        //                        { 102, 7, 7, 8},
        //                        { 103, 4, 5, 7},
        //                        { 104, 8, 9, 8},
        //                        { 105, 8, 4, 10}};

        //int suma = 0;
        ////a.El promedio de calificaciones de cada alumno.
        ////b.El promedio de calificaciones del primer parcial, segundo parcial y final.

        //for (int i = 0; i < m.GetLength(0); i++)
        //{
        //    suma = 0;
        //    for (int j = 1; j < m.GetLength(1); j++)
        //    {
        //        suma += m[i, j];
        //    }
        //    Console.WriteLine($"El alumno {m[i, 0]} tiene un promedio de {suma / 3}");
        //}

        //for (int j = 1; j < m.GetLength(1); j++)
        //{
        //    suma = 0;
        //    for (int i = 0; i < m.GetLength(0); i++)
        //    {
        //        suma += m[i, j];

        //    }
        //    Console.WriteLine($"El promedio es {suma / m.GetLength(0)}");
        //}

        ////suma = 0;
        ////for (int i = 0; i < m.GetLength(0); i++)
        ////{
        ////    suma += m[i, 1];

        ////}
        ////Console.WriteLine($"El promedio es {suma / m.GetLength(0)}");
        ///
        //---------------------------
        //2
        //int[,] m = {   { 50,0},
        //               { 70,0},
        //               { 100,0}};

        //int aumento = 15;
        //for (int i = 0; i < m.GetLength(0); i++)
        //{
        //    m[i, 1] = m[i, 0] * aumento / 100 + m[i, 0];
        //}

        //for (int i = 0; i < m.GetLength(0); i++)
        //{
        //    for (int j = 0; j < m.GetLength(1); j++)
        //    {
        //        Console.Write(m[i, j] + " ");
        //    }
        //    Console.WriteLine("");
        //}
        }
    }
}