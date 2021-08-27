using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    class Autor
    {
        string Nombre;
        string Apellidos;
        public Autor(string nombre, string apellidos)
        {
            Nombre = nombre;
            Apellidos = apellidos;
        }
        public void Mostrar()
        {
            Console.WriteLine("Autor: {0} {1}",Nombre,Apellidos);
        }
    }
}
