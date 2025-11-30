using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_27._11
{
    public class Calculadora
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public double Somar()
        {
            return Numero1 + Numero2;
        }

        public double Subtrair()
        {
            return Numero1 - Numero2;
        }

        public double Multiplicar()
        {
            return Numero1 * Numero2;
        }

        public double Dividir()
        {
            if (Numero2 != 0)
            {
                return Numero1 / Numero2;
            }
            else
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                return 0;
            }
        }
    }
}