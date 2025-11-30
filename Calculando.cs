using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_27._11
{
    public class Calculando
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public int Somar()
        {
            return Numero1 + Numero2;
        }

        public int Subtrair()
        {
            return Numero1 - Numero2;
        }   

        public int Multiplicar()
        {
            return Numero1 * Numero2;
        }
        
    }
}