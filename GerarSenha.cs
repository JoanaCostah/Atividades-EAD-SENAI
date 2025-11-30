using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_27._11
{
    public class GerarSenha
    {
        public int Tamanho { get; set; }

        public void Gerar()
        {
            const string caracteres = "abcdefghijklmnopqrstuvwxyz";

            Random random = new Random();

            char[] senhaArray = new char[Tamanho];

            for (int i = 0; i < Tamanho; i++)
            {
                senhaArray[i] = caracteres[random.Next(caracteres.Length)];
            }

            string senha = new string(senhaArray);
            Console.WriteLine("Senha gerada: " + senha);
        }
    }
}