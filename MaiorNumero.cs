using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_27._11
{
    public class MaiorNumero
    {
        public int NumberX { get; set; }
        public int NumberY { get; set; }
        public int NumberZ { get; set; }
        public int MaiorNumber { get; set; }

        public void NumberMaior()
        {
            int[] vetor = new int[] { NumberX, NumberY, NumberZ };
            for(int i=0; i < vetor.Length; i++)
            {
                if(vetor[i] > MaiorNumber)
                {
                    MaiorNumber = vetor[i];
                }
            }
            Console.WriteLine("O maior número é: " + MaiorNumber);
        }
    }
}