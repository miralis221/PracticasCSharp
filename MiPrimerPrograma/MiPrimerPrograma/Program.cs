using System;

namespace MiPrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto p1 = new Punto();
            Punto p2 = new Punto(6,8);
            Punto p3 = new Punto(9,2);
            Punto p4 = new Punto();
            p1.SetX(5);
            p1.SetY(2);
            Triangulo triangulo = new Triangulo(p1,p2,p3);
            triangulo.MostrarTriangulo();
            Console.ReadLine();
        }
    }
}
