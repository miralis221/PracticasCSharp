using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    class Biblioteca
    {
        List<Libro> ListaLibros;
        public Biblioteca()
        {
            ListaLibros = new List<Libro>();
        }

        public int NumeroLibros()
        {
            return ListaLibros.Count;
        }

        public void AñadorLibro(Libro libro)
        {
            ListaLibros.Add(libro);
        }

        public void BorrarLibro(string titulo)
        {
            bool finded = false;
            int positionToErase = -1;
            foreach(Libro libro in ListaLibros)
            {
                positionToErase++;
                if (libro.GetTitulo()==titulo)
                {
                    finded = true;
                    break;
                }
            }
            if(finded)
            {
                ListaLibros.RemoveAt(positionToErase);
                Console.WriteLine("Libro borrado Correctamente");
            }
            else
            {
                Console.WriteLine("No se ha encontrado");
            }
      
        }

        public void Mostrar()
        {
            Console.WriteLine("******BIBLIOTECA******");
            foreach(Libro libro in ListaLibros)
            {
                libro.Mostrar();
            }
            Console.WriteLine("**********************");
        }
    }
}
