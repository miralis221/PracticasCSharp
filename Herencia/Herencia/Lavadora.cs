using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Lavadora : Electrodomestico
    {
        int RPM;
        int Kilos;
        public Lavadora()
        {
            RPM = 0;
            Kilos = 0;
        }
        public void SetRPM(int rpm)
        {
            RPM = rpm;
        }
        public int GetRPM()
        {
            return RPM;
        }
        public void SetKilos(int kilos)
        {
            Kilos = kilos;
        }
        public void Mostrar()
        {

        }
    }
}
