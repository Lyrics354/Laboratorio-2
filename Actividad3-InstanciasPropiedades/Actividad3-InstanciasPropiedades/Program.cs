namespace Actividad3_InstanciasPropiedades
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Crea el objeto LibroCalificaciones
            //invoca el Constructor de LibroCalificaciones

            LibroCalificaciones myLibro = new LibroCalificaciones("CS101 Programación en C#");
            LibroCalificaciones myLibro2 = new LibroCalificaciones("CS102 Estructuras de Datos");
            Console.WriteLine("El nombre del curso es: {0}", myLibro.NombreCurso);
            Console.WriteLine("El nombre del curso es: {0}", myLibro2.NombreCurso);

            //Pide y lee el nombre del Curso
            Console.WriteLine("\nEscriba el nombre del curso:");
            string elNombreCurso = Console.ReadLine();
            myLibro.NombreCurso = elNombreCurso; //Establece el nombre del curso usando una propiedad
            Console.WriteLine("el nombre del curso es: {0}", myLibro.NombreCurso);
        }
    }
}
