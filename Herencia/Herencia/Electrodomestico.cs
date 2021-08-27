using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Electrodomestico
    {
        bool Encendido;
        int Tension;
        public Electrodomestico()
        {
            Encendido = false;
            Tension = 220;
        }
        public void Enceder()
        {
            Encendido = true;
        }
        public void Apagar()
        {
            Encendido = false;
        }

        public bool EstaEncendido() { return Encendido; }
        public void SetTension(int tension)
        {
            Tension = tension;
        }
        public int GetTension()
        {
            return Tension;
        }
    }
}
