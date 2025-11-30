using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_27._11
{
    public class Media
    {
        public double[] arrayNumeros = new double[5];

        public void CalcularMedia()
        {
            double soma = 0;

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                soma += arrayNumeros[i];
            }

            double media = soma / 5;

            Console.WriteLine("A média dos números inseridos é: " + media);
        }
    }
}