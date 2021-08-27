using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    class Libro
    {
        string Titulo;
        string ISBN;
        Autor AutorLibro;

        public Libro(string titulo, string isbn)
        {
            Titulo = titulo;
            ISBN = isbn;
        }

        public string GetTitulo()
        {
            return Titulo;
        }
        public void AñadirAutor(Autor autor)
        {
            AutorLibro = autor;
        }

        public void Mostrar()
        {
            Console.WriteLine("-------------");
            Console.WriteLine("Titulo:"+Titulo);
            Console.WriteLine("ISBN:" +ISBN);
            AutorLibro.Mostrar();
            Console.WriteLine("--------------");

        }
    }
}
