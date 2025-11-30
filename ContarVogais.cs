using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_27._11
{
    public class ContarVogais
    {
        public string Frase { get; set; }

        public void Contar()
        {
            string vogais = "aeiouAEIOU";

            int QuantidadeVogais = 0;

            for (int i = 0; i < Frase.Length; i++)
            {
                char letra = Frase[i];

                if (vogais.Contains(letra))
                {
                    QuantidadeVogais++;
                }
            }
            Console.WriteLine("A quantidade de vogais na frase é: " + QuantidadeVogais);
        }
    }
}