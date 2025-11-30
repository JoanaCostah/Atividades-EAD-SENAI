using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_27._11
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double NotaUm { get; set; }
        public double NotaDois { get; set; }

        public void Media()
        {
            double media = (NotaUm + NotaDois) / 2;

            Console.WriteLine("Aluno(a): " + Nome + "A média é " + media);

            if (media >= 6)
            {
                Console.WriteLine("O aluno esta aprovado");
            }
            else
            {
                Console.WriteLine("O aluno esta reprovado");
            }
        }
    }
}