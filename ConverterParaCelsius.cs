using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_27._11
{
    public class ConverterParaCelsius
    {
        public double Fahrenheit { get; set; }
        public double Celsius { get; set; }

        public void Converter()
        {
            Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("A temperatura em Celsius é: " + Celsius.ToString("F2"));
        }
    }
}