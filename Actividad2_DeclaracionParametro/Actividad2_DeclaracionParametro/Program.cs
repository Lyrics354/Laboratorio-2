using System;
namespace Actividad2_DeclaracionParametro
{
    public class LibroPruebaCalificaciones
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            MiLibroCalificaciones MyLibro = new MiLibroCalificaciones();
            //Pide el nombre del curso y lo recibe como entrada
            Console.WriteLine("Por favor ingrese el nombre del curso: ");

            string nombreDelCurso = Console.ReadLine();
            Console.WriteLine();

            MyLibro.MostrarMensaje(nombreDelCurso);
        }
    }
}
