using System;
using System.Collections.Generic;
using System.Text;

namespace MiPrimerPrograma
{
    class Punto
    {
        int X;
        int Y;
        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Punto()
        {
            X = 0;
            Y = 0;
        }
        public void MostrarPunto()
        {
            Console.WriteLine("El punto es ({0},{1})", X, Y);
        }
        public void SetX(int x) 
        {
            X = x;
        }
        public void SetY(int y)
        {

        }
    }
}
