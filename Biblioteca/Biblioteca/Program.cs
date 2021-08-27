using System;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fin = false;
            Biblioteca biblioteca = new Biblioteca();
            int opcion = 0;
            while (!fin)
            {
                MostrarMenu();
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        AñadirLibroALaBiblioteca(biblioteca);
                        break;
                    case 2:
                        biblioteca.Mostrar();
                        break;
                    case 3:
                        BorrarLibroDeLaBiblioteca(biblioteca);
                        break;
                    case 4:
                        Console.WriteLine("Número de libros en la biblioteca: "+biblioteca.NumeroLibros());
                        break;
                    case 5:
                        fin = true;
                        break;
                }
            }
            Console.WriteLine("*****Fin programa*****");
            Console.ReadLine();
        }

        static void MostrarMenu()
        {
            Console.WriteLine("*Menu*");
            Console.WriteLine("1.- Añadir libro a la biblioteca");
            Console.WriteLine("2.- Mostrar biblioteca");
            Console.WriteLine("3.- Borrar libro");
            Console.WriteLine("4.- ¿Número de libros?");
            Console.WriteLine("5.- Salir");
            Console.WriteLine("Opcion: ");
        }

        static Biblioteca AñadirLibroALaBiblioteca(Biblioteca biblioteca)
        {
            string titulo, isbn, autorname, autorsurname;
            Console.Write("Introduzca el titulo");
            titulo = Console.ReadLine();
            Console.Write("Introduzca el ISBN");
            isbn = Console.ReadLine();
            Console.Write("Introduzca el Nombre del autor");
            autorname = Console.ReadLine();
            Console.Write("Introduzca los apellidos");
            autorsurname = Console.ReadLine();

            Autor autor = new Autor(autorname,autorsurname);
            Libro libro = new Libro(titulo,isbn);
            libro.AñadirAutor(autor);
            biblioteca.AñadorLibro(libro);

            return biblioteca;
        }

        static Biblioteca BorrarLibroDeLaBiblioteca(Biblioteca biblioteca)
        {
            Console.WriteLine("titulo a borrar");
            biblioteca.BorrarLibro(Console.ReadLine());
            return biblioteca;
        }

    }
}
