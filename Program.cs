using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicação Cálculos");

            Console.WriteLine($"4 + 2 = {Aritmetica.somar(4, 2)}");
            Console.WriteLine($"4 - 2 = {Aritmetica.subtrair(4, 2)}");

            double t1 = Conversoes.converterTemperatura(Conversoes.ConversaoTemperatura.CelsiusFahrenheit, 36);
            double t2 = Conversoes.converterTemperatura(Conversoes.ConversaoTemperatura.FahrenheitCelsius, 100);

            Console.WriteLine($"36º Célsius = {t1}º Fahrenheit");
            Console.WriteLine($"100º Farhenheit = {t2}º Célsius");

            Console.ReadKey();
        }
    }
}
