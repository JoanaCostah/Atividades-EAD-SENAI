using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_27._11
{
    public class EhPalindromo
    {
        public string Frase { get; set; }

        public bool Verificar()
        {

            string fraseInvertida = "";

            for (int i = Frase.Length - 1; i >= 0; i--)
            {
                fraseInvertida += Frase[i];
            }

            return Frase == fraseInvertida;

            
        }
    }
}